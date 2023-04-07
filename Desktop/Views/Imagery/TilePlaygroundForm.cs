using Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Desktop.Views.Imagery
{
  public partial class TilePlaygroundForm : Form
  {
    private byte[] _binFileData;
    private List<byte[]> _screenTiles;
    private List<byte[]> _spriteTiles;
    private byte[] palette;
    private List<Color> colors;
    private List<string> clutFiles = new List<string>();

    public TilePlaygroundForm(byte[] binFileData)
    {
      _binFileData = binFileData;
      _screenTiles = BinFileHelper.ReadScreenTiles(binFileData);
      _spriteTiles = BinFileHelper.ReadSpriteTiles(binFileData);
      InitializeComponent();
      PopulateCLUTs();
    }

    private void PopulateCLUTs()
    {

      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        var path = folderBrowserDialog1.SelectedPath;
        Directory.GetFiles(path, "*.clut").ToList().ForEach(clut =>
        {
          clutFiles.Add(clut);
          var clutName = Path.GetFileNameWithoutExtension(clut);
          clutComboBox.Items.Add(clutName);
        });
      }
    }

    private void LoadCLUT()
    {

      try
      {
        var filename = clutFiles.Where(cf => Path.GetFileNameWithoutExtension(cf) == clutComboBox.SelectedItem.ToString()).FirstOrDefault();
        palette = File.ReadAllBytes(filename);
        if (palette.Length > 0)
        {
          var length = (int)palette.Length;
          colors = new List<Color>();
          var count = 1;
          for (int i = 0; i < length; i += 4)
          {
            var r = palette[i + 1];
            var g = palette[i + 2];
            var b = palette[i + 3];
            var color = Color.FromArgb(255, r, g, b);
            colors.Add(color);
            count++;
          }
          if (colors.Count < 256)
          {
            var remaining = 256 - colors.Count;
            for (int i = 0; i < remaining; i++)
            {
              colors.Add(Color.FromArgb(255, 0, 0, 0));
            }
          }
          CreatePaletteGrid(colors);
          PopulateScreenTiles();
          //PopulateSpriteTiles();
        }
      }
      catch (Exception)
      {

        throw;
      }

    }

    private void CreatePaletteGrid(List<Color> colors)
    {
      clutPalettePanel.Controls.Clear();
      int cellSize = 25; // Set the size of each grid cell
      int numRows = 16; // Set the number of rows in the grid
      int numCols = 8; // Set the number of columns in the grid
      int padding = 4; // Set the padding between each cell

      int gridWidth = numCols * cellSize + (numCols - 1) * padding; // Calculate the width of the grid
      int gridHeight = numRows * cellSize + (numRows - 1) * padding; // Calculate the height of the grid

      clutPalettePanel.Size = new Size(gridWidth, gridHeight);

      for (int i = 0; i < numRows; i++)
      {
        for (int j = 0; j < numCols; j++)
        {
          int index = i * numCols + j;
          Color color = colors[index];

          PictureBox pictureBox = new PictureBox();
          pictureBox.Location = new Point(j * (cellSize + padding), i * (cellSize + padding));
          pictureBox.Size = new Size(cellSize, cellSize);
          pictureBox.BackColor = color;
          clutPalettePanel.Controls.Add(pictureBox);
        }
      }

    }
    private void PopulateScreenTiles()
    {
      // Create an ImageList and set the ImageSize to 64x64 pixels
      ImageList imageList = new ImageList
      {
        ImageSize = new Size(300, 300)
      };
      foreach (var (tile, index) in _screenTiles.WithIndex())
      {
        ListViewItem item = new ListViewItem();
        var bitmap = CreateTile(index, _screenTiles);
        imageList.Images.Add($"Tile {index}", bitmap);
        item.Name = $"Tile {index}";
        item.ImageKey = $"Tile {index}";
        screenTileListView.Items.Add(item);
      }
      // Assign the ImageList to the MaterialListView's LargeImageList property
      screenTileListView.LargeImageList = imageList;
      screenTileListView.SmallImageList = imageList;
    }

    private void PopulateSpriteTiles()
    {
      // Create an ImageList and set the ImageSize to 64x64 pixels
      ImageList imageList = new ImageList
      {
        ImageSize = new Size(300, 300)
      };

      foreach (var (tile, index) in _spriteTiles.WithIndex())
      {
        var bitmap = CreateTile(index, _spriteTiles);
        imageList.Images.Add($"Tile {index}", bitmap);
        ListViewItem item1 = new ListViewItem($"Tile {index}")
        {
          ImageKey = $"Tile {index}"
        };
        spriteTileListView.Items.Add(item1);
      }
      // Assign the ImageList to the MaterialListView's LargeImageList property
      spriteTileListView.LargeImageList = imageList;
    }

    private Bitmap CreateTile(int index, List<byte[]> tiles)
    {
      var tileArray = tiles[index];
      var tileColors = new List<Color>();
      foreach (var item in tileArray)
      {
        var colorIndex = (int)item;
        tileColors.Add(colors[colorIndex]);
      }
      int cellSize = 8; // Set the size of each grid cell
      int numCols = 8; // Set the number of rows in the grid
      int numRows = 8; // Set the number of columns in the grid

      Bitmap bitmap = new Bitmap(cellSize * numCols, cellSize * numRows);

      for (int i = 0; i < numRows; i++)
      {
        for (int j = 0; j < numCols; j++)
        {
          int k = i * numCols + j;
          Color color = tileColors[k];

          for (int y = 0; y < cellSize; y++)
          {
            for (int x = 0; x < cellSize; x++)
            {
              int bitmapX = j * cellSize + x;
              int bitmapY = i * cellSize + y;
              bitmap.SetPixel(bitmapX, bitmapY, color);
            }
          }
        }
      }

      return bitmap;
    }

    private void clutComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadCLUT();
    }
  }
}
