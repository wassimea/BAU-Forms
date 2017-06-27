using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace survey
{
    public partial class surveyImage : Form
    {
        public surveyImage(Bitmap image)
        {
            InitializeComponent();
            surveyMainForm testing = new surveyMainForm();
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Tiff;//new System.Drawing.Imaging.ImageFormat;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.tif;*.png;*.bmp;*.jpg;";
            sfd.FileName = "Survey Form";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }
        }
    }
}
