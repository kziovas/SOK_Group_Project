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
    public partial class VisitorBase : Form
    {
        public visitor Guest = new visitor();
        public VisitorBase()
        {
            InitializeComponent();
            
        }

        private void ΠΑΡΑΛΙΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VisitorBeach VBF = new VisitorBeach(Guest);
            VBF.Show();
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            VisitorSites VSF = new VisitorSites(Guest);
            VSF.Show();
            this.Close();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VisitorHome VHF = new VisitorHome(Guest);
            VHF.Show();
            this.Close();
        }

        private void ΕΞΟΔΟΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LGF = new Login();
            LGF.Show();
            this.Close();

        }

        private void ΕΞΟΔΟToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VisitorAbout VAF = new VisitorAbout(Guest);
            VAF.Show();
            this.Close();
        }

        private void ToolStripVisited_Click(object sender, EventArgs e)
        {
            Guest.History.Clear();
            this.toolStripVisited.Visible = false;
        }
    }
}
