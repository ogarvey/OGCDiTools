using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views.Data
{
  public partial class MainDataForm : Form
  {
    private RTFForm rtfForm;
    public BINForm binForm;
    public MainDataForm()
    {
      InitializeComponent();
    }

    private void loadRTFBtn_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadRTF();
    }

    private void loadRTF()
    {
      rtfForm = new RTFForm();
      rtfForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(rtfForm);
      rtfForm.Dock = DockStyle.Fill;
      rtfForm.Show();
    }

    private void loadBinForm_Click(object sender, EventArgs e)
    {
      CheckOpenForms();
      loadBIN();
    }

    private void loadBIN()
    {
      binForm = new BINForm();
      binForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(binForm);
      binForm.Dock = DockStyle.Fill;
      binForm.Show();
    }

    private void CheckOpenForms()
    {
      if (rtfForm != null)
        rtfForm.Close();

      if (binForm != null)
        binForm.Close();
    }
  }
}
