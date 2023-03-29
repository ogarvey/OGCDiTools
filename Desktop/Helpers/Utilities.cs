using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Desktop.Helpers
{
  public static class Utilities
  {
    private readonly static byte[] dequantizer = { 0, 1, 4, 9, 16, 27, 44, 79, 128, 177, 212, 229, 240, 247, 252, 255 };
    public static Bitmap DecodeDYUVImage(byte[] encodedData)
    {
      int encodedIndex = 0, width = 384, height = 240;
      byte[] decodedImage = new byte[width * height * 4];
      uint initialDYUV = (16 << 16) | (128 << 8) | 128;

      for (int y = 0; y < height; y++)
      {
        uint previous = initialDYUV;
        for (int x = 0; x < width; x += 2)
        {
          ushort encodedPixel = (ushort)((encodedData[encodedIndex] << 8) | encodedData[encodedIndex + 1]);
          encodedIndex += 2;

          byte[] decodedPixels = DecodeDYUVPixel(encodedPixel, previous);
          int decodedIndex = (y * width + x) * 4;
          Array.Copy(decodedPixels, 0, decodedImage, decodedIndex, 8);

          previous = (uint)(decodedPixels[5] << 16 | decodedPixels[6] << 8 | decodedPixels[7]);

        }
      }
      Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
      BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
      Marshal.Copy(decodedImage, 0, bitmapData.Scan0, decodedImage.Length);
      bitmap.UnlockBits(bitmapData);

      return bitmap;
    }
    
    public static byte[] DecodeDYUVPixel(ushort pixel, uint previous)
    {
      byte[] decodedPixels = new byte[8];

      byte u1 = (byte)((pixel & 0xF000) >> 12);
      byte y1 = (byte)((pixel & 0x0F00) >> 8);
      byte v1 = (byte)((pixel & 0x00F0) >> 4);
      byte y2 = (byte)(pixel & 0x000F);
      
      byte prevY = (byte)((previous >> 16) & 0xFF);
      byte prevU = (byte)((previous >> 8) & 0xFF);
      byte prevV = (byte)(previous & 0xFF);

      var Y = (prevY + dequantizer[y1]) % 256;
      var U = (prevU + dequantizer[u1]) % 256;
      var V = (prevV + dequantizer[v1]) % 256;
      
      (int R, int G, int B) = YUVtoRGB(Y, U, V);

      
      decodedPixels[0] = 0xFF;
      decodedPixels[1] = (byte)(R); // r1
      decodedPixels[2] = (byte)(G); // g1
      decodedPixels[3] = (byte)(B); // b1
      
      decodedPixels[4] = 0xFF;
      decodedPixels[5] = decodedPixels[1]; // r2
      decodedPixels[6] = decodedPixels[2]; // g2
      decodedPixels[7] = decodedPixels[3]; // b2

      return decodedPixels;
    }

    private static (int R, int G, int B) YUVtoRGB(int Y, int U, int V)
    {

      int R = Clamp(Y * 256 + 351 * (V - 128) / 256);
      int G = Clamp((Y * 256) * (86*(U-128)+179*(V-128)) / 256);
      int B = Clamp(Y * 256 + 444 * (U - 128) / 256);

      return (R, G, B);
    }

    private static int Clamp(int value)
    {
      if (value < 0)
      {
        return 0;
      }
      else if (value > 255)
      {
        return 255;
      }
      else
      {
        return value;
      }
    }


    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
    {
      return source.Select((item, index) => (item, index));
    }

    public static byte[] ParseHex(string hexString)
    {
      if (hexString == null)
      {
        throw new ArgumentNullException(nameof(hexString));
      }

      hexString = hexString.Replace(" ", "").Replace("\r", "").Replace("\n", "");
      if (hexString.Length != 128)
      {
        throw new ArgumentException("Input string must contain 64 bytes of hex data", nameof(hexString));
      }

      byte[] byteArray = new byte[hexString.Length / 2];
      for (int i = 0; i < 64; i++)
      {
        string byteString = hexString.Substring(i * 2, 2);
        byteArray[i] = byte.Parse(byteString, NumberStyles.HexNumber);
      }

      return byteArray;
    }
  }
}
