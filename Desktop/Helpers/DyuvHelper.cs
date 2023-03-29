using SixLabors.ImageSharp.ColorSpaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Desktop.Helpers
{
  public static class DyuvHelper
  {
    private static readonly (byte, byte, byte) DEFAULT_YUV = (16, 128, 128);
    private static readonly byte[] QUANT_TABLE = {
        0, 1, 4, 9,
        16, 27, 44, 79,
        128, 177, 212, 229,
        240, 247, 252, 255
    };

    public static Bitmap ImageSharpToBitmap(Image<Rgb24> imageSharp)
    {
      using (MemoryStream stream = new MemoryStream())
      {
        imageSharp.Save(stream, new SixLabors.ImageSharp.Formats.Bmp.BmpEncoder());
        stream.Seek(0, SeekOrigin.Begin);
        return new Bitmap(stream);
      }
    }

    public static Image<Rgb24> ToPIL(byte[] data, int Width, int Height)
    {
      (byte[] Y, byte[] U, byte[] V) yuv444p = ToYUV444P(data, Width, Height);
      int width = Width;
      int height = Height;
      Image<Rgb24> rgbImage = new Image<Rgb24>(width, height);

      for (int y = 0; y < height; y++)
      {
        for (int x = 0; x < width; x++)
        {
          int idx = y * width + x;

          int yValue = yuv444p.Y[idx];
          int uValue = yuv444p.U[idx] - 128;
          int vValue = yuv444p.V[idx] - 128;

          int r = Math.Clamp(yValue + (int)(1.402 * vValue), 0, 255);
          int g = Math.Clamp(yValue - (int)(0.344 * uValue) - (int)(0.714 * vValue), 0, 255);
          int b = Math.Clamp(yValue + (int)(1.772 * uValue), 0, 255);

          rgbImage[x, y] = new Rgb24((byte)r, (byte)g, (byte)b);
        }
      }

      return rgbImage;
    }

    public static (byte[] Y, byte[] U, byte[] V) ToYUV444P(byte[] data, int Width, int Height)
    {
      (byte[] Y, byte[] U, byte[] V) yuv422p = ToYUV422P(data, Width, Height);
      byte[] Yout = yuv422p.Y;
      byte[] Uin = yuv422p.U;
      byte[] Vin = yuv422p.V;

      byte[] Uout = new byte[Width * Height];
      byte[] Vout = new byte[Width * Height];

      for (int y = 0; y < Height; y++)
      {
        for (int x = 0; x < Width; x += 2)
        {
          int idx = y * Width + x;

          Uout[idx] = Uin[idx / 2];
          if (x < Width - 2)
            Uout[idx + 1] = (byte)((Uin[idx / 2] + Uin[(idx / 2) + 1]) / 2);
          else
            Uout[idx + 1] = Uin[idx / 2];

          Vout[idx] = Vin[idx / 2];
          if (x < Width - 2)
            Vout[idx + 1] = (byte)((Vin[idx / 2] + Vin[(idx / 2) + 1]) / 2);
          else
            Vout[idx + 1] = Vin[idx / 2];
        }
      }

      return (Yout, Uout, Vout);
    }

    public static (byte[] Y, byte[] U, byte[] V) ToYUV422P(byte[] Data, int Width, int Height)
    {
      (byte, byte, byte)[] InitialValues = new (byte, byte, byte)[Height];
      for (int i = 0; i < Height; i++)
        InitialValues[i] = DEFAULT_YUV;
      
      byte[] Y = new byte[Width * Height];
      byte[] U = new byte[Width * Height / 2];
      byte[] V = new byte[Width * Height / 2];

      for (int y = 0; y < Height; y++)
      {
        byte Yprev = InitialValues[y].Item1;
        byte Uprev = InitialValues[y].Item2;
        byte Vprev = InitialValues[y].Item3;

        for (int x = 0; x < Width; x += 2)
        {
          int idx = y * Width + x;
          byte B0 = Data[idx];
          byte B1 = Data[idx + 1];

          byte dU = (byte)((B0 & 0xF0) >> 4);
          byte dY0 = (byte)(B0 & 0x0F);
          byte dV = (byte)((B1 & 0xF0) >> 4);
          byte dY1 = (byte)(B1 & 0x0F);

          Yprev = (byte)((Yprev + QUANT_TABLE[dY0]) & 0xFF);
          Y[idx] = Yprev;

          Yprev = (byte)((Yprev + QUANT_TABLE[dY1]) & 0xFF);
          Y[idx + 1] = Yprev;

          Uprev = (byte)((Uprev + QUANT_TABLE[dU]) & 0xFF);
          U[idx / 2] = Uprev;

          Vprev = (byte)((Vprev + QUANT_TABLE[dV]) & 0xFF);
          V[idx / 2] = Vprev;
        }
      }

      return (Y, U, V);
    }
  }
}
