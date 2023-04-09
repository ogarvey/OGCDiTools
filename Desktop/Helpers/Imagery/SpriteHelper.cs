using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace Desktop.Helpers.Imagery
{
  public static class SpriteHelper
  {
    public static List<byte[]> GetSpriteBlobs(byte[] spriteBytes)
    {
      List<byte[]> blobs = new List<byte[]>();
      int startPosition = 0;

      for (int i = 0; i < spriteBytes.Length - 1; i++)
      {
        // check for sprite boundary
        if (spriteBytes[i] == 0x00 && spriteBytes[i + 1] == 0x38)
        {
          if (startPosition < i)
          {
            int blobLength = i - startPosition;
            byte[] blob = new byte[blobLength];
            Array.Copy(spriteBytes, startPosition, blob, 0, blobLength);
            blobs.Add(blob);
          }

          startPosition = i + 2;
          i++; // Skip the next byte as it is already checked
        }
      }

      // Add the last blob if it exists
      if (startPosition < spriteBytes.Length)
      {
        int blobLength = spriteBytes.Length - startPosition;
        byte[] blob = new byte[blobLength];
        Array.Copy(spriteBytes, startPosition, blob, 0, blobLength);
        blobs.Add(blob);
      }

      return blobs;
    }
    public class ImageLine
    {
      public int LeftOffset { get; set; }
      public List<byte> Pixels { get; set; }
      public int RemainingPixels { get; set; }
    }
    public static List<ImageLine> DecodeImage(byte[] data)
    {
      List<ImageLine> imageLines = new List<ImageLine>();
      int i = 0;

      while (i < data.Length)
      {
        if (data[i] == 0x00)
        {
          ImageLine line = new ImageLine();
          line.LeftOffset = data[i + 1];
          line.Pixels = new List<byte>();
          i += 2;

          while (i < data.Length)
          {
            if (data[i] == 0x00)
            {
              if (i + 2 < data.Length && data[i + 2] == 0x00)
              {
                line.RemainingPixels = data[i + 1];
                i += 2;
                break;
              }
              else
              {
                int numberOfNullBytes = data[i + 1];
                for (int j = 0; j < numberOfNullBytes; j++)
                {
                  line.Pixels.Add(0x00);
                }
                i += 2;
              }
            }
            else
            {
              line.Pixels.Add(data[i]);
              i++;
            }

            if (i >= data.Length || imageLines.Count > 0 && (line.Pixels.Count == imageLines[0].RemainingPixels + imageLines[0].LeftOffset + imageLines[0].Pixels.Count))
            {
              imageLines.Add(line);
              break;
            }
          }

          imageLines.Add(line);
        } else
        {
          i++;
        }
      }

      return imageLines;
    }
    
    public static Bitmap CreateBitmapFromImageLines(List<ImageLine> imageLines, List<Color> colorPalette)
    {
      var height = imageLines.Count;
      int width = imageLines.Max(x => x.LeftOffset + x.Pixels.Count + x.RemainingPixels);
      Bitmap bitmap = new Bitmap(width, height);
      int currentLine = 0;

      using (Graphics g = Graphics.FromImage(bitmap))
      {
        g.Clear(Color.Transparent);
      }

      foreach (ImageLine line in imageLines)
      {
        int x = line.LeftOffset;

        for (int i = 0; i < line.Pixels.Count; i++)
        {
          byte currentByte = line.Pixels[i];

          // transparent where bytes are null bytes
          if (currentByte == 0x00)
          {
            bitmap.SetPixel(x, currentLine, Color.Transparent);
          }
          else if ((currentByte & 0xF0) == 0xC0)
          {
            byte colorIndex = (byte)(currentByte & 0x0F);
            Color color = colorPalette[colorIndex];
            bitmap.SetPixel(x, currentLine, color);
          }

          x++;
        }

        currentLine++;
      }

      return bitmap;
    }
    }
}
