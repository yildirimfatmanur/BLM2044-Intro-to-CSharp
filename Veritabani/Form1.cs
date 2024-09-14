using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Veritabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=postgres; user ID= postgres; password=2f116n"); 

        private void SELECT_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "select * from order_details";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu2 = "insert into order_details(order_id,product_id) values (@109901,@110011)";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu2, conn);
            komut.Parameters.AddWithValue("@109901", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@110011", int.Parse(textBox2.Text));
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Order_id eklendi");

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu3 = "delete from order_detiails where order_id = ";

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

        }
    }
}
