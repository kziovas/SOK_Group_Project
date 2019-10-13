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
    public partial class UserSites : RapidAppDev.UserBase
    {
        public UserSites(user usr)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/kastro.txt");
            label1.Text = File.ReadAllText("Texts/gefura.txt");
            label8.Text = File.ReadAllText("Texts/iera_monh.txt");
            pictureBox1.ImageLocation = "Sites/kastro.jpg";
            pictureBox2.ImageLocation = "Sites/gefira.jpg";
            pictureBox3.ImageLocation = "Sites/monastiri.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Hide();


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserSites");
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Sites/kastro.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Sites/gefira.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Sites/monastiri.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }
    }
}
