namespace kursova_carParking_at2
{
    partial class editPaymentsForm
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
            this.textBox_paymentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_paymentDate = new System.Windows.Forms.TextBox();
            this.textBox_parkingID = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.paymentsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter();
            this.parkingTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.ParkingTableAdapter();
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            this.tariffsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TariffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_paymentID
            // 
            this.textBox_paymentID.Location = new System.Drawing.Point(224, 43);
            this.textBox_paymentID.Name = "textBox_paymentID";
            this.textBox_paymentID.Size = new System.Drawing.Size(179, 22);
            this.textBox_paymentID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер платежу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сума";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата платежу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Номер паркування";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(224, 95);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(179, 22);
            this.textBox_amount.TabIndex = 21;
            // 
            // textBox_paymentDate
            // 
            this.textBox_paymentDate.Location = new System.Drawing.Point(224, 146);
            this.textBox_paymentDate.Name = "textBox_paymentDate";
            this.textBox_paymentDate.Size = new System.Drawing.Size(179, 22);
            this.textBox_paymentDate.TabIndex = 22;
            // 
            // textBox_parkingID
            // 
            this.textBox_parkingID.Location = new System.Drawing.Point(224, 196);
            this.textBox_parkingID.Name = "textBox_parkingID";
            this.textBox_parkingID.Size = new System.Drawing.Size(179, 22);
            this.textBox_parkingID.TabIndex = 23;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(245, 252);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 27;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(16, 252);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 26;
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
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
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
            // editPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(447, 366);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_parkingID);
            this.Controls.Add(this.textBox_paymentDate);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_paymentID);
            this.Controls.Add(this.label1);
            this.Name = "editPaymentsForm";
            this.Text = "editPaymentsForm";
            this.Load += new System.EventHandler(this.editPaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_paymentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_paymentDate;
        private System.Windows.Forms.TextBox textBox_parkingID;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private kursova_carParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
        private kursova_carParkingDataSetTableAdapters.TariffsTableAdapter tariffsTableAdapter;
    }
}