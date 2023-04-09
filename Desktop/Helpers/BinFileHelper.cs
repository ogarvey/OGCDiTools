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

    public static bool IsMainDataFile(string path)
    {
      string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
      if (fileNameWithoutExtension.Length > 0)
      {
        int lastUnderscoreIndex = fileNameWithoutExtension.LastIndexOf('_');
        if (lastUnderscoreIndex != -1 && lastUnderscoreIndex < fileNameWithoutExtension.Length - 1)
        {
          string numericPart = fileNameWithoutExtension.Substring(lastUnderscoreIndex + 1);
          if (Int32.TryParse(numericPart, out int lastDigits) && lastDigits == 5)
          {
            return true;
          }
        }


      }
      return false;

    }
    public static byte[] ReadMapBytes(byte[] bytes)
    {
      // return first 1600 bytes
      byte[] mapBytes = new byte[1600];
      Array.Copy(bytes, 0, mapBytes, 0, 1600);
      return mapBytes;
    }

    public static List<byte[]> ReadScreenTiles(byte[] data)
    {
      const int ChunkSize = 64;
      const int NumChunks = 32;
      List<byte[]> byteArrayList = new List<byte[]>();

      int offset = 0;
      while (offset < 0x10000)
      {
        for (int i = 0; i < NumChunks; i++)
        {
          byte[] chunk = new byte[ChunkSize];
          Array.Copy(data, offset + i * ChunkSize, chunk, 0, ChunkSize);
          byteArrayList.Add(chunk);
        }
        offset += ChunkSize * NumChunks;
      }
      return byteArrayList;
    }

    public static List<byte[]> ReadSpriteTiles(byte[] data)
    {
      const int ChunkSize = 64;
      const int NumChunks = 32;
      List<byte[]> byteArrayList = new List<byte[]>();

      int offset = 0x1e800;
      while (offset < 0x27000)
      {
        for (int i = 0; i < NumChunks; i++)
        {
          byte[] chunk = new byte[ChunkSize];
          Array.Copy(data, offset + i * ChunkSize, chunk, 0, ChunkSize);
          byteArrayList.Add(chunk);
        }
        offset += ChunkSize * NumChunks;
      }
      return byteArrayList;
    }

  }
}
