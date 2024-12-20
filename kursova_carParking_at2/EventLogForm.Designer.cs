﻿namespace kursova_carParking_at2
{
    partial class EventLogForm
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
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.eventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLogTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.EventLogTableAdapter();
            this.tableAdapterManager = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager();
            this.eventLogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button_deleteLog = new System.Windows.Forms.Button();
            this.button_editLog = new System.Windows.Forms.Button();
            this.button_addLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kursova_carParkingDataSet
            // 
            this.kursova_carParkingDataSet.DataSetName = "kursova_carParkingDataSet";
            this.kursova_carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventLogBindingSource
            // 
            this.eventLogBindingSource.DataMember = "EventLog";
            this.eventLogBindingSource.DataSource = this.kursova_carParkingDataSet;
            // 
            // eventLogTableAdapter
            // 
            this.eventLogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventLogTableAdapter = this.eventLogTableAdapter;
            this.tableAdapterManager.ParkingSummaryTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.SpacesTableAdapter = null;
            this.tableAdapterManager.TariffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // eventLogDataGridView
            // 
            this.eventLogDataGridView.AutoGenerateColumns = false;
            this.eventLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eventLogDataGridView.DataSource = this.eventLogBindingSource;
            this.eventLogDataGridView.Location = new System.Drawing.Point(12, 130);
            this.eventLogDataGridView.Name = "eventLogDataGridView";
            this.eventLogDataGridView.RowHeadersWidth = 51;
            this.eventLogDataGridView.RowTemplate.Height = 24;
            this.eventLogDataGridView.Size = new System.Drawing.Size(776, 135);
            this.eventLogDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "log_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "log_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "event_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "event_type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "event_time";
            this.dataGridViewTextBoxColumn3.HeaderText = "event_time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "client_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "client_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Журнал подій";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_deleteLog
            // 
            this.button_deleteLog.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_deleteLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteLog.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteLog.Location = new System.Drawing.Point(630, 294);
            this.button_deleteLog.Name = "button_deleteLog";
            this.button_deleteLog.Size = new System.Drawing.Size(158, 75);
            this.button_deleteLog.TabIndex = 22;
            this.button_deleteLog.Text = "Видалити";
            this.button_deleteLog.UseVisualStyleBackColor = false;
            this.button_deleteLog.Click += new System.EventHandler(this.button_deleteLog_Click);
            // 
            // button_editLog
            // 
            this.button_editLog.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_editLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_editLog.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_editLog.Location = new System.Drawing.Point(321, 294);
            this.button_editLog.Name = "button_editLog";
            this.button_editLog.Size = new System.Drawing.Size(158, 75);
            this.button_editLog.TabIndex = 21;
            this.button_editLog.Text = "Редагувати";
            this.button_editLog.UseVisualStyleBackColor = false;
            this.button_editLog.Click += new System.EventHandler(this.button_editLog_Click);
            // 
            // button_addLog
            // 
            this.button_addLog.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_addLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addLog.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addLog.Location = new System.Drawing.Point(12, 294);
            this.button_addLog.Name = "button_addLog";
            this.button_addLog.Size = new System.Drawing.Size(158, 75);
            this.button_addLog.TabIndex = 20;
            this.button_addLog.Text = "Додати";
            this.button_addLog.UseVisualStyleBackColor = false;
            this.button_addLog.Click += new System.EventHandler(this.button_addTariff_Click);
            // 
            // EventLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.button_deleteLog);
            this.Controls.Add(this.button_editLog);
            this.Controls.Add(this.button_addLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventLogDataGridView);
            this.Name = "EventLogForm";
            this.Text = "EventLogForm";
            this.Load += new System.EventHandler(this.EventLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.BindingSource eventLogBindingSource;
        private kursova_carParkingDataSetTableAdapters.EventLogTableAdapter eventLogTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eventLogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_deleteLog;
        private System.Windows.Forms.Button button_editLog;
        private System.Windows.Forms.Button button_addLog;
    }
}