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

          byte[] decodedPixels = new byte[8];

          byte u1 = (byte)((encodedPixel & 0xF000) >> 12);
          byte y1 = (byte)((encodedPixel & 0x0F00) >> 8);
          byte v1 = (byte)((encodedPixel & 0x00F0) >> 4);
          byte y2 = (byte)(encodedPixel & 0x000F);

          byte prevY = (byte)((previous >> 16) & 0xFF);
          byte prevU = (byte)((previous >> 8) & 0xFF);
          byte prevV = (byte)(previous & 0xFF);

          // u1 / v1 should be dequantized and added to prevU / prevV and will then give you the
          // U / V values for the second pixel of the pair, those of the first pixel are the average
          // of prevU / prevV and the new U/ V.The y1 value should be dequantized and added to prevY
          // to give the Y value for the first pixel; add the dequantized y2  value to that to get the Y
          // value for the second pixel.

          var U2 = (prevU + dequantizer[u1]) % 256;
          var V2 = (prevV + dequantizer[v1]) % 256;

          var U1 = (prevU + U2) / 2;
          var V1 = (prevV + V2) / 2;

          var Y1 = (prevY + dequantizer[y1]) % 256;
          var Y2 = (Y1 + dequantizer[y2]) % 256;

          decodedPixels[0] = 0xFF;
          decodedPixels[1] = (byte)Y1; // r1
          decodedPixels[2] = (byte)U1; // g1
          decodedPixels[3] = (byte)V1; // b1

          decodedPixels[4] = 0xFF;
          decodedPixels[5] = (byte)Y2; // r2
          decodedPixels[6] = (byte)U2; // g2
          decodedPixels[7] = (byte)V2; // b2

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

    private static (int R, int G, int B) YUVtoRGB(int Y, int U, int V)
    {

      int R = Clamp((Y * 256 + 351 * (V - 128)) / 256);
      int G = Clamp((Y * 256) * (86 * (U - 128) + 179 * (V - 128)) / 256);
      int B = Clamp((Y * 256 + 444 * (U - 128)) / 256);

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
