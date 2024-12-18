using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova_carParking_at2
{
    public partial class ClientsForm : Form
    {
        
        public ClientsForm()
        {
            InitializeComponent();

        }

        private DataView clientsDataView;
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.kursova_carParkingDataSet.Vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.kursova_carParkingDataSet.Clients);
            clientsDataView = new DataView(kursova_carParkingDataSet.Clients);
                    
        }


        private void button_deleteClients_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView_clients.SelectedRows[0].Cells[0].Value));
            clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
            kursova_carParkingDataSet.AcceptChanges();
        }

        private bool edit;
        private void button_addClients_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new editClientsForm();
            edt.ShowDialog();
            clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);

        }

        private void button_editClients_Click(object sender, EventArgs e)
        {
            edit = true;
            var st = new kursova_carParkingDataSet.ClientsDataTable();
            clientsTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView_clients.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new editClientsForm(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString());
            edt.ShowDialog();
            clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
            kursova_carParkingDataSet.AcceptChanges();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_clientsSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_clientsSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                clientsDataView.RowFilter = ""; // Скидання фільтру
            }
            else
            {
                clientsDataView.RowFilter = $"[first_name] LIKE '%{searchText}%' OR [last_name] LIKE '%{searchText}%'";
            }
        }       

        private void comboBox_clientsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_clientsSort.SelectedItem.ToString())
            {
                case "Без сортування":
                    clientsDataView.Sort = "";
                    break;

                case "Ім'я (А-Я)":
                    clientsDataView.Sort = "first_name ASC";
                    break;

                case "Ім'я (Я-А)":
                    clientsDataView.Sort = "first_name DESC";
                    break;

                case "Прізвище (А-Я)":
                    clientsDataView.Sort = "last_name ASC";
                    break;

                case "Прізвище (Я-А)":
                    clientsDataView.Sort = "last_name DESC";
                    break;

                default:
                    clientsDataView.Sort = "";
                    break;
            }
        }

        private void checkBox_vehiclesCount_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
