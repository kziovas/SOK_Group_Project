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
    public partial class VisitorBeach : RapidAppDev.VisitorBase
    {
        
        public VisitorBeach(visitor guest)
        {
            InitializeComponent();
            label5.Text = File.ReadAllText("Texts/peukoulia.txt");
            label6.Text = File.ReadAllText("Texts/agios_nikhtas.txt");
            label8.Text = File.ReadAllText("Texts/porto_katsiki.txt");
            label12.Text = File.ReadAllText("Texts/nikiana.txt");
            pictureBox1.ImageLocation = "Beaches/peukoulia.jpg";
            pictureBox2.ImageLocation = "Beaches/agiosnikitas.jpg";
            pictureBox3.ImageLocation = "Beaches/portokatsiki.jpg";
            pictureBox4.ImageLocation = "Beaches/nikiana.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Hide();

            bool alreadyBeen = guest.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            Guest = guest;
            Guest.UpdHist("VisitorBeach");

        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Beaches/peukoulia.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Beaches/agiosnikitas.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            
            pictureBox5.ImageLocation = "Beaches/portokatsiki.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = "Beaches/nikiana.jpg";
            pictureBox5.Show();
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.SizeAll;
        }
    }
}
