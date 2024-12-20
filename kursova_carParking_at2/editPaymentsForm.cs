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
    public partial class editPaymentsForm : Form
    {
        public Action RefreshPaymentsData { get; set; }
        public bool IsChanged { get; private set; } = false;
        private readonly int id;
        readonly bool edit;
        public editPaymentsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
            edit = false;
        }

        /// <param name="paymentID">Номер платежа</param>
        /// <param name="amount">Сума</param>
        /// <param name="paymentDate">Дата платежа</param>
        /// <param name="parkingID">Номер паркування</param>

        public editPaymentsForm(int paymentID, decimal amount,
            DateTime paymentDate, int parkingID) : this() 
        {
            paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
            edit = true;
            textBox_paymentID.Text = paymentID.ToString();
            textBox_amount.Text = amount.ToString();    
            textBox_paymentDate.Text = paymentDate.ToString("dd.MM.yyyy");
            textBox_parkingID.Text = parkingID.ToString();
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                paymentsTableAdapter.UpdateQuery(
                    Convert.ToDecimal(textBox_amount.Text),
                    Convert.ToDateTime(textBox_paymentDate.Text),
                    Convert.ToInt32(textBox_parkingID.Text),
                    Convert.ToInt32(textBox_paymentID.Text));
            }
            else 
            {
                paymentsTableAdapter.InsertQuery(
                    Convert.ToDecimal(textBox_amount.Text),
                    Convert.ToDateTime(textBox_paymentDate.Text),
                    Convert.ToInt32(textBox_parkingID.Text));
            }
            IsChanged = true;
            RefreshPaymentsData?.Invoke();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
