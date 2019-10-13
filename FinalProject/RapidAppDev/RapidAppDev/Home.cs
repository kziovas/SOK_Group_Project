using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace RapidAppDev
{
    public partial class Home : Form
    {
        public user User = new user();

        string path1 = "Texts/lefkadamain1.txt";
        string path2 = "Texts/lefkadamain2.txt";
        string path3 = "Texts/lefkadamain3.txt";
        public readonly Timer timer1 = new Timer();
        public int i = 1;
        public Home(user usr)
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
            label9.Text= File.ReadAllText(path3);
            welcome.Text = "ΚΑΛΩΣ ΕΠΕΣΤΡΕΨΕΣ " + Login.globalusername + "  ΣΤΟN ΟΔΗΓΟ!";

            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("Home");

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


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada.gov.gr/");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.astynomia.gr/index.php?option=ozo_content&perform=view&id=860&Itemid=265&lang=");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.hcg.gr/node/204");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada-hospital.gr/");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lefkada.gr/pages.asp?pageid=215&langid=1");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://odysseus.culture.gr/h/1/gh151.jsp?obj_id=3307");
        }

        public void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ktel-lefkadas.gr/en/1942-2/");
        }

        private void Label5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void LinkLabel5_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Label5_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Label9_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Label9_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void ΠΑΡΑΛΙΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBeach UBF = new UserBeach(User);
            UBF.Show();
            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            UserBeach UBF = new UserBeach(User);
            UBF.Show();
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserSites USF = new UserSites(User);
            USF.Show();
            this.Close();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home HF = new Home(User);
            HF.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserVideos UVDF = new UserVideos(User);
            UVDF.Show();
            this.Close();
        }

        private void ΕΞΟΔΟΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LGF = new Login();
            LGF.Show();
            this.Close();
        }

        private void ΞΕΝΟΔΟΧΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHotels UHF = new UserHotels(User);
            UHF.Show();
            this.Hide();
        }

        private void ΚΑΜΠΙΝΓΚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCamping UCF = new UserCamping(User);
            UCF.Show();
            this.Hide();
        }

        private void ΕΣΤΙΑΤΟΡΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserResaturant URF = new UserResaturant(User);
            URF.Show();
            this.Hide();
        }

        private void ΜΠΑΡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBar UBF = new UserBar(User);
            UBF.Show();
            this.Hide();
        }

        private void ΕΚΔΗΛΩΣΕΙΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEvents UEF = new UserEvents(User);
            UEF.Show();
            this.Hide();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            UserEvents UEF = new UserEvents(User);
            UEF.Show();
            this.Hide();
        }

        private void ΕΞΟΔΟToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAbout UAF = new UserAbout(User);
            UAF.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UserPicture UPF = new UserPicture(User);
            UPF.Show();
            this.Hide();
        }

        private void ToolStripVisited_Click(object sender, EventArgs e)
        {
            User.History.Clear();
            this.toolStripVisited.Visible = false;
        }
    }
}
