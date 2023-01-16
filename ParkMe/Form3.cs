using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        Form1 form1 = new Form1();
        int ID = Convert.ToInt32(Form1.dr["id"]);
        
        
        public Form3()
        {
            InitializeComponent();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void villeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.villeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Place'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.placeTableAdapter.Fill(this.dataSet1.Place);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Parking'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parkingTableAdapter.Fill(this.dataSet1.Parking);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.Ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.dataSet1.Ville);

        }

        

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm";
        }



        private void CheckRes(int i,int j)
        {
                
            Thread.Sleep(5000);

            con2.Open();
            SqlCommand cmdi = con2.CreateCommand();
            cmdi.CommandText = "select Paye from [Reservation] where Id = '" + i +"'";
            string payement = cmdi.ExecuteScalar().ToString();
            if (payement != "paye")
            {
                SqlCommand cmd4 = con2.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update [Place] set Statut = '1' where Id = '" + j + "' ";
                cmd4.ExecuteNonQuery();
                SqlCommand cmd5 = con2.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update [Reservation] set Paye = 'reservation annulé' where Id = '" + i + "' ";
                cmd5.ExecuteNonQuery();
            }
            con2.Close();
        }

        private void upplace(int i,double t)
        {
            Thread.Sleep((int)t);
            con2.Open();
            SqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update [Place] set Statut = '0' where Id = '" + i + "' ";
            cmd2.ExecuteNonQuery();
            con2.Close();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            string ville = Ville.Text;
            int parking = Convert.ToInt32(Parking.Text);
            int place = Convert.ToInt32(Place.Text);
            string date = Date.Value.ToShortDateString() + " " + dateTimePicker1.Value.ToShortTimeString();
            DateTime dd = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm", null);
            double Diff_dates = dd.Subtract(DateTime.Now).TotalMilliseconds;
            //MessageBox.Show(Diff_dates.TotalMilliseconds.ToString());
            if (statutTextBox.Text == "1")
            {

                con2.Open();
                SqlCommand cmd = con2.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Reservation] values ('" + ID + "' , '" + parking + "' , '" + date + "' , '" + place + "' , 'Non Paye' )";
                cmd.ExecuteNonQuery();
                /*SqlCommand cmd2 = con2.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update [Place] set Statut = '0' where Id = '" + place + "' ";
                cmd2.ExecuteNonQuery();*/
                MessageBox.Show("Reservation effectue avec succes !");
                SqlCommand cmd3 = con2.CreateCommand();
                cmd3.CommandText = "select Id from [Reservation] where Id_conducteur = '" + ID + "' and Date_reservation = '"+date+"'";
                int idr=Convert.ToInt32(cmd3.ExecuteScalar()); 
                con2.Close();
                Thread thread = new Thread(() => CheckRes(idr, place));
                Thread ThreadObject1 = thread;
                ThreadObject1.Start();
                Thread thread2 = new Thread(() => upplace(place,Diff_dates));
                Thread ThreadObject2 = thread2;
                ThreadObject2.Start();

            }
            else {
                MessageBox.Show("Place déjà réservé !");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Hide();
        }

        private void statutTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
