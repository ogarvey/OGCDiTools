using Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
  public partial class MapScreenForm : Form
  {
    private byte[] _mapData;
    private List<byte[]> _tiles;
    private List<Color> _colors;
    private Bitmap _screenBitmap;
    public MapScreenForm(byte[] mapData, List<byte[]> tiles, List<Color> colors)
    {
      _mapData = mapData;
      _tiles = tiles;
      _colors = colors;
      InitializeComponent();
    }

    public void SetMapData(byte[] mapData)
    {
      _mapData = mapData;
    }

    public void ExportAllMaps()
    {

      var binForm = this.ParentForm as BINForm;
      var filename = binForm?.filename;
      if (!string.IsNullOrEmpty(filename))
      {
        var mapFiles = BinFileHelper.GetMapFiles(Path.GetDirectoryName(filename));
        foreach (var file in mapFiles)
        {
          var newFile = Path.GetFileNameWithoutExtension(file) + ".png";
          var path = Path.GetDirectoryName(filename) + @"/screens";
          Directory.CreateDirectory(path);
          var outputFile = Path.Combine(path, newFile);
          _mapData = BinFileHelper.ReadMapBytes(File.ReadAllBytes(file));
          CreateScreenImage();
          exportBitmap(outputFile);
        }
      }
    }


    private void CreateScreenImage()
    {
      var mapTiles = new List<byte[]>();
      for (int i = 0; i < _mapData.Length; i += 2)
      {
        int index = (_mapData[i] << 8) + _mapData[i + 1];
        byte[] tile = new byte[64];
        Array.Copy(_tiles[index], tile, 64);
        mapTiles.Add(tile);
      }
      var tempScreenBitmap = new Bitmap(320, 160);
      for (int y = 0; y < 160; y++)
      {
        for (int x = 0; x < 320; x++)
        {
          int tileX = x / 8;
          int tileY = y / 8;
          int tileIndex = tileX + (tileY * 40);
          int tilePixelX = x % 8;
          int tilePixelY = y % 8;
          int tilePixelIndex = tilePixelX + (tilePixelY * 8);
          int colorIndex = mapTiles[tileIndex][tilePixelIndex];
          Color color = _colors[colorIndex];
          tempScreenBitmap.SetPixel(x, y, color);
        }
      }
      _screenBitmap = BitmapHelper.Scale4(tempScreenBitmap);
      panel1.BackgroundImage = _screenBitmap;
    }

    private void exportScreenBtn_Click(object sender, EventArgs e)
    {
      exportBitmap(null);
    }

    private void exportBitmap(string? newFilename)
    {
      string filename = string.IsNullOrEmpty(newFilename) ? GetFilename() : newFilename; // Change this to the filename you want to use
      if (!string.IsNullOrEmpty(filename))
      {
        _screenBitmap.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
      }
    }

    private string GetFilename()
    {
      var binForm = this.ParentForm as BINForm;
      var filename = binForm?.filename;
      if (!string.IsNullOrEmpty(filename))
      {
        var file = Path.GetFileNameWithoutExtension(filename) + ".png";
        var path = Path.GetDirectoryName(filename) + @"/screens";
        Directory.CreateDirectory(path);
        var outputFile = Path.Combine(path, file);
        return outputFile;
      }
      MessageBox.Show("Couldn't find file.");
      return "";
    }

    private void createScreenBtn_Click(object sender, EventArgs e)
    {
      CreateScreenImage();
    }

    private void exportAllBtn_Click(object sender, EventArgs e)
    {
      ExportAllMaps();
    }

    private void tryDyuvBtn_Click(object sender, EventArgs e)
    {
    }

   
  }
}
