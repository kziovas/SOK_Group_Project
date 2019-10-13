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
    public partial class UserCamping : RapidAppDev.UserBase
    {
        public UserCamping(user usr)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/kariotesbeach.txt");
            label1.Text = File.ReadAllText("Texts/kathisma.txt");

            pictureBox1.ImageLocation = "Camping/kariotesbeach.jpeg";
            pictureBox3.ImageLocation = "Camping/kariotesbeach2.jpeg";
            pictureBox4.ImageLocation = "Camping/kariotesbeach3.jpeg";

            pictureBox6.ImageLocation = "Camping/kathisma.jpeg";
            pictureBox5.ImageLocation = "Camping/kathisma2.jpeg";
            pictureBox2.ImageLocation = "Camping/kathisma3.jpeg";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserCamping");

        }
    }
}
