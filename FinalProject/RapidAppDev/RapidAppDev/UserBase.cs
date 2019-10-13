using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidAppDev
{
    public partial class UserBase : Form
    {
        public user User = new user();
        public UserBase()
        {
            InitializeComponent();
        }

        private void ΠΑΡΑΛΙΕΣToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ΕΞΟΔΟToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAbout UAF = new UserAbout(User);
            UAF.Show();
            this.Hide();
        }

        private void ToolStripVisited_Click(object sender, EventArgs e)
        {
            User.History.Clear();
            this.toolStripVisited.Visible = false;
        }
    }
}
