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
    public partial class AllDB : Form
    {
        public AllDB()
        {
            InitializeComponent();
        }

        private void AllDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet2.Publications". При необходимости она может быть перемещена или удалена.
            this.publicationsTableAdapter.Fill(this.booksDataSet2.Publications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet1.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter1.Fill(this.booksDataSet1.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.booksDataSet.Authors);

         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
