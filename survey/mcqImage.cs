using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace survey
{
    public partial class mcqImage : Form
    {
        public mcqImage(Bitmap image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)  //when the user clicks the Save button
        {
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Tiff;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.tif;*.png;*.bmp;*.jpg;"; //Supported save formats, default format is .tif
            sfd.FileName = "Exam Sample";   //default name
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName); //image format
                //save image with format given by user(default is .tif)
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);   //save image
            }
        }

    }
}
