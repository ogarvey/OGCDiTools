using Desktop.Views;
using Desktop.Views.Audio;
using Desktop.Views.Data;

namespace Desktop
{
  public partial class MainWindow : Form
  {
    private MainDataForm mainDataForm;
    private AudioPlayerForm audioToolsForm;
    public MainWindow()
    {
      InitializeComponent();
      this.Size = Screen.PrimaryScreen.WorkingArea.Size;
      this.Location = Screen.PrimaryScreen.WorkingArea.Location;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      BINForm bin = new BINForm();
      bin.Show();
    }

    private void spaceButton1_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadMainDataForm();
    }

    private void CheckOpenForms()
    {
      if (mainDataForm != null)
        mainDataForm.Close();

      if (audioToolsForm != null)
        audioToolsForm.Close();
    }

    private void loadMainDataForm()
    {
      mainDataForm = new MainDataForm();
      mainDataForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(mainDataForm);
      mainDataForm.Dock = DockStyle.Fill;
      mainDataForm.Show();
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void audioToolsBtn_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadAudioForm();
    }

    private void loadAudioForm()
    {
      audioToolsForm = new AudioPlayerForm();
      audioToolsForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(audioToolsForm);
      audioToolsForm.Dock = DockStyle.Fill;
      audioToolsForm.Show();
    }
  }
}