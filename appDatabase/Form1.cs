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
    public partial class Voitures : Form
    {
        public Voitures()
        {
            InitializeComponent();
        }

        private void Voitures_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void Voitures_Click(object sender, EventArgs e)
        {

        }

        private void Voitures_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Connect_Click(object sender, EventArgs e)
        {
            Boolean result = ClassConnectionSQL.db_connection();
            if (result == true)
            {
                MessageBoxButtons msgBu = MessageBoxButtons.YesNo;
                DialogResult rs = MessageBox.Show("Connexion réussie!\n Accéder à la table de voitures?", "Connexion", msgBu);
                if (rs == DialogResult.Yes)
                {
                    Form form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Connexion à la base de données échouée!");
            }
        }
    }
}
