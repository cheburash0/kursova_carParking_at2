namespace kursova_carParking_at2
{
    partial class editEventLogForm
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
            this.textBox_logID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_logType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_logDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_logDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_clientID = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.eventLogTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.EventLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_logID
            // 
            this.textBox_logID.Location = new System.Drawing.Point(224, 37);
            this.textBox_logID.Name = "textBox_logID";
            this.textBox_logID.Size = new System.Drawing.Size(265, 22);
            this.textBox_logID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер події";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тип події";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата події";
            // 
            // comboBox_logType
            // 
            this.comboBox_logType.FormattingEnabled = true;
            this.comboBox_logType.Items.AddRange(new object[] {
            "Заїзд",
            "Оплата",
            "Виїзд"});
            this.comboBox_logType.Location = new System.Drawing.Point(224, 82);
            this.comboBox_logType.Name = "comboBox_logType";
            this.comboBox_logType.Size = new System.Drawing.Size(265, 24);
            this.comboBox_logType.TabIndex = 22;
            // 
            // dateTimePicker_logDate
            // 
            this.dateTimePicker_logDate.Location = new System.Drawing.Point(224, 136);
            this.dateTimePicker_logDate.Name = "dateTimePicker_logDate";
            this.dateTimePicker_logDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_logDate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Опис події";
            // 
            // textBox_logDescription
            // 
            this.textBox_logDescription.Location = new System.Drawing.Point(224, 187);
            this.textBox_logDescription.Name = "textBox_logDescription";
            this.textBox_logDescription.Size = new System.Drawing.Size(265, 22);
            this.textBox_logDescription.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Номер клієнта";
            // 
            // textBox_clientID
            // 
            this.textBox_clientID.Location = new System.Drawing.Point(224, 241);
            this.textBox_clientID.Name = "textBox_clientID";
            this.textBox_clientID.Size = new System.Drawing.Size(265, 22);
            this.textBox_clientID.TabIndex = 27;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(282, 320);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 29;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(65, 320);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 28;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
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
            // eventLogTableAdapter
            // 
            this.eventLogTableAdapter.ClearBeforeFill = true;
            // 
            // editEventLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_clientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_logDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_logDate);
            this.Controls.Add(this.comboBox_logType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_logID);
            this.Controls.Add(this.label1);
            this.Name = "editEventLogForm";
            this.Text = "editEventLogForm";
            this.Load += new System.EventHandler(this.editEventLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_logID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_logType;
        private System.Windows.Forms.DateTimePicker dateTimePicker_logDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_logDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_clientID;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private kursova_carParkingDataSetTableAdapters.EventLogTableAdapter eventLogTableAdapter;
    }
}