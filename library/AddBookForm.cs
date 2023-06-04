using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace library
{
    public partial class AddBookForm : Form
    {

        DBClass DataBase = new DBClass();
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtAuthor = new DataTable();
            DataTable dtPublishing = new DataTable();

            string[] name = AuthorNameBox.Text.Split(' ');
            string[] publishing = ListPublicationsBox.Text.Split('\n');
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommandAuthor = new SqlCommand($"SELECT * FROM dbo.Author WHERE Name = '{name[1]}' and Surname = '{name[0]}'"))
                {
                    adapter.SelectCommand = sqlCommandAuthor;
                    adapter.Fill(dtAuthor);
                }
                int numpub = 1;
                foreach(var pub in publishing)
                {
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.Publications WHERE publishingHouse = '{pub}'");


                }
                
                connection.Close();
            }
        }
    }
}
