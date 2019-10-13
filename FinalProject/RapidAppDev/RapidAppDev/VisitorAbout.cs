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
    public partial class VisitorAbout : RapidAppDev.VisitorBase
    {
        public VisitorAbout(visitor guest)
        {
            InitializeComponent();
            label1.Text = File.ReadAllText("Texts/about.txt");

            bool alreadyBeen = guest.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            Guest = guest;
            Guest.UpdHist("VisitorAbout");
        }
    }
}
