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
    public MainDataForm()
    {
      InitializeComponent();
    }

    private void loadRTFBtn_Click(object sender, EventArgs e)
    {
      if (rtfForm != null)
      {
        rtfForm.Close();
        loadRTF();
      } else
      {
        loadRTF();
      }
    }

    private void loadRTF()
    {
      rtfForm = new RTFForm();
      rtfForm.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(rtfForm);
      rtfForm.Dock = DockStyle.Fill;
      rtfForm.Show();
    }
  }
}
