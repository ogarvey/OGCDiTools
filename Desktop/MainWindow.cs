using Desktop.Views;

namespace Desktop
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
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
  }
}