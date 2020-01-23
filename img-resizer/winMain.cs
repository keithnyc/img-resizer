using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace img_resizer
{
    public partial class winMain : Form
    {
        public winMain()
        {
            InitializeComponent();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {

            if (lbFiles.Items.Count == 0)
                return;
            if (txtH.Text.Length == 0)
                return;
            if (txtW.Text.Length == 0)
                return;
            if (txtPrefix.Text.Length == 0)
                return;


            btnResize.Enabled = false;
            Application.DoEvents();

            foreach (var f in Directory.EnumerateFiles(txtPath.Text))
            {
                if (!f.ToLower().Contains(".jpg"))
                    continue;

                FileInfo info = new FileInfo(f);
                using (Image image = Image.FromFile(f))
                {

                    if (rdoPerc.Checked)
                    {
                        using (Bitmap resizedImage = ImageHelper.ResizeImage(image, decimal.Parse(txtPerc.Text)))
                        {
                            resizedImage.Save(
                                info.DirectoryName + "\\"
                                    + txtPrefix.Text
                                    + info.Name.Substring(0, info.Name.LastIndexOf(info.Extension))
                                    + "_" + resizedImage.Width + "_" + resizedImage.Height
                                    + info.Extension,
                                ImageFormat.Jpeg);
                        }
                    }
                    else
                    {
                        using (Bitmap resizedImage = ImageHelper.ResizeImage(image, int.Parse(txtW.Text), int.Parse(txtH.Text)))
                        {
                            resizedImage.Save(
                                info.DirectoryName + "\\"
                                    + txtPrefix.Text
                                    + info.Name.Substring(0, info.Name.LastIndexOf(info.Extension))
                                    + "_" + resizedImage.Width + "_" + resizedImage.Height
                                    + info.Extension,
                                ImageFormat.Jpeg);
                        }
                    }
                   
                }

                foreach(var item in lbFiles.Items)
                {
                    if (f.ToLower().Contains(item.ToString().ToLower()))
                    {
                        lbFiles.Items.Remove(item);
                        Application.DoEvents();
                        break;
                    }
                }
            }

            btnResize.Enabled = true;
            MessageBox.Show("Operation completed successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgBrowseDir.ShowDialog() == DialogResult.None)
                return;

            txtPath.Text = dlgBrowseDir.SelectedPath;
            list_files();
        }

        private void list_files()
        {
            lbFiles.Items.Clear();
            
            foreach (var f in Directory.EnumerateFiles(txtPath.Text))
            {
                if (!f.ToLower().Contains(".jpg"))
                    continue;
                lbFiles.Items.Add(Path.GetFileName(f));                
            }
        }
    }

    public static class ImageHelper
    {
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);                    
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            destImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return destImage;
        }

        public static Bitmap ResizeImage(Image image, decimal percentage)
        {
            int width = (int)Math.Round(image.Width * percentage, MidpointRounding.AwayFromZero);
            int height = (int)Math.Round(image.Height * percentage, MidpointRounding.AwayFromZero);
            return ResizeImage(image, width, height);
        }
    }

}
