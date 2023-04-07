using Desktop.Models;

namespace Desktop.Helpers
{
  public static class CdiFileHelper
  {
    // Process should split into sectors, then combine into records (files)
    // we then want to process the records (files) and further split and group 
    // into the various types of files (audio, video, etc)
    public static List<SectorInfo> ProcessRTFFileDataSectors(byte[] fileData, string filename)
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
          var offsets = $"_{i - ((byteArrays.Count - 1) * ChunkSize)}_{i + ChunkSize}";
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"{offsets}_d_{recordArray.Count}.bin";
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

    public static void ProcessRTFFileStereoAudioSectors(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
      List<SectorInfo> sectorInfoList = new List<SectorInfo>();

      Dictionary<int, List<byte[]>> byteArrays = new Dictionary<int, List<byte[]>>();
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

        if (!sectorInfo.IsAudio)
          continue;

        if (sectorInfo.IsMono)
          continue;
        // remove first 16 bytes and last 4 bytes of chunk
        chunk = chunk.Skip(HeaderSize).ToArray();
        var bytesToTake = chunk.Length - 24;
        chunk = chunk.Take(bytesToTake).ToArray();

        if (!byteArrays.ContainsKey(sectorInfo.Channel))
        {
          byteArrays[sectorInfo.Channel] = new List<byte[]>();
        }
        byteArrays[sectorInfo.Channel].Add(chunk);
      }
      foreach (var channel in byteArrays.Keys)
      {
        byte[] recordData = byteArrays[channel].SelectMany(a => a).ToArray();
        recordArray.Add(recordData);
        // write record data to file
        var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"_stereo_a_{recordArray.Count}.bin";
        var recordDir = Path.GetDirectoryName(filename) + "\\records\\audio\\" + Path.GetFileNameWithoutExtension(filename);
        Directory.CreateDirectory(recordDir);
        var recordFilePath = Path.Combine(recordDir, recordFileName);
        File.WriteAllBytes(recordFilePath, recordData);
      }
    }

    public static void ProcessRTFFileMonoAudioSectors(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
      List<SectorInfo> sectorInfoList = new List<SectorInfo>();

      Dictionary<int, List<byte[]>> byteArrays = new Dictionary<int, List<byte[]>>();
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

        if (!sectorInfo.IsAudio)
          continue;

        if (!sectorInfo.IsMono)
          continue;
        // remove first 16 bytes and last 4 bytes of chunk
        chunk = chunk.Skip(HeaderSize).ToArray();
        var bytesToTake = chunk.Length - 24;
        chunk = chunk.Take(bytesToTake).ToArray();

        if (!byteArrays.ContainsKey(sectorInfo.Channel))
        {
          byteArrays[sectorInfo.Channel] = new List<byte[]>();
        }
        byteArrays[sectorInfo.Channel].Add(chunk);
      }
      foreach (var channel in byteArrays.Keys)
      {
        byte[] recordData = byteArrays[channel].SelectMany(a => a).ToArray();
        recordArray.Add(recordData);
        // write record data to file
        var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"_mono_a_{recordArray.Count}.bin";
        var recordDir = Path.GetDirectoryName(filename) + "\\records\\audio\\" + Path.GetFileNameWithoutExtension(filename);
        Directory.CreateDirectory(recordDir);
        var recordFilePath = Path.Combine(recordDir, recordFileName);
        File.WriteAllBytes(recordFilePath, recordData);
      }
    }
    
    public static void ProcessRTFFileVideoSectors(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
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

        if (!sectorInfo.IsVideo)
          continue;
        // remove first 16 bytes and last 4 bytes of chunk
        chunk = chunk.Skip(HeaderSize).ToArray();
        var bytesToTake = chunk.Length - 4;
        chunk = chunk.Take(bytesToTake).ToArray();
        byteArrays.Add(chunk);

        if (sectorInfo.IsEOR || sectorInfo.IsEOF)
        {
          WriteRecords(filename, ChunkSize, byteArrays, recordArray, i);
        }
      }
      if (byteArrays.Count > 0)
      {
        WriteRecords(filename, ChunkSize, byteArrays, recordArray, 1);
      }

    }

    private static void WriteRecords(string filename, int ChunkSize, List<byte[]> byteArrays, List<byte[]> recordArray, int i)
    {
      byte[] recordData = byteArrays.SelectMany(a => a).ToArray();
      recordArray.Add(recordData);
      // write record data to file
      var offsets = $"_{i - ((byteArrays.Count - 1) * ChunkSize)}_{i + ChunkSize}";
      var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"{offsets}_v_{recordArray.Count}.bin";
      var recordDir = Path.GetDirectoryName(filename) + "\\records\\video\\" + Path.GetFileNameWithoutExtension(filename);
      Directory.CreateDirectory(recordDir);
      var recordFilePath = Path.Combine(recordDir, recordFileName);
      File.WriteAllBytes(recordFilePath, recordData);
      byteArrays.Clear();
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
