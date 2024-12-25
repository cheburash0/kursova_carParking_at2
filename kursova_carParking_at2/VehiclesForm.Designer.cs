namespace kursova_carParking_at2
{
    partial class VehiclesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.button_addVehicles = new System.Windows.Forms.Button();
            this.button_editVehicles = new System.Windows.Forms.Button();
            this.button_deleteVehicles = new System.Windows.Forms.Button();
            this.vehiclesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vehiclesSearch = new System.Windows.Forms.TextBox();
            this.checkBox_vehiclesType1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_vehiclesType2 = new System.Windows.Forms.CheckBox();
            this.checkBox_vehiclesType3 = new System.Windows.Forms.CheckBox();
            this.comboBox_vehiclesSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVehiclesByClients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Транспортні засоби";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.AutoGenerateColumns = false;
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vehiclesDataGridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(12, 175);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.RowHeadersWidth = 51;
            this.vehiclesDataGridView.RowTemplate.Height = 24;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(804, 169);
            this.vehiclesDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vehicle_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "vehicle_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "client_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "client_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "licence_plate";
            this.dataGridViewTextBoxColumn3.HeaderText = "licence_plate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn4.HeaderText = "model";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "color";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "vehicle_type";
            this.dataGridViewTextBoxColumn6.HeaderText = "vehicle_type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_addVehicles
            // 
            this.button_addVehicles.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addVehicles.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addVehicles.Location = new System.Drawing.Point(12, 363);
            this.button_addVehicles.Name = "button_addVehicles";
            this.button_addVehicles.Size = new System.Drawing.Size(158, 75);
            this.button_addVehicles.TabIndex = 11;
            this.button_addVehicles.Text = "Додати";
            this.button_addVehicles.UseVisualStyleBackColor = false;
            this.button_addVehicles.Click += new System.EventHandler(this.button_addVehicles_Click);
            // 
            // button_editVehicles
            // 
            this.button_editVehicles.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editVehicles.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editVehicles.Location = new System.Drawing.Point(222, 363);
            this.button_editVehicles.Name = "button_editVehicles";
            this.button_editVehicles.Size = new System.Drawing.Size(158, 75);
            this.button_editVehicles.TabIndex = 12;
            this.button_editVehicles.Text = "Редагувати";
            this.button_editVehicles.UseVisualStyleBackColor = false;
            this.button_editVehicles.Click += new System.EventHandler(this.button_editVehicles_Click);
            // 
            // button_deleteVehicles
            // 
            this.button_deleteVehicles.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deleteVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteVehicles.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteVehicles.Location = new System.Drawing.Point(429, 363);
            this.button_deleteVehicles.Name = "button_deleteVehicles";
            this.button_deleteVehicles.Size = new System.Drawing.Size(158, 75);
            this.button_deleteVehicles.TabIndex = 13;
            this.button_deleteVehicles.Text = "Видалити";
            this.button_deleteVehicles.UseVisualStyleBackColor = false;
            this.button_deleteVehicles.Click += new System.EventHandler(this.button_deleteVehicles_Click);
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventLogTableAdapter = null;
            this.tableAdapterManager.ParkingSummaryTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.SpacesTableAdapter = null;
            this.tableAdapterManager.TariffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Пошук";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_vehiclesSearch
            // 
            this.textBox_vehiclesSearch.Location = new System.Drawing.Point(19, 105);
            this.textBox_vehiclesSearch.Multiline = true;
            this.textBox_vehiclesSearch.Name = "textBox_vehiclesSearch";
            this.textBox_vehiclesSearch.Size = new System.Drawing.Size(120, 24);
            this.textBox_vehiclesSearch.TabIndex = 15;
            this.textBox_vehiclesSearch.TextChanged += new System.EventHandler(this.textBox_vehiclesSearch_TextChanged);
            // 
            // checkBox_vehiclesType1
            // 
            this.checkBox_vehiclesType1.AutoSize = true;
            this.checkBox_vehiclesType1.Location = new System.Drawing.Point(500, 105);
            this.checkBox_vehiclesType1.Name = "checkBox_vehiclesType1";
            this.checkBox_vehiclesType1.Size = new System.Drawing.Size(90, 20);
            this.checkBox_vehiclesType1.TabIndex = 17;
            this.checkBox_vehiclesType1.Text = "легковий";
            this.checkBox_vehiclesType1.UseVisualStyleBackColor = true;
            this.checkBox_vehiclesType1.CheckedChanged += new System.EventHandler(this.checkBox_vehiclesType1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(493, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Фільтр";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_vehiclesType2
            // 
            this.checkBox_vehiclesType2.AutoSize = true;
            this.checkBox_vehiclesType2.Location = new System.Drawing.Point(500, 131);
            this.checkBox_vehiclesType2.Name = "checkBox_vehiclesType2";
            this.checkBox_vehiclesType2.Size = new System.Drawing.Size(101, 20);
            this.checkBox_vehiclesType2.TabIndex = 18;
            this.checkBox_vehiclesType2.Text = "вантажний";
            this.checkBox_vehiclesType2.UseVisualStyleBackColor = true;
            this.checkBox_vehiclesType2.CheckedChanged += new System.EventHandler(this.checkBox_vehiclesType2_CheckedChanged);
            // 
            // checkBox_vehiclesType3
            // 
            this.checkBox_vehiclesType3.AutoSize = true;
            this.checkBox_vehiclesType3.Location = new System.Drawing.Point(596, 105);
            this.checkBox_vehiclesType3.Name = "checkBox_vehiclesType3";
            this.checkBox_vehiclesType3.Size = new System.Drawing.Size(92, 20);
            this.checkBox_vehiclesType3.TabIndex = 19;
            this.checkBox_vehiclesType3.Text = "мотоцикл";
            this.checkBox_vehiclesType3.UseVisualStyleBackColor = true;
            this.checkBox_vehiclesType3.CheckedChanged += new System.EventHandler(this.checkBox_vehiclesType3_CheckedChanged);
            // 
            // comboBox_vehiclesSort
            // 
            this.comboBox_vehiclesSort.FormattingEnabled = true;
            this.comboBox_vehiclesSort.Items.AddRange(new object[] {
            "Без сортування",
            "Назва (А-Я)",
            "Назва (Я-А)"});
            this.comboBox_vehiclesSort.Location = new System.Drawing.Point(222, 105);
            this.comboBox_vehiclesSort.Name = "comboBox_vehiclesSort";
            this.comboBox_vehiclesSort.Size = new System.Drawing.Size(198, 24);
            this.comboBox_vehiclesSort.TabIndex = 21;
            this.comboBox_vehiclesSort.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientsSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Сортування";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(616, 38);
            this.label5.TabIndex = 22;
            this.label5.Text = "Звіт \"Транспортні засоби по клієнтам\"";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVehiclesByClients
            // 
            this.buttonVehiclesByClients.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonVehiclesByClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVehiclesByClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVehiclesByClients.Location = new System.Drawing.Point(658, 455);
            this.buttonVehiclesByClients.Name = "buttonVehiclesByClients";
            this.buttonVehiclesByClients.Size = new System.Drawing.Size(158, 75);
            this.buttonVehiclesByClients.TabIndex = 23;
            this.buttonVehiclesByClients.Text = "Друк звіту";
            this.buttonVehiclesByClients.UseVisualStyleBackColor = false;
            this.buttonVehiclesByClients.Click += new System.EventHandler(this.buttonVehiclesByClients_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(829, 540);
            this.Controls.Add(this.buttonVehiclesByClients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_vehiclesSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_vehiclesType3);
            this.Controls.Add(this.checkBox_vehiclesType2);
            this.Controls.Add(this.checkBox_vehiclesType1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_vehiclesSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_deleteVehicles);
            this.Controls.Add(this.button_editVehicles);
            this.Controls.Add(this.button_addVehicles);
            this.Controls.Add(this.vehiclesDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private kursova_carParkingDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_addVehicles;
        private System.Windows.Forms.Button button_editVehicles;
        private System.Windows.Forms.Button button_deleteVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vehiclesSearch;
        private System.Windows.Forms.CheckBox checkBox_vehiclesType1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_vehiclesType2;
        private System.Windows.Forms.CheckBox checkBox_vehiclesType3;
        private System.Windows.Forms.ComboBox comboBox_vehiclesSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVehiclesByClients;
    }
}