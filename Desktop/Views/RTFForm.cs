using Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Desktop.Helpers;

namespace Desktop.Views
{
  public partial class RTFForm : Form
  {
    private string? filename { get; set; }
    private byte[]? fileData { get; set; }
    private List<SectorInfo>? fileSectors { get; set; }
    private List<string>? filenames { get; set; }
    public RTFForm()
    {
      InitializeComponent();
      openFileDialog1 = new OpenFileDialog()
      {
        FileName = "Select an RTF file",
        Filter = "RTF files (*.rtf)|*.rtf",
        Title = "Open RTF file"
      };
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        this.Text = filename = openFileDialog1.FileName;
        try
        {
          fileData = File.ReadAllBytes(filename);
          fileSectors = CdiFileHelper.ProcessRTFFileDataSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileAudioSectors3(fileData, filename);
          UpdateStats();
        }
        catch (Exception)
        {

          throw;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        MessageBox.Show($"{folderBrowserDialog1.SelectedPath}");
      }
    }

    private void hexButton_Click(object sender, EventArgs e)
    {
      if (fileData != null && !string.IsNullOrEmpty(filename))
      {
        HexForm hexEditorForm = new HexForm(filename, fileData);
        hexEditorForm.Show();
      } else
      {
        MessageBox.Show("Couldn't load file data");
      }
    }

    private void UpdateStats()
    {
      var totalSectors = fileSectors?.Count;
      lblTotalSectors.Text = $"{lblTotalSectors.Text} {totalSectors}";
      var totalRecords = fileSectors?.Where((fs) => fs.IsEOR).Count();
      lblTotalRecords.Text = $"{lblTotalRecords.Text} {totalRecords}";
      var videoSectorCount = fileSectors?.Where((fs) => fs.IsVideo).Count();
      lblVideoSectors.Text = $"{lblVideoSectors.Text} {videoSectorCount}";
      var audioSectorCount = fileSectors?.Where((fs) => fs.IsAudio).Count();
      lblAudioSectors.Text = $"{lblAudioSectors.Text} {audioSectorCount}";
      var dataSectorCount = fileSectors?.Where((fs) => fs.IsData).Count();
      lblDataSectors.Text = $"{lblDataSectors.Text} {dataSectorCount}";
    }

    private void PopulateBinFiles()
    {
      var dirPath = Path.GetDirectoryName(filename);
      if (!string.IsNullOrEmpty(dirPath))
      {
        filenames = Directory.GetFiles(dirPath, "*.bin").ToList();
      }
    }
  }
}
