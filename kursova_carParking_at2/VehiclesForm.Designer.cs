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
            this.button_addVehicles = new System.Windows.Forms.Button();
            this.button_editVehicles = new System.Windows.Forms.Button();
            this.button_deleteVehicles = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.vehiclesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
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
            this.vehiclesDataGridView.Location = new System.Drawing.Point(12, 126);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.RowHeadersWidth = 51;
            this.vehiclesDataGridView.RowTemplate.Height = 24;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(804, 169);
            this.vehiclesDataGridView.TabIndex = 10;
            // 
            // button_addVehicles
            // 
            this.button_addVehicles.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addVehicles.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addVehicles.Location = new System.Drawing.Point(12, 321);
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
            this.button_editVehicles.Location = new System.Drawing.Point(208, 321);
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
            this.button_deleteVehicles.Location = new System.Drawing.Point(402, 321);
            this.button_deleteVehicles.Name = "button_deleteVehicles";
            this.button_deleteVehicles.Size = new System.Drawing.Size(158, 75);
            this.button_deleteVehicles.TabIndex = 13;
            this.button_deleteVehicles.Text = "Видалити";
            this.button_deleteVehicles.UseVisualStyleBackColor = false;
            this.button_deleteVehicles.Click += new System.EventHandler(this.button_deleteVehicles_Click);
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
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(829, 450);
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
    }
}