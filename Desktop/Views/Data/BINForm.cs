using Desktop.Helpers;
using Desktop.Views.Imagery;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Desktop.Helpers.AudioHelper;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.BackColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Desktop.Views
{
  public partial class BINForm : Form
  {
    private byte[] palette;
    private List<Color> colors;
    private List<byte[]> tiles;
    private bool isPaletteLoaded = false;
    private bool isBinLoaded = false;
    private MemoryStream memoryStream;

    public string filename;
    private byte[] binFileData;

    public BINForm()
    {
      InitializeComponent();
      //populateTileList.Enabled = false;
      //loadMapBtn.Enabled = false;
      dungeonTrackBar1.Enabled = false;
    }

    public void LoadCLUT()
    {
      openFileDialog1 = new OpenFileDialog()
      {
        FileName = "Select a CLUT file",
        Filter = "CLUT files (*.clut)|*.clut",
        Title = "Open CLUT file"
      };
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          filename = openFileDialog1.FileName;
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
            isPaletteLoaded = true;
            if (isBinLoaded)
            {
              //populateTileList.Enabled = true;
            }
          }
        }
        catch (Exception)
        {

          throw;
        }
      }
    }

    public void LoadBin()
    {
      openFileDialog1 = new OpenFileDialog()
      {
        FileName = "Select a BIN file",
        Filter = "BIN files (*.bin)|*.bin",
        Title = "Open BIN file"
      };
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        filename = openFileDialog1.FileName;
        this.Text = $"BIN File: {filename}";
        try
        {
          binFileData = File.ReadAllBytes(filename);
          var output = Utilities.Contains808FSequence(binFileData);
          if (binFileData.Length > 0)
          {
            isBinLoaded = true;
            if (isPaletteLoaded)
            {
              //populateTileList.Enabled = true;
              //loadMapBtn.Enabled = true;
            }
          }

          // UpdateStats();
        }
        catch (Exception)
        {

          throw;
        }
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

    private void CreateTileOutputGrid(List<Color> colors)
    {
      tileOutputPanel.Controls.Clear();
      int cellSize = 300 / 8; // Set the size of each grid cell
      int numCols = 8; // Set the number of rows in the grid
      int numRows = 8; // Set the number of columns in the grid

      Bitmap bitmap = new Bitmap(cellSize * numCols, cellSize * numRows);

      for (int i = 0; i < numRows; i++)
      {
        for (int j = 0; j < numCols; j++)
        {
          int index = i * numCols + j;
          Color color = colors[index];

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

      PictureBox pictureBox = new PictureBox();
      pictureBox.Size = bitmap.Size;
      pictureBox.Image = bitmap;
      tileOutputPanel.AutoSize = true;
      tileOutputPanel.Size = bitmap.Size;
      tileOutputPanel.Controls.Add(pictureBox);
    }

    public void PopulatePotentialTileListView()
    {
      tiles = BinFileHelper.ReadScreenTiles(binFileData);
      tiles.AddRange(BinFileHelper.ReadSpriteTiles(binFileData));
      foreach (var (tile, index) in tiles.WithIndex())
      {
        var item = new ListViewItem();
        item.Text = $"Tile {index}";
        potentialTileListView.Items.Add(item);
      }
      // tileEditorBtn.Enabled = true;
    }
    

    private void button1_Click(object sender, EventArgs e)
    {
      LoadBin();
    }

    private void clutButton_Click(object sender, EventArgs e)
    {
      LoadCLUT();
    }

    private void populateTileList_Click(object sender, EventArgs e)
    {
      PopulatePotentialTileListView();
    }

    private void tileSelected(object sender, EventArgs e)
    {
      var index = potentialTileListView.SelectedIndices[0];
      PopulateTileOutput(index);
    }

    private void PopulateTileOutput(int index)
    {
      var tileArray = tiles[index];
      var tileColors = new List<Color>();
      foreach (var item in tileArray)
      {
        var colorIndex = (int)item;
        tileColors.Add(colors[colorIndex]);
      }
      CreateTileOutputGrid(tileColors);
    }

    private void ExportTiles()
    {
      foreach (var (tile, index) in tiles.WithIndex())
      {
        var tileColors = new List<Color>();
        foreach (var item in tile)
        {
          var colorIndex = (int)item / 4;
          tileColors.Add(colors[colorIndex]);
        }
        var file = Path.GetFileNameWithoutExtension(filename);
        var path = Path.GetDirectoryName(filename) + "\\output\\" + file;
        var outputName = $"{file}_{index}.png";
        Directory.CreateDirectory(path);
        SaveTile(Path.Combine(path, outputName), tileColors);
      }
    }

    private void SaveTile(string outputPath, List<Color> colors)
    {
      if (colors.Count != 64)
      {
        throw new ArgumentException("The color list must contain exactly 64 colors.");
      }

      Bitmap image = new Bitmap(8, 8);

      for (int y = 0; y < 8; y++)
      {
        for (int x = 0; x < 8; x++)
        {
          int colorIndex = y * 8 + x;
          image.SetPixel(x, y, colors[colorIndex]);
        }
      }

      image.Save(outputPath, ImageFormat.Png);
    }

    private void exportTilesBtn_Click(object sender, EventArgs e)
    {
      var tileEditor = new TilePlaygroundForm(binFileData);
      tileEditor.Show();
    }

    private void parseBytesBtn_Click(object sender, EventArgs e)
    {
      var byteString = textBox1.Text;
      var bytes = Utilities.ParseHex(byteString);
      var tileColors = new List<Color>();
      foreach (var item in bytes)
      {
        var colorIndex = (int)item;
        tileColors.Add(colors[colorIndex]);
      }
      CreateTileOutputGrid(tileColors);
    }

    private void CreateMapScreen(byte[] mapBytes)
    {
      foreach (Form form in this.MdiChildren)
      {
        if (form is MapScreenForm mapScreenForm)
        {
          mapScreenForm.SetMapData(mapBytes);
          mapScreenForm.Activate();
          return;
        }
      }
      MapScreenForm msForm = new MapScreenForm(mapBytes, tiles, colors);
      msForm.MdiParent = this;
      msForm.TopMost = true;
      msForm.Show();
    }

    private void loadMapBtn_Click(object sender, EventArgs e)
    {
      if (binFileData.Length > 0)
      {
        var mapData = BinFileHelper.ReadMapBytes(binFileData);
        CreateMapScreen(mapData);
      }
    }

    private void loadDYUVbtn_Click(object sender, EventArgs e)
    {
      var bytes = GetDyuvBytes();
      //var pil = DyuvHelper.ToPIL(bytes, 384, 240);
      //var bitmap = DyuvHelper.ImageSharpToBitmap(pil);
      var bitmap = new Bitmap(384, 240);
      if (bytes.Length / 384 != 240)
      {
        bitmap = Utilities.DecodeDYUVImage(bytes, 384, bytes.Length / 384);
      }
      else
      {
        bitmap = Utilities.DecodeDYUVImage(bytes);
      }
      pictureBox1.Size = new Size(1536, 960);
      pictureBox1.Image = BitmapHelper.Scale4(bitmap);
      pictureBox1.Visible = true;
    }

    private byte[] GetDyuvBytes()
    {
      var bytesToRead = 92160;
      if (binFileData.Length == bytesToRead)
      {
        return binFileData;
      }
      else
      {
        var (offset, toRead) = PromptForHexOffset();
        return binFileData.Skip(offset).Take(toRead).ToArray();
      }

    }

    private (int, int) PromptForHexOffset()
    {
      using (var dialog = new Form())
      {
        dialog.Text = "Enter Hex Offset and bytes to read";

        var label = new Label();
        label.Text = "Enter a hexadecimal offset:";
        label.Location = new Point(10, 10);
        label.AutoSize = true;
        dialog.Controls.Add(label);

        var numericUpDown = new NumericUpDown();
        numericUpDown.Hexadecimal = true;
        numericUpDown.Location = new Point(10, 40);
        numericUpDown.Maximum = decimal.MaxValue;
        dialog.Controls.Add(numericUpDown);

        var label2 = new Label();
        label2.Text = "Enter the bytes to read:";
        label2.Location = new Point(10, 80);
        label2.AutoSize = true;
        dialog.Controls.Add(label2);

        var numericUpDown2 = new NumericUpDown();
        numericUpDown2.Location = new Point(10, 110);
        numericUpDown2.Maximum = 92160;
        numericUpDown2.Value = 92160;
        dialog.Controls.Add(numericUpDown2);

        var okButton = new Button();
        okButton.Text = "OK";
        okButton.DialogResult = DialogResult.OK;
        okButton.Location = new Point(50, 140);
        dialog.Controls.Add(okButton);

        var cancelButton = new Button();
        cancelButton.Text = "Cancel";
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(110, 170);
        dialog.Controls.Add(cancelButton);

        dialog.AcceptButton = okButton;
        dialog.CancelButton = cancelButton;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          return ((int)numericUpDown.Value, (int)numericUpDown2.Value);
        }
        else
        {
          return (0, 92160);
        }
      }
    }

  }
}
