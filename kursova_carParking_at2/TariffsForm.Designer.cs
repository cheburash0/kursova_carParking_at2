namespace kursova_carParking_at2
{
    partial class TariffsForm
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
            this.tariffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TariffsTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.tariffsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_deleteTariff = new System.Windows.Forms.Button();
            this.button_editTariff = new System.Windows.Forms.Button();
            this.button_addTariff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(297, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тарифи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffsBindingSource
            // 
            this.tariffsBindingSource.DataMember = "Tariffs";
            this.tariffsBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // tariffsTableAdapter
            // 
            this.tariffsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TariffsTableAdapter = this.tariffsTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // tariffsDataGridView
            // 
            this.tariffsDataGridView.AutoGenerateColumns = false;
            this.tariffsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tariffsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tariffsDataGridView.DataSource = this.tariffsBindingSource;
            this.tariffsDataGridView.Location = new System.Drawing.Point(12, 93);
            this.tariffsDataGridView.Name = "tariffsDataGridView";
            this.tariffsDataGridView.RowHeadersWidth = 51;
            this.tariffsDataGridView.RowTemplate.Height = 24;
            this.tariffsDataGridView.Size = new System.Drawing.Size(736, 119);
            this.tariffsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tariff_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "tariff_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "day_coefficient";
            this.dataGridViewTextBoxColumn2.HeaderText = "day_coefficient";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "night_coefficient";
            this.dataGridViewTextBoxColumn3.HeaderText = "night_coefficient";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "month_coefficient";
            this.dataGridViewTextBoxColumn4.HeaderText = "month_coefficient";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button_deleteTariff
            // 
            this.button_deleteTariff.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deleteTariff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteTariff.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteTariff.Location = new System.Drawing.Point(590, 242);
            this.button_deleteTariff.Name = "button_deleteTariff";
            this.button_deleteTariff.Size = new System.Drawing.Size(158, 75);
            this.button_deleteTariff.TabIndex = 19;
            this.button_deleteTariff.Text = "Видалити";
            this.button_deleteTariff.UseVisualStyleBackColor = false;
            this.button_deleteTariff.Click += new System.EventHandler(this.button_deleteTariff_Click);
            // 
            // button_editTariff
            // 
            this.button_editTariff.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editTariff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editTariff.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editTariff.Location = new System.Drawing.Point(304, 242);
            this.button_editTariff.Name = "button_editTariff";
            this.button_editTariff.Size = new System.Drawing.Size(158, 75);
            this.button_editTariff.TabIndex = 18;
            this.button_editTariff.Text = "Редагувати";
            this.button_editTariff.UseVisualStyleBackColor = false;
            this.button_editTariff.Click += new System.EventHandler(this.button_editTariff_Click);
            // 
            // button_addTariff
            // 
            this.button_addTariff.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addTariff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addTariff.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addTariff.Location = new System.Drawing.Point(12, 242);
            this.button_addTariff.Name = "button_addTariff";
            this.button_addTariff.Size = new System.Drawing.Size(158, 75);
            this.button_addTariff.TabIndex = 17;
            this.button_addTariff.Text = "Додати";
            this.button_addTariff.UseVisualStyleBackColor = false;
            this.button_addTariff.Click += new System.EventHandler(this.button_addTariff_Click);
            // 
            // TariffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(763, 345);
            this.Controls.Add(this.button_deleteTariff);
            this.Controls.Add(this.button_editTariff);
            this.Controls.Add(this.button_addTariff);
            this.Controls.Add(this.tariffsDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "TariffsForm";
            this.Text = "TariffsForm";
            this.Load += new System.EventHandler(this.TariffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource tariffsBindingSource;
        private kursova_carParkingDataSetTableAdapters.TariffsTableAdapter tariffsTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tariffsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_deleteTariff;
        private System.Windows.Forms.Button button_editTariff;
        private System.Windows.Forms.Button button_addTariff;
    }
}