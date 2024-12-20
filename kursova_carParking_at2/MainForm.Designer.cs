namespace kursova_carParking_at2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClients = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursova_carParkingDataSet = new kursova_carParking_at2.kursova_carParkingDataSet();
            this.buttonVehicles = new System.Windows.Forms.Button();
            this.buttonParking = new System.Windows.Forms.Button();
            this.buttonSpaces = new System.Windows.Forms.Button();
            this.buttonTariffs = new System.Windows.Forms.Button();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEventLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автостоянка \"Shmel\'s Parking\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(12, 203);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(158, 75);
            this.buttonClients.TabIndex = 3;
            this.buttonClients.Text = "Клієнти";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
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
            // buttonVehicles
            // 
            this.buttonVehicles.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVehicles.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVehicles.Location = new System.Drawing.Point(215, 203);
            this.buttonVehicles.Name = "buttonVehicles";
            this.buttonVehicles.Size = new System.Drawing.Size(158, 75);
            this.buttonVehicles.TabIndex = 4;
            this.buttonVehicles.Text = "Транспортні засоби";
            this.buttonVehicles.UseVisualStyleBackColor = false;
            this.buttonVehicles.Click += new System.EventHandler(this.buttonVehicles_Click);
            // 
            // buttonParking
            // 
            this.buttonParking.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonParking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonParking.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonParking.Location = new System.Drawing.Point(419, 203);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(158, 75);
            this.buttonParking.TabIndex = 5;
            this.buttonParking.Text = "Паркування";
            this.buttonParking.UseVisualStyleBackColor = false;
            this.buttonParking.Click += new System.EventHandler(this.buttonParking_Click);
            // 
            // buttonSpaces
            // 
            this.buttonSpaces.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpaces.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpaces.Location = new System.Drawing.Point(615, 203);
            this.buttonSpaces.Name = "buttonSpaces";
            this.buttonSpaces.Size = new System.Drawing.Size(158, 75);
            this.buttonSpaces.TabIndex = 6;
            this.buttonSpaces.Text = "Паркувальні місця";
            this.buttonSpaces.UseVisualStyleBackColor = false;
            this.buttonSpaces.Click += new System.EventHandler(this.buttonSpaces_Click);
            // 
            // buttonTariffs
            // 
            this.buttonTariffs.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonTariffs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTariffs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTariffs.Location = new System.Drawing.Point(12, 311);
            this.buttonTariffs.Name = "buttonTariffs";
            this.buttonTariffs.Size = new System.Drawing.Size(158, 75);
            this.buttonTariffs.TabIndex = 7;
            this.buttonTariffs.Text = "Тарифи";
            this.buttonTariffs.UseVisualStyleBackColor = false;
            this.buttonTariffs.Click += new System.EventHandler(this.buttonTariffs_Click);
            // 
            // buttonPayments
            // 
            this.buttonPayments.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayments.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPayments.Location = new System.Drawing.Point(215, 311);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(158, 75);
            this.buttonPayments.TabIndex = 8;
            this.buttonPayments.Text = "Платежі\r\n(Оплата)";
            this.buttonPayments.UseVisualStyleBackColor = false;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kursova_carParking_at2.Properties.Resources.bumblebee_nature_png_design_5690321;
            this.pictureBox2.Location = new System.Drawing.Point(701, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursova_carParking_at2.Properties.Resources.free_parking_sign_icon_2526_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEventLog
            // 
            this.buttonEventLog.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonEventLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEventLog.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEventLog.Location = new System.Drawing.Point(419, 311);
            this.buttonEventLog.Name = "buttonEventLog";
            this.buttonEventLog.Size = new System.Drawing.Size(158, 75);
            this.buttonEventLog.TabIndex = 9;
            this.buttonEventLog.Text = "Журнал подій";
            this.buttonEventLog.UseVisualStyleBackColor = false;
            this.buttonEventLog.Click += new System.EventHandler(this.buttonEventLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEventLog);
            this.Controls.Add(this.buttonPayments);
            this.Controls.Add(this.buttonTariffs);
            this.Controls.Add(this.buttonSpaces);
            this.Controls.Add(this.buttonParking);
            this.Controls.Add(this.buttonVehicles);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursova_carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursova_carParkingDataSet kursova_carParkingDataSet;
        private System.Windows.Forms.Button buttonVehicles;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.Button buttonSpaces;
        private System.Windows.Forms.Button buttonTariffs;
        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.Button buttonEventLog;
    }
}

