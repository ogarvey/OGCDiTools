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
    public MainDataForm()
    {
      InitializeComponent();
    }

    private void loadRTFBtn_Click(object sender, EventArgs e)
    {
      var form = new RTFForm();
      form.TopLevel = false;
      splitContainer1.Panel2.Controls.Add(form);
      form.Dock = DockStyle.Fill;
      form.Show();
    }
  }
}
