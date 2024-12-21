using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova_carParking_at2
{
    public partial class editEventLogForm : Form
    {
        public Action RefreshEventLogData { get; set; }
        public bool IsChanged { get; private set; } = false;
        private readonly int id;
        readonly bool edit;
        public editEventLogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker_logDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_logDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker_logDate.ShowUpDown = false;
            eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog);
            edit = false;
        }

        /// <param name="logID">Номер платежа</param>
        /// <param name="logType">Сума</param>
        /// <param name="logDate">Дата платежа</param>
        /// <param name="logDescription">Номер паркування</param>
        /// <param name="clientID">Номер паркування</param>

        public editEventLogForm(int logID, string logType,
            DateTime logDate, string logDescription, int clientID) : this() 
        {
            eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog);
            edit = true;
            textBox_logID.Text = logID.ToString();
            comboBox_logType.Text = logType.ToString();
            dateTimePicker_logDate.Value = logDate;
            textBox_logDescription.Text = logDescription.ToString();
            textBox_clientID.Text = clientID.ToString();
        }


        private void editEventLogForm_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                eventLogTableAdapter.UpdateQuery(
                    comboBox_logType.Text.ToString(),
                    Convert.ToDateTime(dateTimePicker_logDate.Value),
                    textBox_logDescription.Text.ToString(),
                    Convert.ToInt32(textBox_clientID.Text),
                    Convert.ToInt32(textBox_logID.Text));
            }
            else 
            {
                eventLogTableAdapter.InsertQuery(
                    comboBox_logType.Text.ToString(),
                    Convert.ToDateTime(dateTimePicker_logDate.Value),
                    textBox_logDescription.Text.ToString(),
                    Convert.ToInt32(textBox_clientID.Text));
            }
            IsChanged = true;
            RefreshEventLogData?.Invoke();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
