using Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace Desktop.Views
{
  public partial class StreamingDyuvForm : Form
  {
    private BackgroundWorker worker = new BackgroundWorker();
    private readonly string _binFilePath;
    public StreamingDyuvForm(string binFilePath)
    {
      InitializeComponent();
      pictureBox1.Visible = false;

      _binFilePath = binFilePath;
      this.Text = $"Bin File: {_binFilePath}";
      worker.WorkerReportsProgress = true;
      worker.DoWork += Worker_DoWork;
      worker.ProgressChanged += Worker_ProgressChanged;
    }

    private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (e.UserState is ImageDataContainer container)
      {
        UpdateOffset(container.Position);
        DisplayImage(container.imageSharp);
      }
    }

    private void DisplayImage(Image<Rgb24> imageSharp)
    {
      var bitmap = DyuvHelper.ImageSharpToBitmap(imageSharp);
      pictureBox1.Size = new Size(1536, 960);
      pictureBox1.Image = BitmapHelper.Scale4(bitmap);
      pictureBox1.Visible = true;
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
      string filePath = _binFilePath;
      int width = 384;
      int height = 240;

      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
      {
        byte[] imageData = new byte[width * height];
        while (fileStream.Position < fileStream.Length)
        {
          int readBytes = fileStream.Read(imageData, 0, width * height);

          // Create a DYUVImage instance and initialize it with the imageData
          // Then convert it to Image<Rgb24> using the ToPIL() method.
          // Replace the following line with your actual implementation.
          try
          {
            Image<Rgb24> imageSharp = DyuvHelper.ToPIL(imageData, width, height);
            worker.ReportProgress(0, new ImageDataContainer() { imageSharp = imageSharp, Position = fileStream.Position});
            fileStream.Position++;
          }
          catch (Exception ex)
          {
            fileStream.Position++;
            continue;
          }
        }
      }
    }

    private void UpdateOffset(long offset)
    {
      this.Text += "_" + offset;
    }
    
    private void streamFileBtn_Click(object sender, EventArgs e)
    {
      worker.RunWorkerAsync();
    }
  }
  
  class ImageDataContainer
  {
    public Image<Rgb24> imageSharp { get; set; }

    public long Position { get; set; }
  }
}
