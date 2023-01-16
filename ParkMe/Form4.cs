using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        int ID = Convert.ToInt32(Form1.dr["id"]);
        SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        string n_park, id_p, d_res;
        int id_res;
        DataGridViewRow row;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.dataSet1.Reservation);
            con3.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Reservation] where Id_conducteur = '" + ID + "' ", con3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            metroGrid1.Columns[0].Name = "id";
            metroGrid1.Columns[1].Name = "Id_conducteur";
            metroGrid1.Columns[2].Name = "Numero_parking";
            metroGrid1.Columns[3].Name = "Date_reservation";
            metroGrid1.Columns[4].Name = "id_place";
            metroGrid1.Columns[1].Name = "Paye";
            con3.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            con3.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Reservation] where Id_conducteur = '"+ID+"' ",con3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            metroGrid1.Columns[0].Name = "id";
            metroGrid1.Columns[1].Name = "Id_conducteur";
            metroGrid1.Columns[2].Name = "Numero_parking";
            metroGrid1.Columns[3].Name = "Date_reservation";
            metroGrid1.Columns[4].Name = "id_place";
            metroGrid1.Columns[1].Name = "Paye";
            con3.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void upplace(int i, double t)
        {
            Thread.Sleep((int)t);
            con3.Open();
            SqlCommand cmd2 = con3.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update [Place] set Statut = '1' where Id = '" + i + "' ";
            cmd2.ExecuteNonQuery();
            con3.Close();
        }
        private void payer_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            int ttl = (Convert.ToInt32(hstation.Text) * Convert.ToInt32(tarif.Text));
            string rc= "Id user = " + ID.ToString() + " Numero_park = " + n_park + " Id_place" + id_p + "Date Reservation" + d_res + "Prix total ="+ttl.ToString();
            var MyData = QG.CreateQrCode(rc, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            qrcontainer.Image = code.GetGraphic(50);
            //update place statut
            //update res statut
            con3.Open();
            SqlCommand cmd5 = con3.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "update [Reservation] set Paye = 'Paye' where Id = '" + id_res + "' ";
            cmd5.ExecuteNonQuery();
            con3.Close();
            //time
            double duree = Convert.ToDouble(hstation.Text)*3600*1000;
            string date = row.Cells["Date_reservation"].Value.ToString();
            DateTime dd = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm", null);
            double Diff_dates = dd.Subtract(DateTime.Now).TotalMilliseconds;
            double total = Diff_dates + duree;
            Thread thread2 = new Thread(() => upplace(Convert.ToInt32(id_p), Diff_dates));
            Thread ThreadObject2 = thread2;
            ThreadObject2.Start();
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            string dirpth = @"D:\recus\";
            qrcontainer.Image.Save(dirpth+ID.ToString()+"-"+ DateTime.Now.Minute.ToString()+ "-"+DateTime.Now.Second.ToString()+ ".jpg");
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if(SelectedRow != -1)
            {
                row = metroGrid1.Rows[SelectedRow];
                n_park = row.Cells["Numero_parking"].Value.ToString();
                id_p = row.Cells["id_place"].Value.ToString();
                d_res = row.Cells["Date_reservation"].Value.ToString();
                id_res = Convert.ToInt32(row.Cells["Id"].Value);
                DateTime dd = DateTime.ParseExact(d_res, "dd/MM/yyyy HH:mm", null);
                if (dd.Hour.CompareTo(20) >0 || dd.Hour.CompareTo(05)<0)
                {
                    tarif.Text = "15";
                }
                else
                {
                    tarif.Text = "10";
                }
            }
        }
    }
}
