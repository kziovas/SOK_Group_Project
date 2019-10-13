using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RapidAppDev
{
    public partial class UserBar : RapidAppDev.UserBase
    {
        public UserBar(user usr)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/cmyk.txt");
            label1.Text = File.ReadAllText("Texts/pirates.txt");
            label8.Text = File.ReadAllText("Texts/liotrivi.txt");
            pictureBox1.ImageLocation = "Bars/cmyk.jpg";
            pictureBox2.ImageLocation = "Bars/pirates.jpg";
            pictureBox3.ImageLocation = "Bars/liotrivi.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserBar");
        }
    }
}
