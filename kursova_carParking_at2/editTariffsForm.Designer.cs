namespace kursova_carParking_at2
{
    partial class editTariffsForm
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
            this.textBox_tariffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dayCoeff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nightCoeff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_monthCoeff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.tariffsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.TariffsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_tariffID
            // 
            this.textBox_tariffID.Location = new System.Drawing.Point(239, 52);
            this.textBox_tariffID.Name = "textBox_tariffID";
            this.textBox_tariffID.Size = new System.Drawing.Size(179, 22);
            this.textBox_tariffID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер тарифу";
            // 
            // textBox_dayCoeff
            // 
            this.textBox_dayCoeff.Location = new System.Drawing.Point(239, 108);
            this.textBox_dayCoeff.Name = "textBox_dayCoeff";
            this.textBox_dayCoeff.Size = new System.Drawing.Size(179, 22);
            this.textBox_dayCoeff.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Денний кеофіцієнт";
            // 
            // textBox_nightCoeff
            // 
            this.textBox_nightCoeff.Location = new System.Drawing.Point(239, 168);
            this.textBox_nightCoeff.Name = "textBox_nightCoeff";
            this.textBox_nightCoeff.Size = new System.Drawing.Size(179, 22);
            this.textBox_nightCoeff.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Нічний коефіцієнт";
            // 
            // textBox_monthCoeff
            // 
            this.textBox_monthCoeff.Location = new System.Drawing.Point(239, 229);
            this.textBox_monthCoeff.Name = "textBox_monthCoeff";
            this.textBox_monthCoeff.Size = new System.Drawing.Size(179, 22);
            this.textBox_monthCoeff.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Місячний коефіцієнт";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(239, 337);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 25;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(41, 337);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 24;
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
            // tariffsTableAdapter
            // 
            this.tariffsTableAdapter.ClearBeforeFill = true;
            // 
            // editTariffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_monthCoeff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nightCoeff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_dayCoeff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tariffID);
            this.Controls.Add(this.label1);
            this.Name = "editTariffsForm";
            this.Text = "editTariffsForm";
            this.Load += new System.EventHandler(this.editTariffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tariffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dayCoeff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nightCoeff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_monthCoeff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private kursova_carParkingDataSetTableAdapters.TariffsTableAdapter tariffsTableAdapter;
    }
}