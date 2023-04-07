﻿using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using Rectangle = System.Drawing.Rectangle;

namespace Desktop.Helpers
{
  public static class Utilities
  {
    public static int[] Contains808FSequence(byte[] data)
    {
      const int MaxSequenceLength = 64;
      byte[] sequence = new byte[MaxSequenceLength];
      int sequenceLength = 0;
      int[] offsets = new int[65535];
      int foundOffsets = 0;

      for (int i = 0; i < data.Length; i++)
      {
        if (data[i] >= 0x01 && data[i] <= 0x1A)
        {
          sequence[sequenceLength++] = data[i];

          if (sequenceLength == MaxSequenceLength)
          {
            // Found a sequence of 64 bytes
            offsets[foundOffsets++] = i - MaxSequenceLength;
            sequenceLength = 0;
          }
        }
        else
        {
          // Reset the current sequence
          sequenceLength = 0;
        }
      }

      // No sequence of 64 bytes found
      return offsets;
    }

    private readonly static int[] dequantizer = { 0, 1, 4, 9, 16, 27, 44, 79, 128, 177, 212, 229, 240, 247, 252, 255 };

    //decode DYUV image to RGB bitmap
    public static Bitmap DecodeDYUVImage(byte[] encodedData, int Width = 384, int Height = 240)
    {
      int encodedIndex = 0;                               //reader index
      int width = Width, height = Height;                      //output dimensions
      byte[] decodedImage = new byte[width * height * 4]; //decoded image array
      uint initialY = 16;    //initial Y value (per line)
      uint initialU = 128;    //initial U value (per line)
      uint initialV = 128;    //initial V value (per line)

      //loop through all output lines
      for (int y = 0; y < height; y++)
      {
        //re-initialize previous YUV value
        uint prevY = initialY;
        uint prevU = initialU;
        uint prevV = initialV;

        //loop through each pixel in line
        for (int x = 0; x < width; x += 2)
        {
          //read DYUV value from source
          int encodedPixel = ((encodedData[encodedIndex] << 8) | encodedData[encodedIndex + 1]);

          //parse encoded pixel to each delta value
          byte dU1 = (byte)((encodedPixel & 0xF000) >> 12);
          byte dY1 = (byte)((encodedPixel & 0x0F00) >> 8);
          byte dV1 = (byte)((encodedPixel & 0x00F0) >> 4);
          byte dY2 = (byte)(encodedPixel & 0x000F);

          //dequantize dYUV to YUV
          var Yout1 = (prevY + dequantizer[dY1]) % 256;
          var Uout2 = (prevU + dequantizer[dU1]) % 256;   //Uout2 is the output when dequantizing
          var Vout2 = (prevV + dequantizer[dV1]) % 256;   //Vout2 is the output when dequantizing
          var Yout2 = (Yout1 + dequantizer[dY2]) % 256;   //Yout2 is based on You1, not prevY

          //interpolate U and V to double resolution and determine UVout1
          var Uout1 = (prevU + Uout2) / 2;
          var Vout1 = (prevV + Vout2) / 2;

          //store latest YUV values for next iteration
          prevY = (uint)Yout2;
          prevU = (uint)Uout2;
          prevV = (uint)Vout2;

          //decode each YUV set to RGB
          (int R1, int G1, int B1) = YUVtoRGB((int)Yout1, (int)Uout1, (int)Vout1);
          (int R2, int G2, int B2) = YUVtoRGB((int)Yout2, (int)Uout2, (int)Vout2);

          //write RGB to output array
          int decodedIndex = (y * width + x) * 4; //each iteration there are 2 pixels decoded, therefor the index moves 8 steps
          decodedImage[decodedIndex + 0] = (byte)B1;
          decodedImage[decodedIndex + 1] = (byte)G1;
          decodedImage[decodedIndex + 2] = (byte)R1;
          decodedImage[decodedIndex + 3] = 0xff;
          decodedImage[decodedIndex + 4] = (byte)B2;
          decodedImage[decodedIndex + 5] = (byte)G2;
          decodedImage[decodedIndex + 6] = (byte)R2;
          decodedImage[decodedIndex + 7] = 0xff;

          //increment reader
          encodedIndex += 2;
        }
      }

      //create bitmap from RGB array
      Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
      BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
      Marshal.Copy(decodedImage, 0, bitmapData.Scan0, decodedImage.Length);
      bitmap.UnlockBits(bitmapData);

      return bitmap;
    }

    private static (int R, int G, int B) YUVtoRGB(int Y, int U, int V)
    {
      //added additional parenthesis to ensure "/256" is done last
      int R = Clamp((Y * 256 + 351 * (V - 128)) / 256);
      int G = Clamp(((Y * 256) - (86 * (U - 128) + 179 * (V - 128))) / 256);
      int B = Clamp((Y * 256 + 444 * (U - 128)) / 256);

      return (R, G, B);
    }

    private static int Clamp(int value)
    {
      if (value < 0) { return 0; }
      if (value > 255) { return 255; }
      return value;
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
      if (hexString.Length % 2 != 0)
      {
        throw new ArgumentException("Input string must contain even number of bytes of hex data", nameof(hexString));
      }

      byte[] byteArray = new byte[hexString.Length / 2];
      for (int i = 0; i < hexString.Length/2; i++)
      {
        string byteString = hexString.Substring(i * 2, 2);
        byteArray[i] = byte.Parse(byteString, NumberStyles.HexNumber);
      }

      return byteArray;
    }
  }
}
