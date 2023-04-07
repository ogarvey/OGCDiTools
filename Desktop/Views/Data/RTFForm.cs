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
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        this.Text = filename = openFileDialog1.FileName;
        spaceForm1.Text = $"RTF Tools - {filename}";
        try
        {
          fileData = File.ReadAllBytes(filename);
          fileSectors = CdiFileHelper.ProcessRTFFileDataSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileStereoAudioSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileMonoAudioSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileVideoSectors(fileData, filename);
          UpdateStats();
        }
        catch (Exception)
        {

          throw;
        }
      }
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
          CdiFileHelper.ProcessRTFFileStereoAudioSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileMonoAudioSectors(fileData, filename);
          CdiFileHelper.ProcessRTFFileVideoSectors(fileData, filename);
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
        FormHelper.hexButton_Click(fileData, filename);
      }
    }

    private void UpdateStats()
    {
      var totalSectors = fileSectors?.Count;
      var totalRecords = fileSectors?.Where((fs) => fs.IsEOR).Count();
      var videoSectorCount = fileSectors?.Where((fs) => fs.IsVideo).Count();
      var monoAudioSectorCount = fileSectors?.Where((fs) => fs.IsAudio && fs.IsMono).Count();
      var stereoAudioSectorCount = fileSectors?.Where((fs) => fs.IsAudio && !fs.IsMono).Count();
      var dataSectorCount = fileSectors?.Where((fs) => fs.IsData).Count();
      totalSectorsLabel.Text = totalSectors?.ToString("N0");
      totalRecordsLabel.Text = totalRecords?.ToString("N0");
      totalVideoLabel.Text = videoSectorCount?.ToString("N0");
      totalMonoLabel.Text = monoAudioSectorCount?.ToString("N0");
      totalStereoLabel.Text = stereoAudioSectorCount?.ToString("N0");
      totalDataLabel.Text = dataSectorCount?.ToString("N0");
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
