using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace Desktop.Helpers
{
  public static class ColorHelper
  {
    public static Color GetColorFromPalette(byte[] palette, int index)
    {
      // read the 4 bytes at index and convert to colour
      byte r = palette[index];
      byte g = palette[index + 1];
      byte b = palette[index + 2];
      byte a = palette[index + 3];
      return Color.FromArgb(a, r, g, b);
    }
  }
}
