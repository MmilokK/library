using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBookForm f = new AddBookForm();
            this.Hide();
            f.ShowDialog();
            
        }

        private void AllDB_Click(object sender, EventArgs e)
        {
            AllDB f = new AllDB();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void request1_Click(object sender, EventArgs e)
        {
            Request r = new Request(1);
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void request2_Click(object sender, EventArgs e)
        {
            Request r = new Request(2);
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void request3_Click(object sender, EventArgs e)
        {
            Request r = new Request(3);
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void request4_Click(object sender, EventArgs e)
        {
            Request r = new Request(4);
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void request5_Click(object sender, EventArgs e)
        {
            Request r = new Request(5);
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
