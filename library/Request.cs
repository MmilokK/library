using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Request : Form
    {
        int requestNumber = 0;
        DBClass db = new DBClass();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dtA = new DataTable();
        DataTable dtB = new DataTable();
        DataTable dtP = new DataTable();
        public Request(int r)
        {
            InitializeComponent();
            requestNumber = r;
            parametr.Text = "";
            parametrBox.Visible = false;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            db.openConnection();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            switch (requestNumber)
            {
                case 1:
                    {
                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Publications", db.getConnection());
                        adapter.Fill(dtP);

                        DataView dv = new DataView(dtP);
                        dv.Sort = "Year DESC";
                        dtP = dv.ToTable();
                        DataRow rowP = dtP.Rows[0];
                        //var p = row["IdBook"];

                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Books WHERE Id = '{(int)rowP["BookId"]}'", db.getConnection());
                        adapter.Fill(dtB);

                        DataRow rowB = dtB.Rows[0];

                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Authors WHERE Id = '{(int)rowB["AuthorId"]}'", db.getConnection());
                        adapter.Fill(dtA);

                        DataRow rowA = dtA.Rows[0];

                        dataGridView1.DataSource = dtA;
                        break;
                    }
                    case 2:
                    {
                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Publications WHERE Number > 1", db.getConnection());
                        adapter.Fill(dtP);

                        DataRow r = dtP.Rows[0];
                        List<int> ind = new List<int>(10);
                        ind.Add((int)r["BookId"]);
                        foreach (DataRow row in dtP.Rows)
                        {
                            if ((int)row["BookId"] == (int)r["BookId"]) ;
                            else
                                ind.Add((int)row["BookId"]);
                            r = row;
                        }
                        foreach (var i in ind)
                        {
                            adapter = new SqlDataAdapter($"SELECT * FROM dbo.Books WHERE Id = '{i}'", db.getConnection());
                            adapter.Fill(dtB);
                        }
                        dataGridView1.DataSource = dtB;
                        break;
                    }
                    case 3:
                    {
                        
                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Publications WHERE PublishingHouse = '{parametrBox.Text}' and Year > 2012", db.getConnection());
                        adapter.Fill(dtP);

                        DataRow r = dtP.Rows[0];
                        List<int> ind = new List<int>(10);
                        ind.Add((int)r["BookId"]);
                        foreach (DataRow row in dtP.Rows)
                        {
                            if ((int)row["BookId"] == (int)r["BookId"]) ;
                            else
                                ind.Add((int)row["BookId"]);
                            r = row;
                        }
                        foreach (var i in ind)
                        {
                            adapter = new SqlDataAdapter($"SELECT * FROM dbo.Books WHERE Id = '{i}'", db.getConnection());
                            adapter.Fill(dtB);
                        }
                        dataGridView1.DataSource = dtB;

                        break;
                    }
                case 4:
                    {
                        
                        string[] s = parametrBox.Text.Split(' ');
                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Authors WHERE  Name = '{s[1]}' and Surname = '{s[0]}'", db.getConnection());
                        adapter.Fill(dtA);

                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Books WHERE AuthorId = '{dtA.Rows[0]["Id"]}'", db.getConnection());
                        adapter.Fill(dtB);

                        dataGridView1.DataSource = dtB;
                        break;
                    }
                case 5:
                    {
                        
                        adapter = new SqlDataAdapter($"SELECT * FROM dbo.Publications WHERE Cost > '{parametrBox.Text}'", db.getConnection());
                        adapter.Fill(dtP);

                        DataRow r = dtP.Rows[0];
                        List<int> ind = new List<int>(10);
                        ind.Add((int)r["BookId"]);
                        foreach (DataRow row in dtP.Rows)
                        {
                            if ((int)row["BookId"] == (int)r["BookId"]) ;
                            else
                                ind.Add((int)row["BookId"]);
                            r = row;
                        }
                        foreach (var i in ind)
                        {
                            adapter = new SqlDataAdapter($"SELECT * FROM dbo.Books WHERE Id = '{i}'", db.getConnection());
                            adapter.Fill(dtB);
                        }
                        dataGridView1.DataSource = dtB;
                        break;
                    }
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            switch (requestNumber)
            {
                case 3:
                    {
                        parametr.Text = "Издательство:";
                        parametrBox.Visible = true;
                        break;
                    }
                case 4:
                    {
                        parametr.Text = "Автор:";
                        parametrBox.Visible = true;
                        break;
                    }
                case 5:
                    {
                        parametr.Text = "Цена:";
                        parametrBox.Visible = true;
                        break;
                    }
            }
        }
    }
}
