namespace kursova_carParking_at2
{
    partial class editParkingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_parkingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_spaceID = new System.Windows.Forms.TextBox();
            this.textBox_vehicleID = new System.Windows.Forms.TextBox();
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.textBox_startTime = new System.Windows.Forms.TextBox();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.textBox_endTime = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.parkingTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.ParkingTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.dataGridView_aboutSpaces = new System.Windows.Forms.DataGridView();
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aboutSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер паркування";
            // 
            // textBox_parkingID
            // 
            this.textBox_parkingID.Location = new System.Drawing.Point(299, 35);
            this.textBox_parkingID.Name = "textBox_parkingID";
            this.textBox_parkingID.Size = new System.Drawing.Size(179, 22);
            this.textBox_parkingID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер місця";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер т/з";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата початку паркування";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата кінця паркування";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Час початку паркування";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Час кінця паркування";
            // 
            // textBox_spaceID
            // 
            this.textBox_spaceID.Location = new System.Drawing.Point(299, 86);
            this.textBox_spaceID.Name = "textBox_spaceID";
            this.textBox_spaceID.Size = new System.Drawing.Size(179, 22);
            this.textBox_spaceID.TabIndex = 14;
            // 
            // textBox_vehicleID
            // 
            this.textBox_vehicleID.Location = new System.Drawing.Point(299, 132);
            this.textBox_vehicleID.Name = "textBox_vehicleID";
            this.textBox_vehicleID.Size = new System.Drawing.Size(179, 22);
            this.textBox_vehicleID.TabIndex = 15;
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(299, 182);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.Size = new System.Drawing.Size(179, 22);
            this.textBox_startDate.TabIndex = 16;
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Location = new System.Drawing.Point(299, 230);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.Size = new System.Drawing.Size(179, 22);
            this.textBox_startTime.TabIndex = 17;
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(299, 274);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.Size = new System.Drawing.Size(179, 22);
            this.textBox_endDate.TabIndex = 18;
            // 
            // textBox_endTime
            // 
            this.textBox_endTime.Location = new System.Drawing.Point(299, 323);
            this.textBox_endTime.Name = "textBox_endTime";
            this.textBox_endTime.Size = new System.Drawing.Size(179, 22);
            this.textBox_endTime.TabIndex = 19;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(498, 132);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 21;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(498, 35);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 20;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.kursova_carParkingDataSet;
            this.bindingSource1.Position = 0;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_aboutSpaces
            // 
            this.dataGridView_aboutSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aboutSpaces.Location = new System.Drawing.Point(26, 361);
            this.dataGridView_aboutSpaces.Name = "dataGridView_aboutSpaces";
            this.dataGridView_aboutSpaces.RowHeadersWidth = 51;
            this.dataGridView_aboutSpaces.RowTemplate.Height = 24;
            this.dataGridView_aboutSpaces.Size = new System.Drawing.Size(630, 150);
            this.dataGridView_aboutSpaces.TabIndex = 22;
            this.dataGridView_aboutSpaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_aboutSpaces_CellContentClick);
            // 
            // spacesTableAdapter
            // 
            this.spacesTableAdapter.ClearBeforeFill = true;
            // 
            // editParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(668, 523);
            this.Controls.Add(this.dataGridView_aboutSpaces);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_endTime);
            this.Controls.Add(this.textBox_endDate);
            this.Controls.Add(this.textBox_startTime);
            this.Controls.Add(this.textBox_startDate);
            this.Controls.Add(this.textBox_vehicleID);
            this.Controls.Add(this.textBox_spaceID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_parkingID);
            this.Name = "editParkingForm";
            this.Text = "editParkingForm";
            this.Load += new System.EventHandler(this.editParkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aboutSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_parkingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_spaceID;
        private System.Windows.Forms.TextBox textBox_vehicleID;
        private System.Windows.Forms.TextBox textBox_startDate;
        private System.Windows.Forms.TextBox textBox_startTime;
        private System.Windows.Forms.TextBox textBox_endDate;
        private System.Windows.Forms.TextBox textBox_endTime;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private kursova_carParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.DataGridView dataGridView_aboutSpaces;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
    }
}