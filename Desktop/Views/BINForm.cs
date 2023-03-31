using Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    public string filename;
    private byte[] binFileData;

    public BINForm()
    {
      InitializeComponent();
      exportTilesBtn.Enabled = false;
      populateTileList.Enabled = false;
      loadMapBtn.Enabled = false;
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
              populateTileList.Enabled = true;
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
          if (binFileData.Length > 0)
          {
            isBinLoaded = true;
            if (isPaletteLoaded)
            {
              populateTileList.Enabled = true;
              loadMapBtn.Enabled = true;
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
      int numRows = 8; // Set the number of rows in the grid
      int numCols = 8; // Set the number of columns in the grid

      for (int i = 0; i < numRows; i++)
      {
        for (int j = 0; j < numCols; j++)
        {
          int index = i * numCols + j;
          Color color = colors[index];

          PictureBox pictureBox = new PictureBox();
          pictureBox.Location = new Point(j * (cellSize), i * (cellSize));
          pictureBox.Size = new Size(cellSize, cellSize);
          pictureBox.BackColor = color;
          tileOutputPanel.Controls.Add(pictureBox);
        }
      }

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
      exportTilesBtn.Enabled = true;
    }


    public void LoadBinFolder()
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {

      }
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
      ExportTiles();
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
      var bitmap = Utilities.DecodeDYUVImage(bytes);
      pictureBox1.Size = new Size(1536, 960);
      pictureBox1.Image = BitmapHelper.Scale4(bitmap);
      pictureBox1.Visible = true;
    }

    private byte[] GetDyuvBytes()
    {
      var bytesToRead = 92160;
      if(binFileData.Length == bytesToRead)
      {
        return binFileData;
      } else
      {
        var offset = PromptForHexOffset();
        return binFileData.Skip(offset).Take(bytesToRead).ToArray();
      }

    }
    private int PromptForHexOffset()
    {
      using (var dialog = new Form())
      {
        dialog.Text = "Enter Hex Offset";

        var label = new Label();
        label.Text = "Enter a hexadecimal offset:";
        label.Location = new Point(10, 10);
        dialog.Controls.Add(label);

        var numericUpDown = new NumericUpDown();
        numericUpDown.Hexadecimal = true;
        numericUpDown.Location = new Point(10, 40);
        numericUpDown.Maximum = decimal.MaxValue;
        dialog.Controls.Add(numericUpDown);

        var okButton = new Button();
        okButton.Text = "OK";
        okButton.DialogResult = DialogResult.OK;
        okButton.Location = new Point(10, 70);
        dialog.Controls.Add(okButton);

        var cancelButton = new Button();
        cancelButton.Text = "Cancel";
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(90, 70);
        dialog.Controls.Add(cancelButton);

        dialog.AcceptButton = okButton;
        dialog.CancelButton = cancelButton;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
          return (int)numericUpDown.Value;
        }
        else
        {
          return 0;
        }
      }
    }


    private void streamDyuvBtn_Click(object sender, EventArgs e)
    {
      var sdForm = new StreamingDyuvForm(filename);
      sdForm.Show();
    }
  }
}
