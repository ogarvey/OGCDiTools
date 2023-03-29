using Desktop.Models;

namespace Desktop.Helpers
{
  public static class CdiFileHelper
  {
    // Process should split into sectors, then combine into records (files)
    // we then want to process the records (files) and further split and group 
    // into the various types of files (audio, video, etc)
    public static List<SectorInfo> ProcessRTFFile(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
      const int ErrorBytes = 280;
      List<SectorInfo> sectorInfoList = new List<SectorInfo>();

      List<byte[]> byteArrays = new List<byte[]>();
      List<byte[]> recordArray = new List<byte[]>();

      for (int i = 0, j = 1; i < fileData.Length; i += ChunkSize)
      {
        byte[] chunk = new byte[ChunkSize];
        int chunkSize = Math.Min(ChunkSize, fileData.Length - i);
        Array.Copy(fileData, i, chunk, 0, chunkSize);

        if (chunk.Length <= Offset + 4) continue;

        var sectorInfo = new SectorInfo(Path.GetFileName(filename));
        sectorInfo.SectorIndex = j;
        sectorInfo.FileNumber = chunk[Offset];
        sectorInfo.Channel = chunk[Offset + 1];
        sectorInfo.SubMode = chunk[Offset + 2];
        sectorInfo.CodingInformation = chunk[Offset + 3];

        if (sectorInfo.IsEmptySector)
          continue;


        sectorInfoList.Add(sectorInfo);

        if (!sectorInfo.IsData)
          continue;
        // remove first 16 bytes and last 4 bytes of chunk
        chunk = chunk.Skip(HeaderSize).ToArray();
        var bytesToTake = chunk.Length - ErrorBytes;
        chunk = chunk.Take(bytesToTake).ToArray();
        byteArrays.Add(chunk);

        if (sectorInfo.IsEOR)
        {
          byte[] recordData = byteArrays.SelectMany(a => a).ToArray();
          recordArray.Add(recordData);
          // write record data to file
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"_{recordArray.Count}.bin";
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename);
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath, recordData);
          List<byte[]> clut = FindClutColorTable(recordData);
          if (clut.Count > 0)
          {
            var recordClutFileName = Path.GetFileNameWithoutExtension(filename) + $"_{recordArray.Count}.clut";
            var recordClutPath = Path.Combine(Path.GetDirectoryName(filename) + "\\records\\", recordClutFileName);
            File.WriteAllBytes(recordClutPath, clut.SelectMany(a => a).ToArray());
          }
          byteArrays.Clear();
        }
      }

      return sectorInfoList;
    }

    private static List<byte[]> FindClutColorTable(byte[] data)
    {
      const int ClutHeaderSize = 4;
      byte[] clut = new byte[256];
      List<byte[]> clutHeaders = new List<byte[]>() {
        new byte[] { 0xC3, 0x00, 0x00, 0x00 },
        new byte[] { 0xC3, 0x00, 0x00, 0x01 },
        new byte[] { 0xC3, 0x00, 0x00, 0x02 },
        new byte[] { 0xC3, 0x00, 0x00, 0x03 }
      };
      List<byte[]> clutBanks = new List<byte[]>();

      for (int bs = 0; bs <= 3; bs++)
      {
        for (int i = 0; i <= data.Length - ClutHeaderSize; i++)
        {
          if (data[i] == clutHeaders[bs][0] && data[i + 1] == clutHeaders[bs][1] &&
              data[i + 2] == clutHeaders[bs][2] && data[i + 3] == clutHeaders[bs][3])
          {
            Array.Copy(data, i + ClutHeaderSize, clut, 0, clut.Length);
            clutBanks.Add(clut);
            clut = new byte[256];
            break;
          }
        }
      }

      return clutBanks;
    }
  }
}
