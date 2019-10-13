using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RapidAppDev
{
    public partial class UserPicture : RapidAppDev.UserBase
    {
        public UserPicture(user usr)
        {
            InitializeComponent();
            InitializeComponent();
            pictureBox1.ImageLocation = "Gallery/1.jpg";
            pictureBox2.ImageLocation = "Gallery/2.jpg";
            pictureBox3.ImageLocation = "Gallery/3.jpeg";
            pictureBox4.ImageLocation = "Gallery/4.jpg";
            pictureBox5.ImageLocation = "Gallery/5.jpg";
            pictureBox6.ImageLocation = "Gallery/6.jpg";
            pictureBox7.ImageLocation = "Gallery/7.jpg";
            pictureBox8.ImageLocation = "Gallery/8.jpg";
            pictureBox9.ImageLocation = "Gallery/9.jpg";
            pictureBox10.ImageLocation = "Gallery/10.jpg";

            pictureBox11.ImageLocation = "Gallery/1.jpg";


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserPicture");
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Azure;
            panel2.BackColor = Color.Azure;
            panel3.BackColor = Color.Azure;
            panel4.BackColor = Color.Azure;
            panel5.BackColor = Color.Azure;
            panel6.BackColor = Color.Azure;
            panel7.BackColor = Color.Azure;
            panel8.BackColor = Color.Azure;
            panel9.BackColor = Color.Azure;
            panel10.BackColor = Color.Azure;
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/1.jpg";
            label1.Text = "Άγιος Νικήτας";
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/1.jpg";
            label1.Text = "Άγιος Νικήτας";
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/2.jpg";
            label1.Text = "Μονή Φανερωμένης";
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/2.jpg";
            label1.Text = "Μονή Φανερωμένης";
        }

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/3.jpeg";
            label1.Text = "Καρυώτες";
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/3.jpeg";
            label1.Text = "Καρυώτες";
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {

            panel4.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/4.jpg";
            label1.Text = "Κάστρο Λευκάδας";
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/4.jpg";
            label1.Text = "Κάστρο Λευκάδας";
        }

        private void PictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/5.jpg";
            label1.Text = "Κάστρο Λευκάδας-Φαρος";
        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/5.jpg";
            label1.Text = "Κάστρο Λευκάδας-Φαρος";
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/6.jpg";
            label1.Text = "Μονή Φανερωμένης-Αυλή";
        }

        private void PictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/6.jpg";
            label1.Text = "Μονή Φανερωμένης-Αυλή";
        }

        private void PictureBox10_MouseHover(object sender, EventArgs e)
        {
            panel10.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/10.jpg";
            label1.Text = "Ράχη";
        }

        private void PictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            panel10.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/10.jpg";
            label1.Text = "Ράχη";
        }

        private void PictureBox9_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/9.jpg";
            label1.Text = "Πόρτο Κατσίκι";
        }

        private void PictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/9.jpg";
            label1.Text = "Πόρτο Κατσίκι";
        }

        private void PictureBox8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/8.jpg";
            label1.Text = "Πευκούλια";
        }

        private void PictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/8.jpg";
            label1.Text = "Πευκούλια";
        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/7.jpg";
            label1.Text = "Νικιάνα";
        }

        private void PictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BackColor = Color.LightBlue;
            pictureBox11.ImageLocation = "Gallery/7.jpg";
            label1.Text = "Νικιάνα";
        }
    }
}
