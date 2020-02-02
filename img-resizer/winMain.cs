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


        private RotateFlipType calcXForm(int rotateDegrees, bool Hflip, bool Vflip)
        {
            bool isFlipBoth = false;
            if (Hflip && Vflip)
                isFlipBoth = true;

            switch (rotateDegrees)
            {
                case 0:
                    if (isFlipBoth)
                        return RotateFlipType.RotateNoneFlipXY;
                    if (Hflip)
                        return RotateFlipType.RotateNoneFlipY;
                    if (Vflip)
                        return RotateFlipType.RotateNoneFlipX;
                    return RotateFlipType.RotateNoneFlipNone;
                case 90:
                    if (isFlipBoth)
                        return RotateFlipType.Rotate90FlipXY;
                    if (Hflip)
                        return RotateFlipType.Rotate90FlipY;
                    if (Vflip)
                        return RotateFlipType.Rotate90FlipX;
                    return RotateFlipType.Rotate90FlipNone;

                case 180:
                    if (isFlipBoth)
                        return RotateFlipType.Rotate180FlipXY;
                    if (Hflip)
                        return RotateFlipType.Rotate180FlipY;
                    if (Vflip)
                        return RotateFlipType.Rotate180FlipX;
                    return RotateFlipType.Rotate180FlipNone;
                case 270:
                    if (isFlipBoth)
                        return RotateFlipType.Rotate270FlipXY;
                    if (Hflip)
                        return RotateFlipType.Rotate270FlipY;
                    if (Vflip)
                        return RotateFlipType.Rotate270FlipX;
                    return RotateFlipType.Rotate270FlipNone;
                default:
                    break;
            }
            return RotateFlipType.RotateNoneFlipNone;
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
            pbOperation.Value = 0;
            pbOperation.Maximum = lbFiles.Items.Count;

            Application.DoEvents();

            try
            {
                int fileCount = 0;
                RotateFlipType imageOptions = RotateFlipType.RotateNoneFlipNone;                
                int rotateDegrees = 0;

                if (rdoRot90.Checked)
                    rotateDegrees = 90;
                if (rdoRot180.Checked)
                    rotateDegrees = 180;
                if (rdoRot270.Checked)
                    rotateDegrees = 270;

                imageOptions = calcXForm(rotateDegrees, chkFlipH.Checked, chkFlipV.Checked);


                foreach (var f in Directory.EnumerateFiles(txtPath.Text))
                {
                    if (!f.ToLower().Contains(".jpg"))
                        continue;

                    ++fileCount;
                    string outputFilename = "";
                    FileInfo info = new FileInfo(f);

                    outputFilename = txtPrefix.Text + "-" + fileCount.ToString() + ".jpg";
                    outputFilename = info.DirectoryName + "\\" + outputFilename;

                    using (Image image = Image.FromFile(f))
                    {

                        if (rdoPerc.Checked)
                        {
                            using (Bitmap resizedImage = ImageHelper.ResizeImage(image, decimal.Parse(txtPerc.Text), imageOptions))
                                resizedImage.Save(outputFilename, ImageFormat.Jpeg);
                        }
                        else
                        {
                            using (Bitmap resizedImage = ImageHelper.ResizeImage(image, int.Parse(txtW.Text), int.Parse(txtH.Text), imageOptions))
                                resizedImage.Save(outputFilename,ImageFormat.Jpeg);
                        }

                    }

                    foreach (var item in lbFiles.Items)
                    {
                        if (f.ToLower().Contains(item.ToString().ToLower()))
                        {
                            lbFiles.Items.Remove(item);
                            pbOperation.Value++;
                            Application.DoEvents();
                            break;
                        }
                    }
                }
                savePaths();
                MessageBox.Show("Operation completed successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while resizing: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                btnResize.Enabled = true;
                pbOperation.Value = 0;
            }
            
        }

        private void savePaths()
        {
            Properties.Settings.Default.LastSourcePath = txtPath.Text;
            Properties.Settings.Default.LastOutputPath = txtOutput.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgBrowseDir.ShowDialog() == DialogResult.None)
                return;

            txtPath.Text = dlgBrowseDir.SelectedPath;
            txtOutput.Text = dlgBrowseDir.SelectedPath;
            list_files();

            savePaths();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dlgBrowseDir.ShowDialog() == DialogResult.None)
                return;

            txtOutput.Text = dlgBrowseDir.SelectedPath;

            savePaths();

        }

        private void winMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LastSourcePath.Length > 0)
            {
                txtPath.Text = Properties.Settings.Default.LastSourcePath;
                list_files();
            }
                

            if (Properties.Settings.Default.LastOutputPath.Length > 0)
                txtOutput.Text = Properties.Settings.Default.LastOutputPath;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtPath.Text.Length > 0)
                list_files();
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
        public static Bitmap ResizeImage(Image image, int width, int height, RotateFlipType imageFlipOptions)
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
                    wrapMode.SetWrapMode(WrapMode.Clamp);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            //destImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            destImage.RotateFlip(imageFlipOptions);
            
            
            return destImage;
        }

        public static Bitmap ResizeImage(Image image, decimal percentage, RotateFlipType imageFlipOptions)
        {
            int width = (int)Math.Round(image.Width * percentage, MidpointRounding.AwayFromZero);
            int height = (int)Math.Round(image.Height * percentage, MidpointRounding.AwayFromZero);
            return ResizeImage(image, width, height, imageFlipOptions);
        }
    }

}
