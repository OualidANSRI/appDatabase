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

namespace appDatabase
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server = localhost; database = Voitures; UID = sa; password = 123456");
            cn.Open();

            int id;
            if (textBox1.Text.CompareTo("") != 0)
            {
                id = Int32.Parse(textBox1.Text);
                
               string req = "DELETE FROM Voiture WHERE id = '" + id + "'";

                SqlCommand cmd = new SqlCommand(req, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Marque supprimée!");
            }
            else
            {
                MessageBox.Show("Entrez un id!");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
