using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace RapidAppDev
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public static string globalusername;
        public readonly Timer timer1 = new Timer();
        public int i = 1;
        public Login()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 4000;
            timer1.Start();
            timer1.Tick += new System.EventHandler(timer1_Tick);
            Slideshow.ImageLocation = "Images/1.jpg";
            Slideshow.SizeMode = PictureBoxSizeMode.StretchImage;
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb;";
            label1.Hide();
            label5.Hide();
            usernameBox.Hide();
            PswdBox.Hide();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb;";
                connection.Open();
                // Create a command object, give it a connection object, give it a query to update our database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM guest ;";
                // Now simply execute it!
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet dt = new DataSet();
                da.Fill(dt);
                try 
                {
                    visitor vistr = new visitor();
                    vistr.Username = dt.Tables[0].Rows[0]["Username"].ToString();
                    vistr.Visits = dt.Tables[0].Rows[0]["Visits"].ToString();
                    vistr.orderId = "VON"+vistr.Visits.ToString();
                   
                    int visitcount = Convert.ToInt32(vistr.Visits);
           
                    // Create a command object, give it a connection object, give it a query to update our database
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;
                    visitcount++;
                    command2.CommandText = "UPDATE guest SET Visits=" + visitcount + " WHERE Username='" + vistr.Username + "';";
                    // Now simply execute it!
                    command2.ExecuteNonQuery();
                    connection.Close();
                    globalusername = vistr.Username;
                    VisitorHome VHF = new VisitorHome(vistr);
                    VHF.Show();
                    this.Hide();

                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Login failed! User or Guest are not found!");
                    connection.Close();
                }

            }
            else if (radioButton2.Checked == true)
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb;";
                connection.Open();
                // Create a command object, give it a connection object, give it a query to update our database
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM users WHERE Username='" + usernameBox.Text + "';";
                // Now simply execute it!
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet dt = new DataSet();
                da.Fill(dt);
                try
                {
                    user usr = new user();
                    usr.Username= dt.Tables[0].Rows[0]["Username"].ToString();
                    usr.Password = dt.Tables[0].Rows[0]["Password"].ToString();
                    usr.Visits = dt.Tables[0].Rows[0]["Visits"].ToString();      
                    usr.ID= Convert.ToInt32(dt.Tables[0].Rows[0]["UserID"]);
                    int visitcount = Convert.ToInt32(usr.Visits);
                    connection.Close();
                    if (usr.Password == PswdBox.Text)
                    {

                        connection.Open();
                        // Create a command object, give it a connection object, give it a query to update our database
                        OleDbCommand command2 = new OleDbCommand();
                        command2.Connection = connection;
                        visitcount ++;
                        command2.CommandText = "UPDATE users SET Visits="+visitcount+" WHERE UserID=" + usr.ID + ";";
                        // Now simply execute it!
                        command2.ExecuteNonQuery();
                        connection.Close();
                        globalusername = usr.Username;
                        Home HF = new Home(usr);
                        HF.Show();
                        this.Hide();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Wrong Password ! Try again.");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Wrong Username! Try again.");
                    connection.Close();
                }
              

            }
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            label1.Hide();
            label5.Hide();
            usernameBox.Hide();
            PswdBox.Hide();
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            label1.Show();
            label5.Show();
            usernameBox.Show();
            PswdBox.Show();
        }
    }
}
