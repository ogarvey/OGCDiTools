﻿using Desktop.Helpers;
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
using Rectangle = System.Drawing.Rectangle;
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
    ImageList imageList = new ImageList();
    private const int GridSize = 32;
    private const int CellSize = 32;
    private int selectedTileIndex = 0;
    private PictureBox[,] _grid;

    public TilePlaygroundForm(byte[] binFileData)
    {
      imageList.ImageSize = new Size(128, 128);
      _binFileData = binFileData;
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

    private void ExtractPalette()
    {
      var palette = _binFileData.Skip(124928).Take(128).ToArray();
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
      }
    }

    private void LoadCLUT()
    {
      imageList.Images.Clear();
      listView1.Items.Clear();
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
      int numRows = 4; // Set the number of rows in the grid
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
      PopulateScreenTiles();

    }

    private void PopulateScreenTiles()
    {
      //_screenTiles = BinFileHelper.ReadScreenTiles(_binFileData);
      //foreach (var (tile, index) in _screenTiles.WithIndex())
      //{
      //  var bitmap = CreateTile(index, _screenTiles);
      //  imageList.Images.Add($"Tile {index}", bitmap);
      //  ListViewItem item1 = new ListViewItem($"Tile {index}")
      //  {
      //    ImageIndex = index
      //  };
      //  listView1.Items.Add(item1);
      //}
      PopulateInventoryTiles();
      // Assign the ImageList to the MaterialListView's LargeImageList property
    }

    private void PopulateInventoryTiles()
    {
      _spriteTiles = BinFileHelper.ReadSpriteTiles(_binFileData);
      var spriteIndex = 0;
      foreach (var (tile, index) in _spriteTiles.WithIndex())
      {

        var bitmap = CreateTile(index, _spriteTiles);
        imageList.Images.Add($"Tile {spriteIndex + index}", bitmap);
        ListViewItem item1 = new ListViewItem($"Tile {spriteIndex + index}")
        {
          ImageIndex = spriteIndex + index
        };
        listView1.Items.Add(item1);
      }
      listView1.LargeImageList = imageList;
      listView1.SmallImageList = imageList;
      InitializeGrid();
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
      int cellSize = 4; // Set the size of each grid cell
      int numCols = 8; // Set the number of rows in the grid
      int numRows = 8; // Set the number of columns in the grid

      Bitmap bitmap = new Bitmap(cellSize * numCols, cellSize * numRows);

      for (int i = 0; i < numRows; i++)
      {
        for (int j = 0; j < numCols; j++)
        {
          int k = i * numCols + j;
          Color color = tileColors[k];
          if (color == Color.FromArgb(84, 84, 84))
          {
            color = Color.Transparent;
          }
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
      ExtractPalette();
    }

    private void InitializeGrid()
    {
      var tileIndex = 2;
      _grid = new PictureBox[GridSize, GridSize];
      for (int i = 0; i < 16; i++)
      {
        if (tileIndex >= 544) break;
        for (int j = 0; j < 32; j++)
        {
          if (tileIndex >= 544) break;
          var pictureBox = new PictureBox
          {
            Width = CellSize,
            Height = CellSize,
            Location = new Point(j * CellSize, i * CellSize),
            BorderStyle = BorderStyle.FixedSingle,
            Tag = new Point(j, i) // Store grid position for easy retrieval on click
          };

          pictureBox.Image = imageList.Images[tileIndex];
          tileIndex++;
          pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

          _grid[j, i] = pictureBox;
          panel1.Controls.Add(pictureBox);
        }
      }
      var bitmaps = GenerateFinalImages(_grid);
      foreach (var (img, index) in bitmaps.WithIndex())
      {
        img.Save(@$"C:\Dev\Projects\Gaming\CD-i\LLExtractRaw\Laser Lords\records\Inventory\Sprites\inventory_{index}.png");
        var scaled = BitmapHelper.Scale4(img);
        scaled.Save(@$"C:\Dev\Projects\Gaming\CD-i\LLExtractRaw\Laser Lords\records\Inventory\Spritesx4\inventory_{index}.png");
      }
    }

    private void PictureBox_Click(object sender, EventArgs e)
    {
      if (sender is PictureBox pictureBox && pictureBox.Tag is Point position)
      {
        // Do something with the selected cell, for example, change its background color
        pictureBox.Image = imageList.Images[selectedTileIndex];
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        // The 'position' variable contains the row and column of the clicked PictureBox
        int row = position.X;
        int col = position.Y;
        // Do something with the row and col, for example, update the state of the game or the UI
      }
    }

    public List<Bitmap> GenerateFinalImages(PictureBox[,] grid)
    {
      int columns = 32;
      int rows = 16;
      int largeImageRows = 4;
      int largeImageColumns = 4;
      int smallImageSize = 2;

      List<Bitmap> finalImages = new List<Bitmap>();

      // Process small images (2x2 pattern)
      for (int row = 0; row < rows - largeImageRows; row += smallImageSize)
      {
        for (int col = 0; col < columns; col += smallImageSize)
        {
          Bitmap smallImage = new Bitmap(smallImageSize * CellSize, smallImageSize * CellSize);

          using (Graphics g = Graphics.FromImage(smallImage))
          {
            g.DrawImage(grid[col, row].Image, new Rectangle(0, 0, CellSize, CellSize));
            g.DrawImage(grid[col + 1, row].Image, new Rectangle(CellSize, 0, CellSize, CellSize));
            g.DrawImage(grid[col, row + 1].Image, new Rectangle(0, CellSize, CellSize, CellSize));
            g.DrawImage(grid[col + 1, row + 1].Image, new Rectangle(CellSize, CellSize, CellSize, CellSize));
          }

          finalImages.Add(smallImage);
        }
      }

      // Process large images (4x4 pattern)
      for (int row = rows - largeImageRows; row < rows; row += largeImageRows)
      {
        for (int col = 0; col < columns; col += largeImageColumns)
        {
          Bitmap largeImage = new Bitmap(largeImageColumns * CellSize, largeImageRows * CellSize);

          using (Graphics g = Graphics.FromImage(largeImage))
          {
            for (int y = 0; y < largeImageRows; y++)
            {
              for (int x = 0; x < largeImageColumns; x++)
              {
                g.DrawImage(grid[col + x, row + y].Image, new Rectangle(x * CellSize, y * CellSize, CellSize, CellSize));
              }
            }
          }

          finalImages.Add(largeImage);
        }
      }

      return finalImages;
    }


    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listView1.SelectedItems.Count > 0)
      {
        var item = listView1.SelectedItems[0];
        selectedTileIndex = item.ImageIndex;
      }
    }
  }
}
