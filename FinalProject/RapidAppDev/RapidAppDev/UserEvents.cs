using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace RapidAppDev
{
    public partial class UserEvents : RapidAppDev.UserBase
    {
        public OleDbConnection connection = new OleDbConnection();
        public UserEvents(user usr)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=EventCalendar.mdb;";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Events;";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 55;


            bool alreadyBeen = usr.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            User = usr;
            User.UpdHist("UserEvents");
        }

        private void UserEvents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventCalendarDataSet1.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter1.Fill(this.eventCalendarDataSet1.Events);
            // TODO: This line of code loads data into the 'eventCalendarDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.eventCalendarDataSet.Events);

        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=EventCalendar.mdb;";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Events Where EventDate=@date;";
            command.Parameters.AddWithValue("@date", monthCalendar1.SelectionRange.Start);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0].DefaultView;
            connection.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"Info.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int textcount = 0;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    textcount += dataGridView1.Rows[i].Cells[j].Value.ToString().Length;
                    textcount += 14;
                }
                writer.WriteLine("");
                for (int m = 0; m < textcount; m++)
                {
                    writer.Write("-");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }
    }
}
