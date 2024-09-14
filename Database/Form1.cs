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

namespace Database
{
    public partial class Form1 : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteriGetir(); /// CALISMIYOR
        }

        void musteriGetir()
        {
            SqlConnection baglanti = new SqlConnection("server =.; Initial Catalog=postgres;Integrated Security=SSPI");
            baglanti.Open();
            adapter = new SqlDataAdapter("SELECT * FROM orders",baglanti);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);

            for (int i =0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(i);
            }
            
        }


        
        


    }
}
