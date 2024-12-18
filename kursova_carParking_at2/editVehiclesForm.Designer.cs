namespace kursova_carParking_at2
{
    partial class editVehiclesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_clientID = new System.Windows.Forms.TextBox();
            this.textBox_vehicleID = new System.Windows.Forms.TextBox();
            this.textBox_licencePlate = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.comboBox_vehicleType = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridView_aboutVehicles = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.vehiclesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.VehiclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aboutVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер т/з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер клієнта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номерий знак";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Марка та модель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Колір";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип т/з";
            // 
            // textBox_clientID
            // 
            this.textBox_clientID.Location = new System.Drawing.Point(209, 83);
            this.textBox_clientID.Name = "textBox_clientID";
            this.textBox_clientID.Size = new System.Drawing.Size(179, 22);
            this.textBox_clientID.TabIndex = 6;
            // 
            // textBox_vehicleID
            // 
            this.textBox_vehicleID.Location = new System.Drawing.Point(209, 36);
            this.textBox_vehicleID.Name = "textBox_vehicleID";
            this.textBox_vehicleID.Size = new System.Drawing.Size(179, 22);
            this.textBox_vehicleID.TabIndex = 7;
            // 
            // textBox_licencePlate
            // 
            this.textBox_licencePlate.Location = new System.Drawing.Point(209, 131);
            this.textBox_licencePlate.Name = "textBox_licencePlate";
            this.textBox_licencePlate.Size = new System.Drawing.Size(179, 22);
            this.textBox_licencePlate.TabIndex = 8;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(209, 177);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(179, 22);
            this.textBox_model.TabIndex = 9;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(209, 222);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(179, 22);
            this.textBox_color.TabIndex = 10;
            // 
            // comboBox_vehicleType
            // 
            this.comboBox_vehicleType.FormattingEnabled = true;
            this.comboBox_vehicleType.Items.AddRange(new object[] {
            "легковий ",
            "вантажний",
            "мотоцикл"});
            this.comboBox_vehicleType.Location = new System.Drawing.Point(209, 266);
            this.comboBox_vehicleType.Name = "comboBox_vehicleType";
            this.comboBox_vehicleType.Size = new System.Drawing.Size(179, 24);
            this.comboBox_vehicleType.TabIndex = 11;
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(441, 36);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 12;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(441, 131);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dataGridView_aboutVehicles
            // 
            this.dataGridView_aboutVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_aboutVehicles.Location = new System.Drawing.Point(12, 326);
            this.dataGridView_aboutVehicles.Name = "dataGridView_aboutVehicles";
            this.dataGridView_aboutVehicles.RowHeadersWidth = 51;
            this.dataGridView_aboutVehicles.RowTemplate.Height = 24;
            this.dataGridView_aboutVehicles.Size = new System.Drawing.Size(601, 182);
            this.dataGridView_aboutVehicles.TabIndex = 14;
            this.dataGridView_aboutVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_aboutVehicles_CellContentClick);
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
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // editVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(625, 520);
            this.Controls.Add(this.dataGridView_aboutVehicles);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_vehicleType);
            this.Controls.Add(this.textBox_color);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_licencePlate);
            this.Controls.Add(this.textBox_vehicleID);
            this.Controls.Add(this.textBox_clientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editVehiclesForm";
            this.Text = "editVehiclesForm";
            this.Load += new System.EventHandler(this.editVehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_aboutVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_clientID;
        private System.Windows.Forms.TextBox textBox_vehicleID;
        private System.Windows.Forms.TextBox textBox_licencePlate;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.ComboBox comboBox_vehicleType;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridView_aboutVehicles;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private kursova_carParkingDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
    }
}