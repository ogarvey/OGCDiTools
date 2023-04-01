using Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace Desktop.Views.Imagery
{
  public partial class TileEditorForm : Form
  {
    private byte[] _binFileData;
    private List<byte[]> _screenTiles;
    private List<byte[]> _spriteTiles;

    public TileEditorForm(byte[] binFileData)
    {
      _binFileData = binFileData;
      _screenTiles = BinFileHelper.ReadScreenTiles(binFileData);
      _spriteTiles = BinFileHelper.ReadSpriteTiles(binFileData);
      InitializeComponent();
    }

    private void PopulateMaterialListView()
    {
      // Create an ImageList and set the ImageSize to 64x64 pixels
      ImageList imageList = new ImageList
      {
        ImageSize = new Size(64, 64)
      };

      // Add images to the ImageList
      imageList.Images.Add("Image1", Image.FromFile("path/to/your/image1.png"));
      imageList.Images.Add("Image2", Image.FromFile("path/to/your/image2.png"));

      // Assign the ImageList to the MaterialListView's LargeImageList property
      screenTileListView.LargeImageList = imageList;

      // Add items to the MaterialListView
      ListViewItem item1 = new ListViewItem("Label1")
      {
        ImageKey = "Image1"
      };
      screenTileListView.Items.Add(item1);

      ListViewItem item2 = new ListViewItem("Label2")
      {
        ImageKey = "Image2"
      };
      screenTileListView.Items.Add(item2);
    }
  }
}
