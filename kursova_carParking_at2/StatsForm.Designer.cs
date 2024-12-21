namespace kursova_carParking_at2
{
    partial class StatsForm
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
            this.dataGridView_stats = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStatsTotalRevenue = new System.Windows.Forms.Button();
            this.buttonStatsSpaces = new System.Windows.Forms.Button();
            this.buttonStatsTopClients = new System.Windows.Forms.Button();
            this.buttonStatsAvgTime = new System.Windows.Forms.Button();
            this.paymentsTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter();
            this.spacesTableAdapter = new kursova_carParking_at2.kursova_carParkingDataSetTableAdapters.SpacesTableAdapter();
            this.buttonStatsPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stats
            // 
            this.dataGridView_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stats.Location = new System.Drawing.Point(48, 50);
            this.dataGridView_stats.Name = "dataGridView_stats";
            this.dataGridView_stats.ReadOnly = true;
            this.dataGridView_stats.RowHeadersWidth = 51;
            this.dataGridView_stats.RowTemplate.Height = 24;
            this.dataGridView_stats.Size = new System.Drawing.Size(703, 238);
            this.dataGridView_stats.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статистики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStatsTotalRevenue
            // 
            this.buttonStatsTotalRevenue.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStatsTotalRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatsTotalRevenue.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatsTotalRevenue.Location = new System.Drawing.Point(48, 303);
            this.buttonStatsTotalRevenue.Name = "buttonStatsTotalRevenue";
            this.buttonStatsTotalRevenue.Size = new System.Drawing.Size(158, 75);
            this.buttonStatsTotalRevenue.TabIndex = 11;
            this.buttonStatsTotalRevenue.Text = "Загальна виручка";
            this.buttonStatsTotalRevenue.UseVisualStyleBackColor = false;
            this.buttonStatsTotalRevenue.Click += new System.EventHandler(this.buttonStatsTotalRevenue_Click);
            // 
            // buttonStatsSpaces
            // 
            this.buttonStatsSpaces.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStatsSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatsSpaces.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatsSpaces.Location = new System.Drawing.Point(231, 303);
            this.buttonStatsSpaces.Name = "buttonStatsSpaces";
            this.buttonStatsSpaces.Size = new System.Drawing.Size(158, 75);
            this.buttonStatsSpaces.TabIndex = 12;
            this.buttonStatsSpaces.Text = "Зайнятість місць";
            this.buttonStatsSpaces.UseVisualStyleBackColor = false;
            this.buttonStatsSpaces.Click += new System.EventHandler(this.buttonStatsSpaces_Click);
            // 
            // buttonStatsTopClients
            // 
            this.buttonStatsTopClients.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStatsTopClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatsTopClients.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatsTopClients.Location = new System.Drawing.Point(413, 303);
            this.buttonStatsTopClients.Name = "buttonStatsTopClients";
            this.buttonStatsTopClients.Size = new System.Drawing.Size(158, 75);
            this.buttonStatsTopClients.TabIndex = 13;
            this.buttonStatsTopClients.Text = "Найактивніші клієнти";
            this.buttonStatsTopClients.UseVisualStyleBackColor = false;
            this.buttonStatsTopClients.Click += new System.EventHandler(this.buttonStatsTopClients_Click);
            // 
            // buttonStatsAvgTime
            // 
            this.buttonStatsAvgTime.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStatsAvgTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatsAvgTime.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatsAvgTime.Location = new System.Drawing.Point(593, 303);
            this.buttonStatsAvgTime.Name = "buttonStatsAvgTime";
            this.buttonStatsAvgTime.Size = new System.Drawing.Size(158, 75);
            this.buttonStatsAvgTime.TabIndex = 14;
            this.buttonStatsAvgTime.Text = "Середній час паркування";
            this.buttonStatsAvgTime.UseVisualStyleBackColor = false;
            this.buttonStatsAvgTime.Click += new System.EventHandler(this.buttonStatsAvgTime_Click);
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // spacesTableAdapter
            // 
            this.spacesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonStatsPrint
            // 
            this.buttonStatsPrint.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStatsPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatsPrint.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatsPrint.Location = new System.Drawing.Point(665, 397);
            this.buttonStatsPrint.Name = "buttonStatsPrint";
            this.buttonStatsPrint.Size = new System.Drawing.Size(86, 41);
            this.buttonStatsPrint.TabIndex = 15;
            this.buttonStatsPrint.Text = "Друк";
            this.buttonStatsPrint.UseVisualStyleBackColor = false;
            this.buttonStatsPrint.Click += new System.EventHandler(this.buttonStatsPrint_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStatsPrint);
            this.Controls.Add(this.buttonStatsAvgTime);
            this.Controls.Add(this.buttonStatsTopClients);
            this.Controls.Add(this.buttonStatsSpaces);
            this.Controls.Add(this.buttonStatsTotalRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_stats);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStatsTotalRevenue;
        private System.Windows.Forms.Button buttonStatsSpaces;
        private System.Windows.Forms.Button buttonStatsTopClients;
        private System.Windows.Forms.Button buttonStatsAvgTime;
        private kursova_carParkingDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private kursova_carParkingDataSetTableAdapters.SpacesTableAdapter spacesTableAdapter;
        private System.Windows.Forms.Button buttonStatsPrint;
    }
}