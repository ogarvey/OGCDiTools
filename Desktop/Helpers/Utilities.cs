using System.Globalization;

namespace Desktop.Helpers
{
  public static class Utilities
  {
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
