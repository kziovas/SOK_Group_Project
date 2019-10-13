using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RapidAppDev
{
    public partial class VisitorVideos : RapidAppDev.VisitorBase
    {
        public VisitorVideos(visitor guest)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"Videos\lefkadaintro.mp4";

            bool alreadyBeen = guest.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            Guest = guest;
            Guest.UpdHist("VisitorVideos");
        }
    }
}
