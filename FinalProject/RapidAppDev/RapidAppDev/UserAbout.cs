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
    public partial class UserAbout : RapidAppDev.UserBase
    {

        public UserAbout(user usr)
        {
            InitializeComponent();
            label1.Text = File.ReadAllText("Texts/about.txt");

            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserAbout");
        }
    }
}
