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
          var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? "_v_" : "_d_") + $"{recordArray.Count}.bin";
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\data\\";
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath, recordData);
          byteArrays.Clear();
        }
        if (sectorInfo.IsEOF && byteArrays.Count > 0)
        {
          byte[] recordData = byteArrays.SelectMany(a => a).ToArray();
          recordArray.Add(recordData);
          // write record data to file
          var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? "_v_EOF" : "_d_EOF") + $"{recordArray.Count}.bin";
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\data\\";
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath, recordData);
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

      Dictionary<string, List<byte[]>> byteArrays = new Dictionary<string, List<byte[]>>();
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

        var bps = sectorInfo.BitsPerSampleString.Replace(" ", "_");
        var sampleFreq = sectorInfo.SamplingFrequencyString.Replace(" ", "_");
        var channel = sectorInfo.Channel;
        var key = $"{sectorInfo.FileNumber}_{channel}_{bps}_{sampleFreq}";

        if (!byteArrays.ContainsKey(key))
        {
          byteArrays[key] = new List<byte[]>();
        }
        byteArrays[key].Add(chunk);

        if (sectorInfo.IsEOR || sectorInfo.IsEOF )
        {

          foreach (var baKey in byteArrays.Keys)
          {
            byte[] recordData = byteArrays[baKey].SelectMany(a => a).ToArray();
            recordArray.Add(recordData);
            // write record data to file
            var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
            var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? $"_mpeg_a_{recordArray.Count}.bin": $"_stereo_a_{baKey}_{recordArray.Count}.bin");
            var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\audio_stereo\\";
            Directory.CreateDirectory(recordDir);
            var recordFilePath = Path.Combine(recordDir, recordFileName);
            File.WriteAllBytes(recordFilePath, recordData);
          }
          byteArrays.Clear();
        }
      }
      if (byteArrays.Count > 0)
      {
        foreach (var byteArray in byteArrays)
        {
          // write record data to file
          var recordData = byteArray.Value.SelectMany(s => s).ToArray();
          var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? $"_mpeg_a_EOF.bin" : $"_stereo_a_{byteArray.Key}_EOF.bin");
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\audio_stereo\\";
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath,recordData);
        }

      }
    }

    public static void ProcessRTFFileMonoAudioSectors(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
      List<SectorInfo> sectorInfoList = new List<SectorInfo>();

      Dictionary<string, List<byte[]>> byteArrays = new Dictionary<string, List<byte[]>>();
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

        var bps = sectorInfo.BitsPerSampleString.Replace(" ", "_");
        var sampleFreq = sectorInfo.SamplingFrequencyString.Replace(" ", "_");
        var channel = sectorInfo.Channel;
        var key = $"{sectorInfo.FileNumber}_{channel}_{bps}_{sampleFreq}";

        if (!byteArrays.ContainsKey(key))
        {
          byteArrays[key] = new List<byte[]>();
        }
        byteArrays[key].Add(chunk);

        if (sectorInfo.IsEOR || sectorInfo.IsEOF)
        {
          foreach (var baKey in byteArrays.Keys)
          {
            byte[] recordData = byteArrays[baKey].SelectMany(a => a).ToArray();
            recordArray.Add(recordData);
            // write record data to file
            var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"_mono_a_{baKey}_{recordArray.Count}.bin";
            var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\audio_mono\\";
            Directory.CreateDirectory(recordDir);
            var recordFilePath = Path.Combine(recordDir, recordFileName);
            File.WriteAllBytes(recordFilePath, recordData);
          }
          byteArrays.Clear();
        }
      }
      if (byteArrays.Count > 0)
      {
        foreach (var recordData in byteArrays)
        {
          // write record data to file
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + $"_mono_a_{recordData.Key}_EOF.bin";
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\audio_mono\\";
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath, recordData.Value.SelectMany(s => s).ToArray());
        }

      }

    }
    
    public static void ProcessRTFFileVideoSectors(byte[] fileData, string filename)
    {
      const int ChunkSize = 2352;
      const int Offset = 16;
      const int HeaderSize = 24;
      List<SectorInfo> sectorInfoList = new List<SectorInfo>();
      var path = Path.GetFileNameWithoutExtension(filename);
      Dictionary<string, List<byte[]>> byteArrays = new Dictionary<string, List<byte[]>>();
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
        chunk = chunk.Take(bytesToTake).ToArray();

        var videoEncoding = sectorInfo.VideoString.Replace(" ", "_");
        var resolution = sectorInfo.ResolutionString.Replace(" ", "_");

        var channel = sectorInfo.Channel;
        var key = $"{sectorInfo.FileNumber}_{channel}_{videoEncoding}_{resolution}";

        if (!byteArrays.ContainsKey(key))
        {
          byteArrays[key] = new List<byte[]>();
        }
        byteArrays[key].Add(chunk);

        if (sectorInfo.IsEOR || sectorInfo.IsEOF)
        {

          foreach (var baKey in byteArrays.Keys)
          {
            byte[] recordData = byteArrays[baKey].SelectMany(a => a).ToArray();
            recordArray.Add(recordData);
            // write record data to file
            // check if first 4 bytes of recordData is 0x000001BA
            var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
            var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? $"_v_mpeg_{recordArray.Count}.bin" : $"_v_{baKey}_{recordArray.Count}.bin");
            var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\video\\";
            Directory.CreateDirectory(recordDir);
            var recordFilePath = Path.Combine(recordDir, recordFileName);
            File.WriteAllBytes(recordFilePath, recordData);
          }
          byteArrays.Clear();
        }
      }
      if (byteArrays.Count > 0)
      {
        foreach (var baKey in byteArrays.Keys)
        {
          byte[] recordData = byteArrays[baKey].SelectMany(a => a).ToArray();
          recordArray.Add(recordData);
          // write record data to file
          var isMpeg = recordData[0] == 0x00 && recordData[1] == 0x00 && recordData[2] == 0x01 && recordData[3] == 0xBA;
          var recordFileName = Path.GetFileNameWithoutExtension(filename) + (isMpeg ? $"_v_mpeg_{recordArray.Count}.bin" : $"_v_{baKey}_{recordArray.Count}.bin");
          var recordDir = Path.GetDirectoryName(filename) + "\\records\\" + Path.GetFileNameWithoutExtension(filename) + "\\video\\";
          Directory.CreateDirectory(recordDir);
          var recordFilePath = Path.Combine(recordDir, recordFileName);
          File.WriteAllBytes(recordFilePath, recordData);
        }
        byteArrays.Clear();
      }
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
