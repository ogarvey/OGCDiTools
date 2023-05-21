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
      folderBrowserDialog1 = new FolderBrowserDialog()
      {
        UseDescriptionForTitle = true,
        Description = "Select RTF Folder"
      };
      if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        filename = folderBrowserDialog1.SelectedPath;
        filenames = Directory.GetFiles(filename, "*.*").ToList();
        foreach(string file in filenames)
        {
          try
          {
            fileData = File.ReadAllBytes(file);
            fileSectors = CdiFileHelper.ProcessRTFFileDataSectors(fileData, file);
            CdiFileHelper.ProcessRTFFileStereoAudioSectors(fileData, file);
            CdiFileHelper.ProcessRTFFileMonoAudioSectors(fileData, file);
            CdiFileHelper.ProcessRTFFileVideoSectors(fileData, file);
            UpdateStats();
            MessageBox.Show($"Processed: {file}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          catch (Exception)
          {

            throw;
          }
        }
      }
      //openFileDialog1 = new OpenFileDialog()
      //{
      //  FileName = "Select an RTF file",
      //  Filter = "RTF files (*.rtf)|*.rtf",
      //  Title = "Open RTF file"
      //};
      //if (openFileDialog1.ShowDialog() == DialogResult.OK)
      //{
      //  this.Text = filename = openFileDialog1.FileName;
      //  spaceForm1.Text = $"RTF Tools - {filename}";
      //  try
      //  {
      //    fileData = File.ReadAllBytes(filename);
      //    fileSectors = CdiFileHelper.ProcessRTFFileDataSectors(fileData, filename);
      //    CdiFileHelper.ProcessRTFFileStereoAudioSectors(fileData, filename);
      //    CdiFileHelper.ProcessRTFFileMonoAudioSectors(fileData, filename);
      //    CdiFileHelper.ProcessRTFFileVideoSectors(fileData, filename);
      //    UpdateStats();
      //  }
      //  catch (Exception)
      //  {

      //    throw;
      //  }
      //}
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
  }
}
