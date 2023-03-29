using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
  public partial class HexForm : Form
  {
    private readonly byte[] _fileContents;
    private readonly string _filename;
    public HexForm(string filename, byte[] fileContents)
    {
      _filename = filename;
      _fileContents = fileContents;
      InitializeComponent();
    }

    private void HexForm_Load(object sender, EventArgs e)
    {
      PopulateForm();
    }

    private void PopulateForm()
    {
      
      int numRows = (int)Math.Ceiling(_fileContents.Length / 16.0);
      dataGridView1.Columns.Add("offsetCol", "Offset"); // Add an offset column
      for (int i = 0; i < 16; i++)
      {
        dataGridView1.Columns.Add($"col{i}", $"{i:X2}");
        dataGridView1.Columns[i].Width = 40;
      }
      dataGridView1.Columns.Add("asciiCol", "ASCII");
      for (int i = 0; i < numRows; i++)
      {
        byte[] block = _fileContents.Skip(i * 16).Take(16).ToArray();
        dataGridView1.Rows.Add();
        string asciiString = ""; // Initialize the ASCII string for the entire row
        for (int j = 0; j < 16; j++)
        {
          int index = i * 16 + j;
          if (index < _fileContents.Length)
          {
            dataGridView1.Rows[i].Cells[j+1].Value = $"{_fileContents[index]:X2}";
            char c = (char)_fileContents[index];
            if (c < 32 || c > 126)
            {
              c = '.';
            }
            asciiString += c; // Concatenate the ASCII value for each byte in the row
          }
        }
        dataGridView1.Rows[i].Cells[17].Value = asciiString;
        dataGridView1.Rows[i].Cells[0].Value = $"{i * 16:X8}";
      }
      dataGridView1.ReadOnly = true;
      dataGridView1.ColumnHeadersVisible = true;
      dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

      panel1.Dock = DockStyle.Left; // Set the Dock property of the Panel
      panel1.Controls.Add(dataGridView1); // Add the DataGridView control to the Panel
      panel1.Width = dataGridView1.Width + 20; // Set the width of the Panel

      this.Controls.Add(panel1);
      lblFilename.Text = $"Filename: {_filename}";
      lblFilename.Left = panel1.Right + 20;
      lblFileSize.Text = $"File size: {_fileContents.Length} bytes";
      lblFileSize.Left = panel1.Right + 20;
    }
  }
}
