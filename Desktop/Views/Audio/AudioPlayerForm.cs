using Desktop.Helpers;
using NAudio.Wave;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Desktop.Helpers.AudioHelper;

namespace Desktop.Views.Audio
{
  public partial class AudioPlayerForm : Form
  {
    private string filename;
    private byte[] binFileData;
    private bool isBinLoaded;
    private bool isMono = false;

    public AudioPlayerForm()
    {
      InitializeComponent();
      if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
      {
        waveOut.Stop();
        trackBar1.Enabled = false;
      }
    }

    private void loadAudioFileBtn_Click(object sender, EventArgs e)
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
            playMonoBtn.Enabled = true;
          }
        }
        catch (Exception)
        {

          throw;
        }
      }
    }

    private void playMonoBtn_Click(object sender, EventArgs e)
    {
      List<short> left = new List<short>();
      List<short> right = new List<short>();

      for (int i = 0; i < binFileData.Length; i += 2304)
      {
        byte[] chunk = new byte[2304];
        Array.Copy(binFileData, i, chunk, 0, 2304);
        ProcessAudioData(chunk, left, right);
      }

      WAVHeader header = new WAVHeader
      {
        ChannelNumber = (ushort)(isMono ? 1 : 2), // Mono
        Frequency = frequency, // 18.9 kHz
      };

      PreviewWAV(header, left, right);
    }

    private void ProcessAudioData(byte[] data, List<short> left, List<short> right)
    {
      // Call DecodeAudioSector here with the data parameter, left, and right
      // ...
      DecodeAudioSector(data, left, right, bps == 8, !isMono);
    }

    private WaveOut waveOut;
    private WaveFileReader waveFileReader;
    private MemoryStream memoryStream;
    private uint frequency;
    private int bps;

    private void PreviewWAV(WAVHeader header, List<short> left, List<short> right)
    {
      if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
      {
        waveOut.Stop();
        trackBar1.Enabled = false;
        return;
      }
      else if (waveOut != null && waveOut.PlaybackState == PlaybackState.Paused)
      {
        waveOut.Play();
        trackBar1.Enabled = true;
        return;
      }

      memoryStream = new MemoryStream();
      AudioHelper.WriteWAV(memoryStream, header, left, right);

      memoryStream.Position = 0;
      waveFileReader = new WaveFileReader(memoryStream);

      waveOut = new WaveOut();
      waveOut.Init(waveFileReader);
      trackBar1.Maximum = (int)waveFileReader.TotalTime.TotalSeconds;
      waveOut.Play();
      trackBar1.Value = (int)waveFileReader.CurrentTime.TotalSeconds;
      trackBar1.Enabled = true;

    }

    private void stopAudioBtn_Click(object sender, EventArgs e)
    {
      if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
      {
        waveOut.Stop();
        trackBar1.Enabled = false;
      }
    }

    private void trackBar1_ValueChanged()
    {
      if (waveFileReader != null)
      {
        // Seek the audio file to the new position based on the TrackBar value
        waveFileReader.CurrentTime = TimeSpan.FromSeconds(trackBar1.Value);
      }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      //if (waveFileReader != null && waveOut.PlaybackState == PlaybackState.Playing)
      //{
      //  // Update the TrackBar value based on the current position of the playing audio
      //  trackBar1.Value = (int)waveFileReader.CurrentTime.TotalSeconds;
      //}
    }

    private void lowFreqRadio_CheckedChanged(object sender, EventArgs e)
    {
      frequency = 18900;
    }

    private void highFreqRadio_CheckedChanged(object sender, EventArgs e)
    {
      frequency = 37800;
    }

    private void isMonoStereoChkbox_CheckedChanged(object sender, EventArgs e)
    {
      isMono = !isMonoStereoChkbox.Checked;
    }

    private void fourBpsRadio_CheckedChanged(object sender, EventArgs e)
    {
      bps = 4;
    }

    private void eightBitsRadio_CheckedChanged(object sender, EventArgs e)
    {
      bps = 8;
    }
  }
}
