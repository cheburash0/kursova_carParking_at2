namespace kursova_carParking_at2
{
    partial class editSpacesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_spaceID = new System.Windows.Forms.TextBox();
            this.textBox_pricePerHour = new System.Windows.Forms.TextBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.textBox_tariffNum = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            this.comboBox_spaceStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер місця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ціна за годину";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Опис (локація)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер тарифу";
            // 
            // textBox_spaceID
            // 
            this.textBox_spaceID.Location = new System.Drawing.Point(201, 32);
            this.textBox_spaceID.Name = "textBox_spaceID";
            this.textBox_spaceID.Size = new System.Drawing.Size(179, 22);
            this.textBox_spaceID.TabIndex = 13;
            // 
            // textBox_pricePerHour
            // 
            this.textBox_pricePerHour.Location = new System.Drawing.Point(201, 128);
            this.textBox_pricePerHour.Name = "textBox_pricePerHour";
            this.textBox_pricePerHour.Size = new System.Drawing.Size(179, 22);
            this.textBox_pricePerHour.TabIndex = 15;
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(201, 177);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(179, 22);
            this.textBox_location.TabIndex = 16;
            // 
            // textBox_tariffNum
            // 
            this.textBox_tariffNum.Location = new System.Drawing.Point(201, 227);
            this.textBox_tariffNum.Name = "textBox_tariffNum";
            this.textBox_tariffNum.Size = new System.Drawing.Size(179, 22);
            this.textBox_tariffNum.TabIndex = 17;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(440, 122);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(158, 75);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(440, 25);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(158, 75);
            this.button_OK.TabIndex = 22;
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
            // spacesTableAdapter
            // 
            this.spacesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_spaceStatus
            // 
            this.comboBox_spaceStatus.FormattingEnabled = true;
            this.comboBox_spaceStatus.Items.AddRange(new object[] {
            "Вільне",
            "Зайняте"});
            this.comboBox_spaceStatus.Location = new System.Drawing.Point(201, 75);
            this.comboBox_spaceStatus.Name = "comboBox_spaceStatus";
            this.comboBox_spaceStatus.Size = new System.Drawing.Size(179, 24);
            this.comboBox_spaceStatus.TabIndex = 24;
            // 
            // editSpacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_spaceStatus);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_tariffNum);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.textBox_pricePerHour);
            this.Controls.Add(this.textBox_spaceID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editSpacesForm";
            this.Text = "editSpacesForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_spaceID;
        private System.Windows.Forms.TextBox textBox_pricePerHour;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.TextBox textBox_tariffNum;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_spaceStatus;
    }
}