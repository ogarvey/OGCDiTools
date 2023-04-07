using Desktop.Views;
using Desktop.Views.Data;

namespace Desktop
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
      this.Size = Screen.PrimaryScreen.WorkingArea.Size;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      RTFForm rtf = new RTFForm();
      rtf.Show();
      //string filename = @"C:\Dev\Projects\Gaming\CD-i\LLExtractRaw\Laser Lords\records\anime_2.bin"; // Replace with your actual filename

    }

    private void button2_Click(object sender, EventArgs e)
    {
      BINForm bin = new BINForm();
      bin.Show();
    }

    private void spaceButton1_Click(object sender, EventArgs e)
    {
      var mainDataForm = new MainDataForm();
      mainDataForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(mainDataForm);
      mainDataForm.Dock = DockStyle.Fill;
      mainDataForm.Show();
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}