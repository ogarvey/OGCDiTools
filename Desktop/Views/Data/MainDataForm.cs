using Desktop.Helpers;
using Desktop.Helpers.Imagery;
using Desktop.Interfaces;
using Desktop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Desktop.Views.Data
{
  public partial class MainDataForm : Form
  {
    private RTFForm rtfForm;
    public BINForm binForm;
    private readonly IDataFileRepository _repo;
    private Dictionary<long, List<DataFile>> _dataFilesByPlanet = new Dictionary<long, List<DataFile>>();
    private readonly int dyuvBytesToRead = 92160;
    private bool _playerSpritesSaved = false;

    public MainDataForm(IDataFileRepository repo)
    {
      _repo = repo;
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
      // binForm.TopLevel = false;
      //splitContainer1.Panel2.Controls.Add(binForm);
      //binForm.Dock = DockStyle.Fill;
      binForm.Show();
    }

    private void CheckOpenForms()
    {
      if (rtfForm != null)
        rtfForm.Close();

      if (binForm != null)
        binForm.Close();
    }

    private void extractUsingDbBtn_Click(object sender, EventArgs e)
    {
      _dataFilesByPlanet = new Dictionary<long, List<DataFile>>();
      var dyuvBitmap = new Bitmap(384, 240);
      var dyuvBitmap4x = new Bitmap(384 * 4, 240 * 4);
      string path = "";
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        path = folderBrowserDialog1.SelectedPath;
        Directory.GetFiles(path, "*.rtf").ToList().ForEach(rtf =>
        {
          var bytes = File.ReadAllBytes(rtf);
          CdiFileHelper.ProcessRTFFileDataSectors(bytes, rtf);
          CdiFileHelper.ProcessRTFFileMonoAudioSectors(bytes, rtf);
          CdiFileHelper.ProcessRTFFileStereoAudioSectors(bytes, rtf);
          CdiFileHelper.ProcessRTFFileVideoSectors(bytes, rtf);
        });
      }
      var planets = _repo.GetPlanets();
      foreach (var planet in planets)
      {
        _dataFilesByPlanet.Add(planet.Id, _repo.GetDataFilesByPlanetId(planet.Id).ToList());
      }
      foreach (var item in _dataFilesByPlanet)
      {
        var planetName = planets.Where(p => p.Id == item.Key).FirstOrDefault().Name.ToLower();
        var inputFilePath = Path.Combine(path, $"records\\{planetName}\\data");
        Directory.CreateDirectory(inputFilePath);
        var outputPath = Path.Combine(inputFilePath, "output");
        Directory.CreateDirectory(outputPath);
        var spritePath = Path.Combine(outputPath, "sprites");
        Directory.CreateDirectory(spritePath);
        var sprite4xPath = Path.Combine(outputPath, "sprites4x");
        Directory.CreateDirectory(sprite4xPath);
        var dyuvPath = Path.Combine(outputPath, "DYUV");
        Directory.CreateDirectory(dyuvPath);
        var dyuv4xPath = Path.Combine(outputPath, "DYUV4x");
        Directory.CreateDirectory(dyuv4xPath);
        var screenPath = Path.Combine(outputPath, "screens");
        Directory.CreateDirectory(screenPath);
        var screen4xPath = Path.Combine(outputPath, "screens4x");
        Directory.CreateDirectory(screen4xPath);
        var playerSpriteOutputPath = Path.Combine(path, "records\\player");
        Directory.CreateDirectory(playerSpriteOutputPath);
        var playerSprite4xOutputPath = Path.Combine(path, "records\\player4x");
        Directory.CreateDirectory(playerSprite4xOutputPath);
        var files = item.Value;

        var mainDataFile = BinFileHelper.GetMainDataFile(inputFilePath);
        // load planet bin
        var mainDataBytes = File.ReadAllBytes(mainDataFile);
        var tiles = BinFileHelper.ReadScreenTiles(mainDataBytes);
        var invTiles = BinFileHelper.ReadSpriteTiles(mainDataBytes);

        if (!_playerSpritesSaved)
        {
          var playerPaletteOffset = 0x10800;
          var playerColors = ExtractPalette(mainDataBytes, playerPaletteOffset);
          var playerSpriteOffsets = Utilities.ConvertPlayerByteSequenceToIntList(mainDataBytes.Skip(0x10842).Take(156).ToArray());
          var playerSprites = new List<byte[]>();
          var playerSpriteBytes = mainDataBytes.Skip(0x10900).Take(playerSpriteOffsets.Last()).ToArray();
          foreach (var (offset, index) in playerSpriteOffsets.WithIndex())
          {
            if (playerSprites.Count > 0)
            {
              playerSprites.Add(playerSpriteBytes.Skip(playerSpriteOffsets[index - 1]).Take(playerSpriteOffsets[index] - playerSpriteOffsets[index - 1]).ToArray());
            }
            else
            {
              playerSprites.Add(playerSpriteBytes.Take(playerSpriteOffsets[0]).ToArray());
            }
          }
          foreach (var (sprite, index) in playerSprites.WithIndex())
          {
            var imageLines = SpriteHelper.DecodeImage(sprite);
            var bitmap = SpriteHelper.CreateBitmapFromImageLines(imageLines, playerColors, true);
            if (bitmap != null)
            {
              var bitmapScaled = BitmapHelper.Scale4(bitmap);
              bitmap.Save(Path.Combine(playerSpriteOutputPath, $"_{index}.png"));
              bitmapScaled.Save(Path.Combine(playerSprite4xOutputPath, $"_{index}_upscaled.png"));
            }
          }
          _playerSpritesSaved = true;
        }

        foreach (var file in files)
        {
          var filePath = Path.Combine(inputFilePath, file.Name);
          var fileBytes = File.ReadAllBytes(filePath);

          if (file.HasDyuv == 1)
          {
            var dyuvBytes = fileBytes.Skip((int)file.DyuvOffset).Take(dyuvBytesToRead).ToArray();
            var outputFileName = BinFileHelper.GetBinFileNumber(file.Name) + ".png";
            dyuvBitmap = Utilities.DecodeDYUVImage(dyuvBytes, 384, 240);
            dyuvBitmap4x = BitmapHelper.Scale4(dyuvBitmap);
            dyuvBitmap.Save(Path.Combine(dyuvPath, outputFileName));
            dyuvBitmap4x.Save(Path.Combine(dyuv4xPath, outputFileName));
          }// if (file.HasText == 1)
          // extract text

          // load planet clut and populate colors
          var clutFile = Path.Combine(inputFilePath + "\\cluts", $"{planetName}_5.clut");
          var palette = File.ReadAllBytes(clutFile);
          var length = (int)palette.Length;
          var tileColors = new List<Color>();
          var count = 1;
          for (int i = 0; i < length; i += 4)
          {
            var r = palette[i + 1];
            var g = palette[i + 2];
            var b = palette[i + 3];
            var color = Color.FromArgb(255, r, g, b);
            tileColors.Add(color);
            count++;
          }
          if (tileColors.Count < 256)
          {
            var remaining = 256 - tileColors.Count;
            for (int i = 0; i < remaining; i++)
            {
              tileColors.Add(Color.FromArgb(255, 0, 0, 0));
            }
          }

          if (HasScreen(file.Name))
          {
            // return first 1600 bytes
            var mapBytes = new byte[1600];
            Array.Copy(fileBytes, 0, mapBytes, 0, 1600);
            // get tiles 
            
            var screenBitmap = CreateScreenImage(tiles, mapBytes, tileColors);
            var screenBitmap4x = BitmapHelper.Scale4(screenBitmap);
            screenBitmap.Save(screenPath + $"\\{BinFileHelper.GetBinFileNumber(file.Name)}.png");
            screenBitmap4x.Save(screen4xPath + $"\\{BinFileHelper.GetBinFileNumber(file.Name)}_upscaled.png");
          } else
          {
            var noscreen = true;
          }
          
          Offsets offsets = JsonSerializer.Deserialize<Offsets>(file.SpriteData);

          int spriteOffset = offsets.SpriteOffset;

          if (spriteOffset > 0 || (file.DyuvOffset > 0 && fileBytes.Length > 94208))
          {
            var paletteOffset = offsets.PaletteOffset > 0 ? offsets.PaletteOffset : file.DyuvOffset + dyuvBytesToRead + 0x20;
            var spriteOffsetBytes = paletteOffset + 66;
            var spriteOffsets = Utilities.ConvertNPCByteSequenceToIntList(fileBytes.Skip((int)spriteOffsetBytes).Take(12).ToArray());

            if (spriteOffsets.Count == 0)
            {
              continue;
            }
            var spriteBytes = fileBytes.Skip((int)spriteOffsetBytes + 12).Take(spriteOffsets.Last()).ToArray();
            var sprites = new List<byte[]> {
              spriteBytes.Take(spriteOffsets[0]).ToArray(),
              spriteBytes.Skip(spriteOffsets[0]).Take(spriteOffsets[1] - spriteOffsets[0]).ToArray(),
              spriteBytes.Skip(spriteOffsets[1]).Take(spriteOffsets[2] - spriteOffsets[1]).ToArray(),
              spriteBytes.Skip(spriteOffsets[2]).Take(spriteOffsets[3] - spriteOffsets[2]).ToArray(),
              spriteBytes.Skip(spriteOffsets[3]).Take(spriteOffsets[4] - spriteOffsets[3]).ToArray(),
              spriteBytes.Skip(spriteOffsets[4]).Take(spriteOffsets[5] - spriteOffsets[4]).ToArray(),
            };
            var colors = ExtractPalette(fileBytes, (int)paletteOffset);

            foreach (var (sprite, index) in sprites.WithIndex())
            {
              var imageLines = SpriteHelper.DecodeImage(sprite);
              var bitmap = SpriteHelper.CreateBitmapFromImageLines(imageLines, colors);
              if (bitmap != null)
              {
                var bitmapScaled = BitmapHelper.Scale4(bitmap);
                bitmap.Save(Path.Combine(spritePath, BinFileHelper.GetBinFileNumber(file.Name) + $"_{index}.png"));
                bitmapScaled.Save(Path.Combine(sprite4xPath, BinFileHelper.GetBinFileNumber(file.Name) + $"_{index}_upscaled.png"));
              }
            }
          }
        }
      }
      return;
    }

    private bool HasScreen(string file)
    {
      string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
      if (fileNameWithoutExtension.Length > 0)
      {
        int lastUnderscoreIndex = fileNameWithoutExtension.LastIndexOf('_');
        if (lastUnderscoreIndex != -1 && lastUnderscoreIndex < fileNameWithoutExtension.Length - 1)
        {
          string numericPart = fileNameWithoutExtension.Substring(lastUnderscoreIndex + 1);
          if (Int32.TryParse(numericPart, out int lastDigits) && lastDigits > 5)
          {
            return true;
          }
        }
      }
      return false;
    }

    private List<Color> ExtractPalette(byte[] binFileData, int paletteOffset)
    {
      var colors = new List<Color>();
      var palette = binFileData.Skip(paletteOffset).Take(64).ToArray();
      if (palette.Length > 0)
      {
        var length = (int)palette.Length;
        var count = 1;
        for (int i = 0; i < length; i += 4)
        {
          var r = palette[i + 1];
          var g = palette[i + 2];
          var b = palette[i + 3];
          var color = Color.FromArgb(255, r, g, b);
          colors.Add(color);
          count++;
        }
        if (colors.Count < 16)
        {
          var remaining = 16 - colors.Count;
          for (int i = 0; i < remaining; i++)
          {
            colors.Add(Color.FromArgb(255, 0, 0, 0));
          }
        }
      }
      return colors;
    }

    private Bitmap CreateScreenImage(List<byte[]> _tiles, byte[] _mapData, List<Color> _colors)
    {
      var mapTiles = new List<byte[]>();
      for (int i = 0; i < _mapData.Length; i += 2)
      {
        int index = (_mapData[i] << 8) + _mapData[i + 1];
        byte[] tile = new byte[64];
        Array.Copy(_tiles[index], tile, 64);
        mapTiles.Add(tile);
      }
      var tempScreenBitmap = new Bitmap(320, 160);
      for (int y = 0; y < 160; y++)
      {
        for (int x = 0; x < 320; x++)
        {
          int tileX = x / 8;
          int tileY = y / 8;
          int tileIndex = tileX + (tileY * 40);
          int tilePixelX = x % 8;
          int tilePixelY = y % 8;
          int tilePixelIndex = tilePixelX + (tilePixelY * 8);
          int colorIndex = mapTiles[tileIndex][tilePixelIndex];
          Color color = _colors[colorIndex];
          tempScreenBitmap.SetPixel(x, y, color);
        }
      }
      return tempScreenBitmap;
    }
  }
  public class Offsets
  {
    public int PaletteOffset { get; set; }
    public int SpriteOffset { get; set; }
  }
}
