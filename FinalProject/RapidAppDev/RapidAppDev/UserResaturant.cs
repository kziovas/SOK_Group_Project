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
    public partial class UserResaturant : RapidAppDev.UserBase
    {
        public UserResaturant(user usr)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/frini.txt");
            label1.Text = File.ReadAllText("Texts/raxi.txt");
            label8.Text = File.ReadAllText("Texts/stavros.txt");
            pictureBox1.ImageLocation = "Restaurant/frini.jpeg";
            pictureBox2.ImageLocation = "Restaurant/raxi.jpg";
            pictureBox3.ImageLocation = "Restaurant/stavros.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserResaturant");
        }
    }
}
