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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'voituresDataSet1.Voiture'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.voitureTableAdapter.Fill(this.voituresDataSet1.Voiture);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Voiture", "server = localhost; database = Voitures; UID = sa; password = 123456");
            DataSet ds = new DataSet();
            da.Fill(ds, "Voiture");
            DataGridView dv = new DataGridView();
            dv.DataSource = ds.Tables["Voiture"].DefaultView;
            dv.Show();
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
