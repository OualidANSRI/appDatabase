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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 form = new Form2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            String req;
            String marque;
            String modele;
            int annee = 0;
            DialogResult rs;
            MessageBoxButtons msgBu;

            SqlCommand cmd;
            SqlConnection cn = new SqlConnection("server = localhost; database = Voitures; UID = sa; password = 123456");
            cn.Open();


            if (textBox1.Text.CompareTo("") == 0 && textBox2.Text.CompareTo("") == 0 && textBox3.Text.CompareTo("") == 0 && textBox4.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Entrez l'id et saisissez une valeur dans l'un des champs!");
            }
            else
            {
                if (textBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Entrez le champs id!");
                }
                else
                {
                    if (textBox2.Text.CompareTo("") == 0 || textBox3.Text.CompareTo("") == 0 || textBox4.Text.CompareTo("") == 0)
                    {
                        MessageBox.Show("Veuillez remplir un des champs!");
                    }
                    else
                    {
                        marque = textBox2.Text;
                        modele = textBox3.Text;
                        id = Int32.Parse(textBox1.Text);
                        if (textBox4.Text.CompareTo("") != 0)
                        {
                            annee = Int32.Parse(textBox4.Text);
                        }
                        msgBu = MessageBoxButtons.YesNo;
                        rs = MessageBox.Show("Ajout de données?", "ajout ou modification", msgBu);

                        if (rs == DialogResult.Yes)
                        {

                            req = "INSERT INTO Voiture VALUES ('" + id + "','" + marque + "','" + modele + "','" + annee + "')";

                            cmd = new SqlCommand(req, cn);
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Marque ajoutée!");
                        }
                        else
                        {
                            msgBu = MessageBoxButtons.YesNo;
                            rs = MessageBox.Show("Modification de données?", "Modifier table de voitures", msgBu);
                            if (rs == DialogResult.Yes)
                            {
                                if (marque.CompareTo("") != 0)
                                {
                                    req = "UPDATE Voiture SET  marque ='" + marque + "' WHERE id =" + id;
                                    cmd = new SqlCommand(req, cn);
                                    cmd.ExecuteNonQuery();

                                }
                                if (modele.CompareTo("") != 0)
                                {
                                    req = "UPDATE Voiture SET  modele ='" + modele + "' WHERE id =" + id;
                                    cmd = new SqlCommand(req, cn);
                                    cmd.ExecuteNonQuery();
                                }
                                if (annee != 0)
                                {
                                    req = "UPDATE Voiture SET annee ='" + annee + "' WHERE id =" + id;
                                    cmd = new SqlCommand(req, cn);
                                    cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Marque modifiée!");
                                cn.Close();

                            }
                            else
                            {
                                this.Close();

                            }
                        }
                    }
                }

                }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
