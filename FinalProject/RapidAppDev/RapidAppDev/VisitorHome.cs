using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace RapidAppDev
{
    public partial class VisitorHome : RapidAppDev.VisitorBase
    {
        string path1 = "Texts/lefkadamain1.txt";
        string path2 = "Texts/lefkadamain2.txt";
        public readonly Timer timer1 = new Timer();
        public int i = 1;
        
        public VisitorHome(visitor guest)
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 4000;
            timer1.Start();
            timer1.Tick += new System.EventHandler(timer1_Tick);
            Slideshow.ImageLocation = "Images/1.jpg";
            Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = File.ReadAllText(path1);
            label5.Text = File.ReadAllText(path2);

            bool alreadyBeen = guest.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            Guest = guest;
            Guest.UpdHist("VisitorHome");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i > 1 && i <= 7)
            {
                // SlideShow.ImageLocation = "../images/" + i + ".jpg";
                //SlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
                //MessageBox.Show("The picture is" + i);
                Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
                Slideshow.ImageLocation = "Images/" + i.ToString() + ".jpg";
                Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
                //abel28.Text = i.ToString();
                i++;

            }
            else
            {
                i = 1;
                //label28.Text = i.ToString();
                Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
                Slideshow.ImageLocation = "Images/" + i.ToString() + ".jpg";
                Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
                //SlideShow.ImageLocation = "../images/" + i + ".jpg";
                //SlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
                i++;
            }
        }




        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada.gov.gr/");
        }

        private void LinkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada.gr/pages.asp?pageid=215&langid=1");
        }

        private void LinkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ktel-lefkadas.gr/en/1942-2/");
        }

        private void LinkLabel6_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://odysseus.culture.gr/h/1/gh151.jsp?obj_id=3307");
        }

        private void LinkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.hcg.gr/node/204");
        }

        private void LinkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.astynomia.gr/index.php?option=ozo_content&perform=view&id=860&Itemid=265&lang=");
        }

        private void LinkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada-hospital.gr/");
        }

        private void Label5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Label5_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            
            VisitorBeach VBF = new VisitorBeach(Guest);
            VBF.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            VisitorVideos VVDF = new VisitorVideos(Guest);
            VVDF.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            VisitorPicture VPF = new VisitorPicture(Guest);
            VPF.Show();
            this.Close();
        }
    }
}
