using Desktop.Helpers;
using Desktop.Helpers.Imagery;
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
using static Desktop.Helpers.Imagery.SpriteHelper;
using Color = System.Drawing.Color;

namespace Desktop.Views.Imagery
{
  public partial class ImageToolsForm : Form
  {
    private string filename;
    private byte[] binFileData;
    private bool isBinLoaded;
    private List<Color> colors;

    private DYUVForm dyuvForm;
    private TilePlaygroundForm tilePlaygroundForm;

    public ImageToolsForm()
    {
      InitializeComponent();
      colors = new List<Color>();
      colors.Add(Color.FromArgb(255, 0x98, 0x98, 0x98));
      colors.Add(Color.FromArgb(255, 0x00, 0x64, 0x2C));
      colors.Add(Color.FromArgb(255, 0x10, 0x44, 0x00));
      colors.Add(Color.FromArgb(255, 0xFC, 0x04, 0x04));
      colors.Add(Color.FromArgb(255, 0x00, 0xA4, 0x4C));
      colors.Add(Color.FromArgb(255, 0xFC, 0xCC, 0xA4));
      colors.Add(Color.FromArgb(255, 0xE4, 0x90, 0x5C));
      colors.Add(Color.FromArgb(255, 0xC4, 0x64, 0x38));
      colors.Add(Color.FromArgb(255, 0x8C, 0x50, 0x30));
      colors.Add(Color.FromArgb(255, 0x60, 0x44, 0x34));
      colors.Add(Color.FromArgb(255, 0x94, 0xF4, 0xAC));
      colors.Add(Color.FromArgb(255, 0xFC, 0xF0, 0x88));
      colors.Add(Color.FromArgb(255, 0xB0, 0x98, 0x74));
      colors.Add(Color.FromArgb(255, 0x58, 0x50, 0x00));
      colors.Add(Color.FromArgb(255, 0x10, 0x10, 0x10));
      colors.Add(Color.FromArgb(255, 0xFC, 0xFC, 0xFC));
    }

    private void loadImageBtn_Click(object sender, EventArgs e)
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
          if (binFileData.Length > 0 && BinFileHelper.IsMainDataFile(filename))
          {
            List<List<ImageLine>> imagesAsLines = new List<List<ImageLine>>();
            List<Bitmap> bitmaps = new List<Bitmap>();
            var blobs = GetSpriteBlobs(binFileData.Skip(67848).Take(56574).ToArray());
            foreach (var (item,index) in blobs.WithIndex())
            {
              var outputDir = Path.GetDirectoryName(filename) + "\\output";
              var binOutputDir = Path.GetDirectoryName(filename) + "\\output\\bins";
              Directory.CreateDirectory(outputDir);
              Directory.CreateDirectory(binOutputDir);
              var spriteBinFile = Path.Combine(binOutputDir, Path.GetFileNameWithoutExtension(filename) + $"_{index}.bin");
              File.WriteAllBytes(spriteBinFile, item);
              var imageLines = DecodeImage(item);
              imagesAsLines.Add(imageLines);
              var bitmap = CreateBitmapFromImageLines(imageLines, colors);
              bitmap.Save(Path.Combine(outputDir, Path.GetFileNameWithoutExtension(filename) + $"_{index}.png"));
            }
            isBinLoaded = true;
            parseDyuvBtn.Enabled = true;
            screenImageBtn.Enabled = true;
          }
        }
        catch (Exception)
        {

          throw;
        }
      }
    }

    private void parseDyuvBtn_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadDyuvForm();
    }

    private void CheckOpenForms()
    {
      if (dyuvForm != null)
        dyuvForm.Close();

      if (tilePlaygroundForm != null)
        tilePlaygroundForm.Close();
    }

    private void loadDyuvForm()
    {
      dyuvForm = new DYUVForm(binFileData);
      dyuvForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(dyuvForm);
      dyuvForm.Dock = DockStyle.Fill;
      dyuvForm.Show();
    }

    private void tilePlaygroundBtn_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadTilePlaygroundForm();
    }

    private void loadTilePlaygroundForm()
    {
      tilePlaygroundForm = new TilePlaygroundForm(binFileData);
      tilePlaygroundForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(tilePlaygroundForm);
      tilePlaygroundForm.Dock = DockStyle.Fill;
      tilePlaygroundForm.Show();
    }
  }
}
