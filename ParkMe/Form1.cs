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

namespace ParkMe

{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public static DataRow dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {           
            string Email = email.Text;
            string Mdp = mdp.Text;
            if (Email == "" || Mdp == "")
            {
                MessageBox.Show("Veuillez remplir les champs !");
            }
            else {
                con1.Open();
                SqlCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from [Conducteur] where Email = '"+Email+"' and Mdp = '"+Mdp+"' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Erreur");
                }
                con1.Close();

                

            }
        }

        
    }
}
