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
            try
            {
                if (dataGridView_clients.SelectedRows.Count > 0)
                {
                    int clientId = Convert.ToInt32(dataGridView_clients.SelectedRows[0].Cells[0].Value);

                    // Удаление клиента
                    clientsTableAdapter.DeleteQuery(clientId);
                    clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
                    kursova_carParkingDataSet.AcceptChanges();

                    MessageBox.Show("Клієнта успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Виберіть клієнта для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час видалення клієнта:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool edit;
        private void button_addClients_Click(object sender, EventArgs e)
        {
            try
            {
                edit = false;
                var edt = new editClientsForm();
                edt.ShowDialog();

                // Обновление данных
                clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
                MessageBox.Show("Клієнт успішно доданий!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання клієнта:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_editClients_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_clients.SelectedRows.Count > 0)
                {
                    edit = true;

                    int clientId = Convert.ToInt32(dataGridView_clients.SelectedRows[0].Cells[0].Value);
                    var st = new kursova_carParkingDataSet.ClientsDataTable();
                    clientsTableAdapter.FillBy(st, clientId);

                    if (st.Rows.Count > 0)
                    {
                        object[] row = st.Rows[0].ItemArray;
                        var edt = new editClientsForm(
                            Convert.ToInt32(row[0]),
                            row[1].ToString(),
                            row[2].ToString(),
                            row[3].ToString(),
                            row[4].ToString()
                        );

                        edt.ShowDialog();

                        // Обновление данных
                        clientsTableAdapter.Fill(kursova_carParkingDataSet.Clients);
                        MessageBox.Show("Клієнта успішно відредаговано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Клієнта не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть клієнта для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час редагування клієнта:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }      
        private void textBox_clientsSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_clientsSearch.Text.Trim().ToLower();

            // Если строка поиска пуста, сбрасываем стили строк
            if (string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridView_clients.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Сбрасываем цвет
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                return;
            }

            // Определяем, по каким номерам столбцов искать
            var searchColumns = new List<int>();
            if (checkBox_searchByFirstName.Checked)
                searchColumns.Add(1); // Номер столбца для имени
            if (checkBox_searchByLastName.Checked)
                searchColumns.Add(2); // Номер столбца для фамилии

            // Если ни один чекбокс не выбран, подсветку не выполняем
            if (!searchColumns.Any())
            {
                foreach (DataGridViewRow row in dataGridView_clients.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                return;
            }

            // Подсвечиваем строки с совпадением
            foreach (DataGridViewRow row in dataGridView_clients.Rows)
            {
                bool isMatch = false;

                foreach (var columnIndex in searchColumns)
                {
                    // Проверяем существование столбца с таким индексом
                    if (columnIndex < row.Cells.Count &&
                        row.Cells[columnIndex].Value != null &&
                        row.Cells[columnIndex].Value.ToString().ToLower().Contains(searchText))
                    {
                        isMatch = true;
                        break;
                    }
                }

                if (isMatch)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; // Подсветка фона
                    row.DefaultCellStyle.ForeColor = Color.Black;  // Цвет текста
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Сброс фона
                    row.DefaultCellStyle.ForeColor = Color.Black; // Сброс цвета текста
                }
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
            if (checkBox_vehiclesCount.Checked)
            {
                // Фильтруем клиентов с 2 или более транспортными средствами
                var filteredClients = kursova_carParkingDataSet.Clients.AsEnumerable()
                    .Where(client =>
                    {
                        int clientId = client.Field<int>("client_id");

                        // Считаем количество транспортных средств у клиента
                        int vehicleCount = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                            .Count(vehicle => vehicle.Field<int>("client_id") == clientId);

                        return vehicleCount >= 2; // Условие: 2 или больше транспортных средств
                    });

                if (filteredClients.Any())
                {
                    dataGridView_clients.DataSource = filteredClients.CopyToDataTable();
                    // Устанавливаем первую строку как выбранную
                    if (dataGridView_clients.Rows.Count > 0)
                    {
                        dataGridView_clients.CurrentCell = dataGridView_clients.Rows[0].Cells[0];

                        // Обновляем vehiclesDataGridView для первого клиента
                        var rowView = (DataRowView)dataGridView_clients.Rows[0].DataBoundItem;
                        int clientId = Convert.ToInt32(rowView["client_id"]);

                        var vehiclesFiltered = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                            .Where(vehicle => vehicle.Field<int>("client_id") == clientId);

                        vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                            ? vehiclesFiltered.CopyToDataTable()
                            : kursova_carParkingDataSet.Vehicles.Clone();
                    }
                }
                else
                {
                    // Если клиентов нет, очищаем обе таблицы
                    dataGridView_clients.DataSource = kursova_carParkingDataSet.Clients.Clone();
                    vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
                }
            }
            else
            {
                // Сбрасываем фильтрацию: показываем всех клиентов
                dataGridView_clients.DataSource = kursova_carParkingDataSet.Clients;

                // Обновляем vehiclesDataGridView для текущего клиента
                if (dataGridView_clients.Rows.Count > 0 && dataGridView_clients.CurrentRow != null)
                {
                    var rowView = (DataRowView)dataGridView_clients.CurrentRow.DataBoundItem;
                    int clientId = Convert.ToInt32(rowView["client_id"]);

                    var vehiclesFiltered = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                        .Where(vehicle => vehicle.Field<int>("client_id") == clientId);

                    vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                        ? vehiclesFiltered.CopyToDataTable()
                        : kursova_carParkingDataSet.Vehicles.Clone();
                }
                else
                {
                    vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
                }
            }

            // Добавляем поддержку выбора клиентов после фильтрации
            dataGridView_clients.SelectionChanged += (s, ev) =>
            {
                if (dataGridView_clients.CurrentRow != null)
                {
                    var rowView = (DataRowView)dataGridView_clients.CurrentRow.DataBoundItem;
                    int clientId = Convert.ToInt32(rowView["client_id"]);

                    var vehiclesFiltered = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                        .Where(vehicle => vehicle.Field<int>("client_id") == clientId);

                    vehiclesDataGridView.DataSource = vehiclesFiltered.Any()
                        ? vehiclesFiltered.CopyToDataTable()
                        : kursova_carParkingDataSet.Vehicles.Clone();
                }
            };
        }

        private void dataGridView_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
