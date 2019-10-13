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
    public partial class UserHotels : RapidAppDev.UserBase
    {
        public UserHotels(user usr)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/sunrisehotel.txt");
            label1.Text = File.ReadAllText("Texts/hotelboschetto.txt");
            label8.Text = File.ReadAllText("Texts/villaverde.txt");
            pictureBox1.ImageLocation = "Hotels/sunrisehotel.jpg";
            pictureBox2.ImageLocation = "Hotels/hotelboschetto.jpg";
            pictureBox3.ImageLocation = "Hotels/villaverde.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserHotels");
        }
    }
}
