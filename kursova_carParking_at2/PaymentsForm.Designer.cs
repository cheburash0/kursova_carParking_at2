namespace kursova_carParking_at2
{
    partial class PaymentsForm
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
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.button_deletePayment = new System.Windows.Forms.Button();
            this.button_editPayment = new System.Windows.Forms.Button();
            this.button_addPayment = new System.Windows.Forms.Button();
            this.textBox_paymentsSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_paymentsSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_paymentsFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.parkingTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.ParkingTableAdapter();
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            this.tariffsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TariffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Платежі";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AutoGenerateColumns = false;
            this.paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.paymentsDataGridView.DataSource = this.paymentsBindingSource;
            this.paymentsDataGridView.Location = new System.Drawing.Point(12, 198);
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.RowHeadersWidth = 51;
            this.paymentsDataGridView.RowTemplate.Height = 24;
            this.paymentsDataGridView.Size = new System.Drawing.Size(776, 142);
            this.paymentsDataGridView.TabIndex = 12;
            this.paymentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "payment_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "payment_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "payment_date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "parking_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "parking_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_deletePayment
            // 
            this.button_deletePayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deletePayment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deletePayment.Location = new System.Drawing.Point(528, 363);
            this.button_deletePayment.Name = "button_deletePayment";
            this.button_deletePayment.Size = new System.Drawing.Size(158, 75);
            this.button_deletePayment.TabIndex = 19;
            this.button_deletePayment.Text = "Видалити";
            this.button_deletePayment.UseVisualStyleBackColor = false;
            this.button_deletePayment.Click += new System.EventHandler(this.button_deletePayment_Click);
            // 
            // button_editPayment
            // 
            this.button_editPayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editPayment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editPayment.Location = new System.Drawing.Point(317, 363);
            this.button_editPayment.Name = "button_editPayment";
            this.button_editPayment.Size = new System.Drawing.Size(158, 75);
            this.button_editPayment.TabIndex = 18;
            this.button_editPayment.Text = "Редагувати";
            this.button_editPayment.UseVisualStyleBackColor = false;
            this.button_editPayment.Click += new System.EventHandler(this.button_editPayment_Click);
            // 
            // button_addPayment
            // 
            this.button_addPayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addPayment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addPayment.Location = new System.Drawing.Point(100, 363);
            this.button_addPayment.Name = "button_addPayment";
            this.button_addPayment.Size = new System.Drawing.Size(158, 75);
            this.button_addPayment.TabIndex = 17;
            this.button_addPayment.Text = "Додати";
            this.button_addPayment.UseVisualStyleBackColor = false;
            this.button_addPayment.Click += new System.EventHandler(this.button_addPayment_Click);
            // 
            // textBox_paymentsSearch
            // 
            this.textBox_paymentsSearch.Location = new System.Drawing.Point(19, 106);
            this.textBox_paymentsSearch.Name = "textBox_paymentsSearch";
            this.textBox_paymentsSearch.Size = new System.Drawing.Size(174, 22);
            this.textBox_paymentsSearch.TabIndex = 31;
            this.textBox_paymentsSearch.TextChanged += new System.EventHandler(this.textBox_paymentsSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "Пошук";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_paymentsSort
            // 
            this.comboBox_paymentsSort.FormattingEnabled = true;
            this.comboBox_paymentsSort.Items.AddRange(new object[] {
            "Без сортування",
            "Сума (за зростанням)",
            "Сума (за спаданням)",
            "Дата платежа (зростання)",
            "Дата платежа (спадання)",
            "Номер місця (за зростанням)",
            "Номер місця (за спаданням)"});
            this.comboBox_paymentsSort.Location = new System.Drawing.Point(283, 105);
            this.comboBox_paymentsSort.Name = "comboBox_paymentsSort";
            this.comboBox_paymentsSort.Size = new System.Drawing.Size(198, 24);
            this.comboBox_paymentsSort.TabIndex = 33;
            this.comboBox_paymentsSort.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentsSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(276, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Сортування";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_paymentsFilter
            // 
            this.comboBox_paymentsFilter.FormattingEnabled = true;
            this.comboBox_paymentsFilter.Items.AddRange(new object[] {
            "Без фільтру",
            "Сума > 5000",
            "Сума < 5000",
            "Дата: Останній тиждень"});
            this.comboBox_paymentsFilter.Location = new System.Drawing.Point(571, 105);
            this.comboBox_paymentsFilter.Name = "comboBox_paymentsFilter";
            this.comboBox_paymentsFilter.Size = new System.Drawing.Size(198, 24);
            this.comboBox_paymentsFilter.TabIndex = 35;
            this.comboBox_paymentsFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentsFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(564, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Фільтр";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventLogTableAdapter = null;
            this.tableAdapterManager.ParkingSummaryTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.SpacesTableAdapter = null;
            this.tableAdapterManager.TariffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // spacesTableAdapter
            // 
            this.spacesTableAdapter.ClearBeforeFill = true;
            // 
            // tariffsTableAdapter
            // 
            this.tariffsTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_paymentsFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_paymentsSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_paymentsSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_deletePayment);
            this.Controls.Add(this.button_editPayment);
            this.Controls.Add(this.button_addPayment);
            this.Controls.Add(this.paymentsDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "PaymentsForm";
            this.Text = "PaymentsForm";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_deletePayment;
        private System.Windows.Forms.Button button_editPayment;
        private System.Windows.Forms.Button button_addPayment;
        private System.Windows.Forms.TextBox textBox_paymentsSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_paymentsSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_paymentsFilter;
        private System.Windows.Forms.Label label1;
        private kursova_carParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TariffsTableAdapter tariffsTableAdapter;
    }
}