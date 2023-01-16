using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ParkMe
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string Nom = nom.Text;
            string Prenom = prenom.Text;
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(email.Text)) {
                MessageBox.Show("Veuillez verifier votre email !");
            }
            string Email = email.Text;
            string Mdp = mdp.Text;
            string Confmdp = confmdp.Text;
            if (!Equals(Mdp,Confmdp)) {
                MessageBox.Show("Veuillez verifier votre mot de passe !");
            }
            Regex pattern = new Regex("^[0-9]{16}$");
            if (!pattern.IsMatch(numcarte.Text)) {
                MessageBox.Show("Veuillez verifier votre numero de carte bancaire!");
            }
            Double Numcarte = Convert.ToDouble(numcarte.Text);
            Regex pattern2 = new Regex("^[0-9]{3}$");
            if (!pattern2.IsMatch(ccv.Text)) {
                MessageBox.Show("Veuillez verifier votre CCV !");
            }

            Double Ccv = Convert.ToDouble(ccv.Text);
            string Date = date.Value.ToShortDateString();
            if (Nom == "" || Prenom == "" || Email == "" || Mdp == "" || Confmdp == "")
            {
                MessageBox.Show("Veuillez remplir les champs !");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Conducteur] values ('"+Nom+"' , '"+Prenom+"' , '"+Email+"' , '"+Mdp+"' , '"+Convert.ToInt64(numcarte.Text)+ "' , '"+Ccv+"' , '"+Date+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Compte cree avec succes !");
            }

            
        }

        private void numcarte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void ccv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
