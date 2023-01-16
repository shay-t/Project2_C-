
namespace ParkMe
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.test = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataSet1 = new ParkMe.DataSet1();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new ParkMe.DataSet1TableAdapters.VilleTableAdapter();
            this.tableAdapterManager = new ParkMe.DataSet1TableAdapters.TableAdapterManager();
            this.parkingTableAdapter = new ParkMe.DataSet1TableAdapters.ParkingTableAdapter();
            this.placeTableAdapter = new ParkMe.DataSet1TableAdapters.PlaceTableAdapter();
            this.Ville = new MetroFramework.Controls.MetroComboBox();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Parking = new MetroFramework.Controls.MetroComboBox();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Place = new MetroFramework.Controls.MetroComboBox();
            this.statutTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Date = new MetroFramework.Controls.MetroDateTime();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.test.Location = new System.Drawing.Point(-22, 64);
            this.test.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 0);
            this.test.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(508, 420);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(56, 37);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Fermer";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(28, 110);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Choisir une ville";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 187);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Choisir parking";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(28, 271);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Choisir place";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "Ville";
            this.villeBindingSource.DataSource = this.dataSet1;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConducteurTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = this.parkingTableAdapter;
            this.tableAdapterManager.PlaceTableAdapter = this.placeTableAdapter;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkMe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VilleTableAdapter = this.villeTableAdapter;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // Ville
            // 
            this.Ville.DataSource = this.villeBindingSource;
            this.Ville.DisplayMember = "Nom";
            this.Ville.FormattingEnabled = true;
            this.Ville.ItemHeight = 23;
            this.Ville.Location = new System.Drawing.Point(194, 110);
            this.Ville.Margin = new System.Windows.Forms.Padding(2);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(226, 29);
            this.Ville.TabIndex = 8;
            this.Ville.UseSelectable = true;
            this.Ville.ValueMember = "Nom";
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Ville_Parking";
            this.parkingBindingSource.DataSource = this.villeBindingSource;
            // 
            // Parking
            // 
            this.Parking.DataSource = this.parkingBindingSource;
            this.Parking.DisplayMember = "Numero";
            this.Parking.FormattingEnabled = true;
            this.Parking.ItemHeight = 23;
            this.Parking.Location = new System.Drawing.Point(194, 187);
            this.Parking.Margin = new System.Windows.Forms.Padding(2);
            this.Parking.Name = "Parking";
            this.Parking.Size = new System.Drawing.Size(226, 29);
            this.Parking.TabIndex = 8;
            this.Parking.UseSelectable = true;
            this.Parking.ValueMember = "Numero";
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Parking_Place";
            this.placeBindingSource.DataSource = this.parkingBindingSource;
            // 
            // Place
            // 
            this.Place.DataSource = this.placeBindingSource;
            this.Place.DisplayMember = "Id";
            this.Place.FormattingEnabled = true;
            this.Place.ItemHeight = 23;
            this.Place.Location = new System.Drawing.Point(194, 271);
            this.Place.Margin = new System.Windows.Forms.Padding(2);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(226, 29);
            this.Place.TabIndex = 8;
            this.Place.UseSelectable = true;
            this.Place.ValueMember = "Id";
            // 
            // statutTextBox
            // 
            this.statutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placeBindingSource, "Statut", true));
            this.statutTextBox.Location = new System.Drawing.Point(423, 271);
            this.statutTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statutTextBox.Multiline = true;
            this.statutTextBox.Name = "statutTextBox";
            this.statutTextBox.ReadOnly = true;
            this.statutTextBox.Size = new System.Drawing.Size(76, 29);
            this.statutTextBox.TabIndex = 9;
            this.statutTextBox.TextChanged += new System.EventHandler(this.statutTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 331);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 22, 23, 35, 0, 0);
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(28, 335);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(175, 25);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Choisir date et heure";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(207, 331);
            this.Date.Margin = new System.Windows.Forms.Padding(2);
            this.Date.MaxDate = new System.DateTime(2100, 1, 25, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            this.Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(162, 29);
            this.Date.TabIndex = 12;
            this.Date.Value = new System.DateTime(2022, 6, 24, 23, 59, 59, 0);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(28, 420);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(173, 37);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Reserver";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(218, 420);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(173, 37);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Afficher reservations";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 531);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statutTextBox);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Parking);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.test);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel test;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private DataSet1TableAdapters.VilleTableAdapter villeTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroComboBox Ville;
        private DataSet1TableAdapters.ParkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private MetroFramework.Controls.MetroComboBox Parking;
        private DataSet1TableAdapters.PlaceTableAdapter placeTableAdapter;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private MetroFramework.Controls.MetroComboBox Place;
        private System.Windows.Forms.TextBox statutTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime Date;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}