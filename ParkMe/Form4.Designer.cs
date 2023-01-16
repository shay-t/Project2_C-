
namespace ParkMe
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dataSet1 = new ParkMe.DataSet1();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new ParkMe.DataSet1TableAdapters.ReservationTableAdapter();
            this.payer = new MetroFramework.Controls.MetroButton();
            this.qrcontainer = new System.Windows.Forms.PictureBox();
            this.enregistrer = new MetroFramework.Controls.MetroButton();
            this.tableAdapterManager = new ParkMe.DataSet1TableAdapters.TableAdapterManager();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.hstation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabeltarif = new MetroFramework.Controls.MetroLabel();
            this.tarif = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcontainer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(17, 267);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 36);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Actualiser";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(17, 307);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(718, 186);
            this.metroGrid1.TabIndex = 1;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid1_CellMouseClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.dataSet1;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // payer
            // 
            this.payer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.payer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.payer.Location = new System.Drawing.Point(614, 119);
            this.payer.Margin = new System.Windows.Forms.Padding(2);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(121, 36);
            this.payer.TabIndex = 2;
            this.payer.Text = "Payer";
            this.payer.UseSelectable = true;
            this.payer.Click += new System.EventHandler(this.payer_Click);
            // 
            // qrcontainer
            // 
            this.qrcontainer.Location = new System.Drawing.Point(17, 64);
            this.qrcontainer.Name = "qrcontainer";
            this.qrcontainer.Size = new System.Drawing.Size(230, 174);
            this.qrcontainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrcontainer.TabIndex = 3;
            this.qrcontainer.TabStop = false;
            this.qrcontainer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.enregistrer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.enregistrer.Location = new System.Drawing.Point(614, 174);
            this.enregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(121, 36);
            this.enregistrer.TabIndex = 4;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseSelectable = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConducteurTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = this.reservationTableAdapter;
            this.tableAdapterManager.UpdateOrder = ParkMe.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VilleTableAdapter = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(296, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "duree de stationnement";
            // 
            // hstation
            // 
            // 
            // 
            // 
            this.hstation.CustomButton.Image = null;
            this.hstation.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.hstation.CustomButton.Name = "";
            this.hstation.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.hstation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hstation.CustomButton.TabIndex = 1;
            this.hstation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hstation.CustomButton.UseSelectable = true;
            this.hstation.CustomButton.Visible = false;
            this.hstation.Lines = new string[0];
            this.hstation.Location = new System.Drawing.Point(508, 119);
            this.hstation.MaxLength = 32767;
            this.hstation.Name = "hstation";
            this.hstation.PasswordChar = '\0';
            this.hstation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hstation.SelectedText = "";
            this.hstation.SelectionLength = 0;
            this.hstation.SelectionStart = 0;
            this.hstation.ShortcutsEnabled = true;
            this.hstation.Size = new System.Drawing.Size(77, 29);
            this.hstation.TabIndex = 6;
            this.hstation.UseSelectable = true;
            this.hstation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hstation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabeltarif
            // 
            this.metroLabeltarif.AutoSize = true;
            this.metroLabeltarif.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabeltarif.Location = new System.Drawing.Point(296, 60);
            this.metroLabeltarif.Name = "metroLabeltarif";
            this.metroLabeltarif.Size = new System.Drawing.Size(130, 25);
            this.metroLabeltarif.TabIndex = 7;
            this.metroLabeltarif.Text = "tarif reservation";
            this.metroLabeltarif.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // tarif
            // 
            // 
            // 
            // 
            this.tarif.CustomButton.Image = null;
            this.tarif.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.tarif.CustomButton.Name = "";
            this.tarif.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tarif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tarif.CustomButton.TabIndex = 1;
            this.tarif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tarif.CustomButton.UseSelectable = true;
            this.tarif.CustomButton.Visible = false;
            this.tarif.Lines = new string[0];
            this.tarif.Location = new System.Drawing.Point(508, 60);
            this.tarif.MaxLength = 32767;
            this.tarif.Name = "tarif";
            this.tarif.PasswordChar = '\0';
            this.tarif.ReadOnly = true;
            this.tarif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tarif.SelectedText = "";
            this.tarif.SelectionLength = 0;
            this.tarif.SelectionStart = 0;
            this.tarif.ShortcutsEnabled = true;
            this.tarif.Size = new System.Drawing.Size(77, 29);
            this.tarif.TabIndex = 8;
            this.tarif.UseSelectable = true;
            this.tarif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tarif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 538);
            this.Controls.Add(this.tarif);
            this.Controls.Add(this.metroLabeltarif);
            this.Controls.Add(this.hstation);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.qrcontainer);
            this.Controls.Add(this.payer);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Historique de reservations";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcontainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private DataSet1TableAdapters.ReservationTableAdapter reservationTableAdapter;
        private MetroFramework.Controls.MetroButton payer;
        private System.Windows.Forms.PictureBox qrcontainer;
        private MetroFramework.Controls.MetroButton enregistrer;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox hstation;
        private MetroFramework.Controls.MetroLabel metroLabeltarif;
        private MetroFramework.Controls.MetroTextBox tarif;
    }
}