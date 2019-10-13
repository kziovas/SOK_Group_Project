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
    public partial class VisitorBookSearch : RapidAppDev.VisitorBase
    {
        public OleDbConnection connection = new OleDbConnection();
        public VisitorBookSearch(visitor guest)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Books.mdb;";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Books;";
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0].DefaultView;
            connection.Close();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 55;


            bool alreadyBeen = guest.Visited(this.Name.ToString());
            if (alreadyBeen)
            {
                this.toolStripVisited.Visible = true;
            }
            Guest = guest;
            Guest.UpdHist("VisitorBookSearch");
        }

        private void VisitorBookSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDataSet.Books);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Books.mdb;";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT ID,BookName,BookAuthor,BookPublisher,BookPrice FROM Books where BookName like '%" + textBox3.Text + "%'";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Orders.mdb;";
            connection.Open();
            // Create a command object, give it a connection object, give it a query to update our database
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            command.CommandText = "INSERT INTO Orders(OrderId,BookName,BookPrice) VALUES('" +this.Guest.orderId.ToString() + "','" + name + "'," + price + "); ";
            // Now simply execute it!
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
