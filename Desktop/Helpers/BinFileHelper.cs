using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Helpers
{
  public static class BinFileHelper
  {
    public static List<string> GetMapFiles(string path)
    {
      string[] files = Directory.GetFiles(path, "*.bin");
      List<string> matchingFiles = new List<string>();

      foreach (string file in files)
      {
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
        if (fileNameWithoutExtension.Length > 0)
        {
          int lastUnderscoreIndex = fileNameWithoutExtension.LastIndexOf('_');
          if (lastUnderscoreIndex != -1 && lastUnderscoreIndex < fileNameWithoutExtension.Length - 1)
          {
            string numericPart = fileNameWithoutExtension.Substring(lastUnderscoreIndex + 1);
            if (Int32.TryParse(numericPart, out int lastDigits) && lastDigits > 5)
            {
              matchingFiles.Add(file);
            }
          }
        }

      }

      return matchingFiles;

    }
    public static byte[] ReadMapBytes(byte[] bytes)
    {
      // return first 1600 bytes
      byte[] mapBytes = new byte[1600];
      Array.Copy(bytes, 0, mapBytes, 0, 1600);
      return mapBytes;
    }

    public static List<byte[]> ReadByteArrayIntoList(byte[] data)
    {
      const int ChunkSize = 64;
      const int NumChunks = 32;
      const int SkipSize = 280;
      byte[] clutHeader = new byte[] { 0xC3, 0x00, 0x00, 0x00 };
      List<byte[]> byteArrayList = new List<byte[]>();

      int offset = 0;
      while (offset <= data.Length - ChunkSize * NumChunks)
      {
        for (int i = 0; i < NumChunks; i++)
        {
          byte[] chunk = new byte[ChunkSize];
          Array.Copy(data, offset + i * ChunkSize, chunk, 0, ChunkSize);
          byteArrayList.Add(chunk);
        }
        offset += ChunkSize * NumChunks;

        if (HasClutColorTable(byteArrayList, clutHeader))
        {
          break;
        }
      }

      return byteArrayList;
    }

    private static bool HasClutColorTable(List<byte[]> byteArrayList, byte[] clutHeader)
    {
      byte[] data = byteArrayList.SelectMany(a => a).ToArray();
      for (int i = 0; i <= data.Length - clutHeader.Length; i++)
      {
        if (data[i] == clutHeader[0] && data[i + 1] == clutHeader[1] &&
            data[i + 2] == clutHeader[2] && data[i + 3] == clutHeader[3])
        {
          return true;
        }
      }

      return false;
    }
  }
}
