using Desktop.Views;
using Desktop.Views.Audio;
using Desktop.Views.Data;
using Desktop.Views.Imagery;

namespace Desktop
{
  public partial class MainWindow : Form
  {
    private MainDataForm mainDataForm;
    private AudioPlayerForm audioToolsForm;
    private ImageToolsForm imageToolsForm;
    public MainWindow()
    {
      InitializeComponent();
      this.Size = Screen.PrimaryScreen.WorkingArea.Size;
      this.Location = Screen.PrimaryScreen.WorkingArea.Location;
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

      if (imageToolsForm != null)
        imageToolsForm.Close();
    }

    private void loadMainDataForm()
    {
      mainDataForm = new MainDataForm();
      mainDataForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(mainDataForm);
      mainDataForm.Dock = DockStyle.Fill;
      mainDataForm.Show();
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

    private void imageToolsBtn_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadImageForm();
    }

    private void loadImageForm()
    {
      imageToolsForm = new ImageToolsForm();
      imageToolsForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(imageToolsForm);
      imageToolsForm.Dock = DockStyle.Fill;
      imageToolsForm.Show();
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}