namespace kursova_carParking_at2
{
    partial class ParkingForm
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
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.ParkingTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.parkingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_deleteParking = new System.Windows.Forms.Button();
            this.button_editParking = new System.Windows.Forms.Button();
            this.button_addParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Паркування";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Parking";
            this.parkingBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventLogTableAdapter = null;
            this.tableAdapterManager.ParkingSummaryTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = this.parkingTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.SpacesTableAdapter = null;
            this.tableAdapterManager.TariffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // parkingDataGridView
            // 
            this.parkingDataGridView.AutoGenerateColumns = false;
            this.parkingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parkingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.parkingDataGridView.DataSource = this.parkingBindingSource;
            this.parkingDataGridView.Location = new System.Drawing.Point(12, 80);
            this.parkingDataGridView.Name = "parkingDataGridView";
            this.parkingDataGridView.RowHeadersWidth = 51;
            this.parkingDataGridView.RowTemplate.Height = 24;
            this.parkingDataGridView.Size = new System.Drawing.Size(776, 220);
            this.parkingDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "parking_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "parking_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "space_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "space_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vehicle_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "vehicle_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "start_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "start_time";
            this.dataGridViewTextBoxColumn5.HeaderText = "start_time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "end_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "end_date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "end_time";
            this.dataGridViewTextBoxColumn7.HeaderText = "end_time";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button_deleteParking
            // 
            this.button_deleteParking.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deleteParking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteParking.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteParking.Location = new System.Drawing.Point(433, 330);
            this.button_deleteParking.Name = "button_deleteParking";
            this.button_deleteParking.Size = new System.Drawing.Size(158, 75);
            this.button_deleteParking.TabIndex = 16;
            this.button_deleteParking.Text = "Видалити";
            this.button_deleteParking.UseVisualStyleBackColor = false;
            this.button_deleteParking.Click += new System.EventHandler(this.button_deleteParking_Click);
            // 
            // button_editParking
            // 
            this.button_editParking.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editParking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editParking.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editParking.Location = new System.Drawing.Point(226, 330);
            this.button_editParking.Name = "button_editParking";
            this.button_editParking.Size = new System.Drawing.Size(158, 75);
            this.button_editParking.TabIndex = 15;
            this.button_editParking.Text = "Редагувати";
            this.button_editParking.UseVisualStyleBackColor = false;
            this.button_editParking.Click += new System.EventHandler(this.button_editParking_Click);
            // 
            // button_addParking
            // 
            this.button_addParking.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addParking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addParking.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addParking.Location = new System.Drawing.Point(16, 330);
            this.button_addParking.Name = "button_addParking";
            this.button_addParking.Size = new System.Drawing.Size(158, 75);
            this.button_addParking.TabIndex = 14;
            this.button_addParking.Text = "Додати";
            this.button_addParking.UseVisualStyleBackColor = false;
            this.button_addParking.Click += new System.EventHandler(this.button_addParking_Click);
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deleteParking);
            this.Controls.Add(this.button_editParking);
            this.Controls.Add(this.button_addParking);
            this.Controls.Add(this.parkingDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "ParkingForm";
            this.Text = "ParkingForm";
            this.Load += new System.EventHandler(this.ParkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private kursova_carParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView parkingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_deleteParking;
        private System.Windows.Forms.Button button_editParking;
        private System.Windows.Forms.Button button_addParking;
    }
}