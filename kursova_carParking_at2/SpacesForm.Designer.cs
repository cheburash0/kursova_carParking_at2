namespace kursova_carParking_at2
{
    partial class SpacesForm
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
            this.spacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.spacesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_deleteSpaces = new System.Windows.Forms.Button();
            this.button_editSpaces = new System.Windows.Forms.Button();
            this.button_addSpaces = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_spacesSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_spacesFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_spacesSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Паркувальні місця";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spacesBindingSource
            // 
            this.spacesBindingSource.DataMember = "Spaces";
            this.spacesBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // spacesTableAdapter
            // 
            this.spacesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventLogTableAdapter = null;
            this.tableAdapterManager.ParkingSummaryTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.SpacesTableAdapter = this.spacesTableAdapter;
            this.tableAdapterManager.TariffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // spacesDataGridView
            // 
            this.spacesDataGridView.AutoGenerateColumns = false;
            this.spacesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spacesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.spacesDataGridView.DataSource = this.spacesBindingSource;
            this.spacesDataGridView.Location = new System.Drawing.Point(12, 174);
            this.spacesDataGridView.Name = "spacesDataGridView";
            this.spacesDataGridView.RowHeadersWidth = 51;
            this.spacesDataGridView.RowTemplate.Height = 24;
            this.spacesDataGridView.Size = new System.Drawing.Size(776, 149);
            this.spacesDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "space_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "space_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "space_status";
            this.dataGridViewTextBoxColumn2.HeaderText = "space_status";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price_per_hour";
            this.dataGridViewTextBoxColumn3.HeaderText = "price_per_hour";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn4.HeaderText = "location";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tariff_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "tariff_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // button_deleteSpaces
            // 
            this.button_deleteSpaces.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deleteSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteSpaces.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteSpaces.Location = new System.Drawing.Point(433, 363);
            this.button_deleteSpaces.Name = "button_deleteSpaces";
            this.button_deleteSpaces.Size = new System.Drawing.Size(158, 75);
            this.button_deleteSpaces.TabIndex = 16;
            this.button_deleteSpaces.Text = "Видалити";
            this.button_deleteSpaces.UseVisualStyleBackColor = false;
            this.button_deleteSpaces.Click += new System.EventHandler(this.button_deleteSpaces_Click);
            // 
            // button_editSpaces
            // 
            this.button_editSpaces.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editSpaces.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editSpaces.Location = new System.Drawing.Point(226, 363);
            this.button_editSpaces.Name = "button_editSpaces";
            this.button_editSpaces.Size = new System.Drawing.Size(158, 75);
            this.button_editSpaces.TabIndex = 15;
            this.button_editSpaces.Text = "Редагувати";
            this.button_editSpaces.UseVisualStyleBackColor = false;
            this.button_editSpaces.Click += new System.EventHandler(this.button_editSpaces_Click);
            // 
            // button_addSpaces
            // 
            this.button_addSpaces.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addSpaces.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addSpaces.Location = new System.Drawing.Point(16, 363);
            this.button_addSpaces.Name = "button_addSpaces";
            this.button_addSpaces.Size = new System.Drawing.Size(158, 75);
            this.button_addSpaces.TabIndex = 14;
            this.button_addSpaces.Text = "Додати";
            this.button_addSpaces.UseVisualStyleBackColor = false;
            this.button_addSpaces.Click += new System.EventHandler(this.button_addSpaces_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(297, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Сортування";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_spacesSort
            // 
            this.comboBox_spacesSort.FormattingEnabled = true;
            this.comboBox_spacesSort.Items.AddRange(new object[] {
            "Без сортування",
            "Ціна (за зростанням)",
            "Ціна (за спаданням)"});
            this.comboBox_spacesSort.Location = new System.Drawing.Point(304, 106);
            this.comboBox_spacesSort.Name = "comboBox_spacesSort";
            this.comboBox_spacesSort.Size = new System.Drawing.Size(198, 24);
            this.comboBox_spacesSort.TabIndex = 25;
            this.comboBox_spacesSort.SelectedIndexChanged += new System.EventHandler(this.comboBox_spacesSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(558, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фільтр";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_spacesFilter
            // 
            this.comboBox_spacesFilter.FormattingEnabled = true;
            this.comboBox_spacesFilter.Items.AddRange(new object[] {
            "Без фільтру",
            "Місце біля шлагбауму",
            "Центральна частина",
            "Східна частина",
            "Західна частина"});
            this.comboBox_spacesFilter.Location = new System.Drawing.Point(565, 106);
            this.comboBox_spacesFilter.Name = "comboBox_spacesFilter";
            this.comboBox_spacesFilter.Size = new System.Drawing.Size(198, 24);
            this.comboBox_spacesFilter.TabIndex = 27;
            this.comboBox_spacesFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox_spacesFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Пошук";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_spacesSearch
            // 
            this.textBox_spacesSearch.Location = new System.Drawing.Point(19, 107);
            this.textBox_spacesSearch.Name = "textBox_spacesSearch";
            this.textBox_spacesSearch.Size = new System.Drawing.Size(174, 22);
            this.textBox_spacesSearch.TabIndex = 29;
            this.textBox_spacesSearch.TextChanged += new System.EventHandler(this.textBox_spacesSearch_TextChanged);
            // 
            // SpacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_spacesSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_spacesFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_spacesSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_deleteSpaces);
            this.Controls.Add(this.button_editSpaces);
            this.Controls.Add(this.button_addSpaces);
            this.Controls.Add(this.spacesDataGridView);
            this.Controls.Add(this.label2);
            this.Name = "SpacesForm";
            this.Text = "SpacesForm";
            this.Load += new System.EventHandler(this.SpacesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource spacesBindingSource;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spacesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button_deleteSpaces;
        private System.Windows.Forms.Button button_editSpaces;
        private System.Windows.Forms.Button button_addSpaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_spacesSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_spacesFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_spacesSearch;
    }
}