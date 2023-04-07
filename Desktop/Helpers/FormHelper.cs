using Desktop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Helpers
{
  public static class FormHelper
  {
    public static void hexButton_Click(byte[] fileData, string filename)
    {
      if (fileData != null && !string.IsNullOrEmpty(filename))
      {
        HexForm hexEditorForm = new HexForm(filename, fileData);
        hexEditorForm.Show();
      }
      else
      {
        MessageBox.Show("Couldn't load file data");
      }
    }
  }
}
