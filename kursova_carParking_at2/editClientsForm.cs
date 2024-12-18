using kursova_carParking_at2.kursova_carParkingDataSetTableAdapters;
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
    public partial class editClientsForm : Form
    {
        private readonly int id;
        readonly bool edit;
        public editClientsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
            edit = false;
        }

        /// <param name="id">Номер клієнта</param>
        /// <param name="firstName">Ім'я</param>
        /// <param name="lastName">Прізвище</param>
        /// <param name="phoneNumber">Номер телефону</param>
        /// <param name="email">Email</param>

        public editClientsForm(int id, string firstName, string lastName,
    string phoneNumber, string email) : this()
        {
            clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
            edit = true;
            textBox_clientID.Text = id.ToString();
            textBox_firstName.Text = firstName.ToString();
            textBox_lastName.Text = lastName;
            textBox_phoneNumber.Text = phoneNumber;
            textBox_email.Text = email;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit) {
                clientsTableAdapter.UpdateQuery(textBox_firstName.Text,
                    textBox_lastName.Text,
                    textBox_phoneNumber.Text,
                    textBox_email.Text,
                    Convert.ToInt32(textBox_clientID.Text));
            }
            else
            {
                clientsTableAdapter.InsertQuery(textBox_firstName.Text,
                    textBox_lastName.Text,
                    textBox_phoneNumber.Text,
                    textBox_email.Text);
            }
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
