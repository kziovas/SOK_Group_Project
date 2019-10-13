using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RapidAppDev
{
    public partial class UserVideos : RapidAppDev.UserBase
    {
        public UserVideos(user usr)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"Videos\lefkadaintro.mp4";


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserVideos");
        }
    }
}
