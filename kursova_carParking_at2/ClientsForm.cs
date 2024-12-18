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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DataView clientsDataView;
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.kursova_carParkingDataSet.Vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.kursova_carParkingDataSet.Clients);
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
            string searchText = textBox_clientsSearch.Text.Trim();

            var filteredRows = kursova_carParkingDataSet.Clients
                .AsEnumerable()
                .Where(row => row.Field<string>("first_name").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                           || row.Field<string>("last_name").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            if (filteredRows.Any())
            {
                dataGridView_clients.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                dataGridView_clients.DataSource = kursova_carParkingDataSet.Clients.Clone(); // Пустая таблица
            }

            // Обновляем vehiclesDataGridView
            if (dataGridView_clients.CurrentRow != null)
            {
                var rowView = (DataRowView)dataGridView_clients.CurrentRow.DataBoundItem;
                int clientId = Convert.ToInt32(rowView["client_id"]);

                var vehiclesFiltered = kursova_carParkingDataSet.Vehicles
                    .AsEnumerable()
                    .Where(row => row.Field<int>("client_id") == clientId);

                vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                    ? vehiclesFiltered.CopyToDataTable()
                    : kursova_carParkingDataSet.Vehicles.Clone();
            }
        }       

        private void comboBox_clientsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = comboBox_clientsSort.SelectedItem.ToString();
            // Сортируем данные клиентов
            IEnumerable<DataRow> sortedRows = null;

            switch (sortOrder)
            {
                case "Ім'я (А-Я)":
                    sortedRows = kursova_carParkingDataSet.Clients.AsEnumerable()
                        .OrderBy(row => row.Field<string>("first_name"));
                    break;

                case "Ім'я (Я-А)":
                    sortedRows = kursova_carParkingDataSet.Clients.AsEnumerable()
                        .OrderByDescending(row => row.Field<string>("first_name"));
                    break;

                case "Прізвище (А-Я)":
                    sortedRows = kursova_carParkingDataSet.Clients.AsEnumerable()
                        .OrderBy(row => row.Field<string>("last_name"));
                    break;

                case "Прізвище (Я-А)":
                    sortedRows = kursova_carParkingDataSet.Clients.AsEnumerable()
                        .OrderByDescending(row => row.Field<string>("last_name"));
                    break;

                default:
                    sortedRows = kursova_carParkingDataSet.Clients.AsEnumerable();
                    break;
            }
            // Обновляем DataGridView клиентов
            if (sortedRows != null && sortedRows.Any())
            {
                dataGridView_clients.DataSource = sortedRows.CopyToDataTable();
                // Устанавливаем первую строку как текущую
                if (dataGridView_clients.Rows.Count > 0)
                {
                    dataGridView_clients.CurrentCell = dataGridView_clients.Rows[0].Cells[0];
                    // Обновляем vehiclesDataGridView для первой строки
                    var rowView = (DataRowView)dataGridView_clients.Rows[0].DataBoundItem;
                    int clientId = Convert.ToInt32(rowView["client_id"]);

                    var vehiclesFiltered = kursova_carParkingDataSet.Vehicles
                        .AsEnumerable()
                        .Where(row => row.Field<int>("client_id") == clientId);

                    vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                        ? vehiclesFiltered.CopyToDataTable()
                        : kursova_carParkingDataSet.Vehicles.Clone();
                }
            }
            else
            {
                // Если строк нет, очищаем DataGridView транспортных средств
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
            }
            // Добавляем поддержку кликов на разных клиентов после сортировки
            dataGridView_clients.SelectionChanged += (s, ev) =>
            {
                if (dataGridView_clients.CurrentRow != null)
                {
                    var rowView = (DataRowView)dataGridView_clients.CurrentRow.DataBoundItem;
                    int clientId = Convert.ToInt32(rowView["client_id"]);

                    var vehiclesFiltered = kursova_carParkingDataSet.Vehicles
                        .AsEnumerable()
                        .Where(row => row.Field<int>("client_id") == clientId);

                    vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                        ? vehiclesFiltered.CopyToDataTable()
                        : kursova_carParkingDataSet.Vehicles.Clone();
                }
            };
        }

        private void checkBox_vehiclesCount_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
