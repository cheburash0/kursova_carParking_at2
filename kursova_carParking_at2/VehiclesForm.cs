using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kursova_carParking_at2
{
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.kursova_carParkingDataSet.Vehicles);

        }

        private void vehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursova_carParkingDataSet);
        }

        private void button_deleteVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiclesDataGridView.SelectedRows.Count > 0)
                {
                    // Получаем ID транспортного средства
                    int vehicleId = Convert.ToInt32(vehiclesDataGridView.SelectedRows[0].Cells[0].Value);

                    // Подтверждение удаления
                    var result = MessageBox.Show(
                        "Ви впевнені, що хочете видалити цей транспортний засіб?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Выполняем удаление
                        vehiclesTableAdapter.DeleteQuery(vehicleId);

                        // Обновляем данные
                        vehiclesTableAdapter.Fill(kursova_carParkingDataSet.Vehicles);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Транспортний засіб успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть транспортний засіб для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час видалення транспортного засобу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool edit;
        private void button_addVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                edit = false;
                var edt = new editVehiclesForm();
                edt.ShowDialog();

                // Обновление данных
                vehiclesTableAdapter.Fill(kursova_carParkingDataSet.Vehicles);
                MessageBox.Show("Транспортний засіб успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання транспортного засобу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiclesDataGridView.SelectedRows.Count > 0)
                {
                    edit = true;

                    // Получаем ID транспортного средства из выбранной строки
                    int vehicleId = Convert.ToInt32(vehiclesDataGridView.SelectedRows[0].Cells[0].Value);

                    // Загружаем данные о транспортном средстве
                    var st = new kursova_carParkingDataSet.VehiclesDataTable();
                    vehiclesTableAdapter.FillBy(st, vehicleId);

                    if (st.Rows.Count > 0)
                    {
                        object[] row = st.Rows[0].ItemArray;

                        // Открываем форму редактирования и передаем данные
                        var edt = new editVehiclesForm(
                            Convert.ToInt32(row[0]),   // vehicle_id
                            Convert.ToInt32(row[1]),   // client_id
                            row[2].ToString(),         // license_plate
                            row[3].ToString(),         // model
                            row[4].ToString(),         // color
                            row[5].ToString()          // vehicle_type
                        );

                        edt.ShowDialog();

                        // Обновление данных в таблице Vehicles
                        vehiclesTableAdapter.Fill(kursova_carParkingDataSet.Vehicles);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Транспортний засіб успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Транспортний засіб не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть транспортний засіб для оновлення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час оновлення транспортного засобу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_vehiclesSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_vehiclesSearch.Text.Trim().ToLower();

            // Если текст пустой, сбрасываем подсветку
            if (string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in vehiclesDataGridView.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Сбрасываем фон
                    row.DefaultCellStyle.ForeColor = Color.Black; // Сбрасываем текст
                }
                return;
            }

            // Подсвечиваем строки с совпадениями
            foreach (DataGridViewRow row in vehiclesDataGridView.Rows)
            {
                bool isMatch = false;

                // Проверяем совпадение в столбцах с индексами 0 и 1
                if (row.Cells[2].Value != null &&
                    row.Cells[2].Value.ToString().ToLower().Contains(searchText))
                {
                    isMatch = true;
                }
                else if (row.Cells[3].Value != null &&
                         row.Cells[3].Value.ToString().ToLower().Contains(searchText))
                {
                    isMatch = true;
                }

                // Применяем подсветку
                if (isMatch)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; // Подсветка найденного
                    row.DefaultCellStyle.ForeColor = Color.Black;  // Цвет текста
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Сброс фона
                    row.DefaultCellStyle.ForeColor = Color.Black; // Сброс текста
                }
            }


        }

        private void checkBox_vehiclesType1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vehiclesType1.Checked)
            {
                // Фильтруем только те строки, у которых vehicle_type == "легковий"
                var filteredRows = kursova_carParkingDataSet.Vehicles
                    .AsEnumerable()
                    .Where(row => row.Field<string>("vehicle_type").Equals("легковий", StringComparison.OrdinalIgnoreCase));

                // Обновляем dataGridView_vehicles
                if (filteredRows.Any())
                {
                    vehiclesDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // Если совпадений нет, отображаем пустую таблицу
                    vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
                }
            }
            else
            {
                // Если чекбокс снят, показываем все транспортные средства
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles;
            }
        }

        private void checkBox_vehiclesType3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vehiclesType3.Checked)
            {
                // Фильтруем только те строки, у которых vehicle_type == "мотоцикл"
                var filteredRows = kursova_carParkingDataSet.Vehicles
                    .AsEnumerable()
                    .Where(row => row.Field<string>("vehicle_type").Equals("мотоцикл", StringComparison.OrdinalIgnoreCase));

                // Обновляем dataGridView_vehicles
                if (filteredRows.Any())
                {
                    vehiclesDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // Если совпадений нет, отображаем пустую таблицу
                    vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
                }
            }
            else
            {
                // Если чекбокс снят, показываем все транспортные средства
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles;
            }
        }

        private void checkBox_vehiclesType2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vehiclesType2.Checked)
            {
                // Фильтруем только те строки, у которых vehicle_type == "вантажний"
                var filteredRows = kursova_carParkingDataSet.Vehicles
                    .AsEnumerable()
                    .Where(row => row.Field<string>("vehicle_type").Equals("вантажний", StringComparison.OrdinalIgnoreCase));

                // Обновляем dataGridView_vehicles
                if (filteredRows.Any())
                {
                    vehiclesDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // Если совпадений нет, отображаем пустую таблицу
                    vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
                }
            }
            else
            {
                // Если чекбокс снят, показываем все транспортные средства
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles;
            }
        }

        private void comboBox_clientsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = comboBox_vehiclesSort.SelectedItem.ToString();

            // Сортировка данных по полю "model"
            IEnumerable<DataRow> sortedRows = null;

            switch (sortOrder)
            {
                case "Назва (А-Я)": // По алфавиту
                    sortedRows = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                        .OrderBy(row => row.Field<string>("model"));
                    break;

                case "Назва (Я-А)": // В обратном порядке
                    sortedRows = kursova_carParkingDataSet.Vehicles.AsEnumerable()
                        .OrderByDescending(row => row.Field<string>("model"));
                    break;

                case "Без сортування": // Без сортировки
                default:
                    sortedRows = kursova_carParkingDataSet.Vehicles.AsEnumerable();
                    break;
            }

            // Обновляем dataGridView_vehicles
            if (sortedRows != null && sortedRows.Any())
            {
                vehiclesDataGridView.DataSource = sortedRows.CopyToDataTable();
            }
            else
            {
                // Если нет данных, показываем пустую таблицу
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone();
            }

            // Добавляем обработку выбора строк для актуализации данных
            vehiclesDataGridView.SelectionChanged += (s, ev) =>
            {
                if (vehiclesDataGridView.CurrentRow != null)
                {
                    var rowView = (DataRowView)vehiclesDataGridView.CurrentRow.DataBoundItem;
                    int vehicleId = Convert.ToInt32(rowView["vehicle_id"]);

                }
            };
        }

        private void buttonVehiclesByClients_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-G5PU7L6;Database=kursova_carParking;Integrated Security=True;";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = @"
        SELECT 
            Clients.client_id AS [ID Клієнта],
            Clients.first_name AS [Ім'я],
            Clients.last_name AS [Прізвище],
            Vehicles.licence_plate AS [Номерний знак],
            Vehicles.model AS [Модель],
            Vehicles.vehicle_type AS [Тип транспорту]
        FROM Clients
        JOIN Vehicles ON Clients.client_id = Vehicles.client_id
        ORDER BY Clients.last_name, Clients.first_name;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable reportTable = new DataTable();
                    adapter.Fill(reportTable);

                    // Формування тексту для друку
                    StringBuilder printContent = new StringBuilder();
                    printContent.AppendLine("Автостоянка \"Shmel's Parking\"");
                    printContent.AppendLine("Звіт: Транспортні засоби по клієнтам");
                    printContent.AppendLine($"Дата створення звіту: {DateTime.Now:dd.MM.yyyy HH:mm}");

                    // Обчислення ширини колонок
                    List<int> columnWidths = new List<int>();
                    foreach (DataColumn column in reportTable.Columns)
                    {
                        columnWidths.Add(column.ColumnName.Length > 20 ? column.ColumnName.Length + 2 : 20); // Мінімальна ширина 20
                    }

                    int totalWidth = columnWidths.Sum(); // Загальна ширина для розділової лінії
                    printContent.AppendLine(new string('-', totalWidth));

                    // Додавання заголовків колонок
                    for (int i = 0; i < reportTable.Columns.Count; i++)
                    {
                        printContent.Append($"{reportTable.Columns[i].ColumnName.PadRight(columnWidths[i])}");
                    }
                    printContent.AppendLine();
                    printContent.AppendLine(new string('-', totalWidth));

                    // Додавання рядків даних
                    foreach (DataRow row in reportTable.Rows)
                    {
                        for (int i = 0; i < row.ItemArray.Length; i++)
                        {
                            string cellValue = row[i]?.ToString() ?? "";
                            printContent.Append($"{cellValue.PadRight(columnWidths[i])}");
                        }
                        printContent.AppendLine();
                    }

                    // Вибір місця для збереження
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Text Files (*.txt)|*.txt",
                        FileName = $"Транспортні засоби по клієнтам_{DateTime.Now:yyyyMMdd_HHmmss}.txt",
                        Title = "Збереження звіту"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, printContent.ToString());
                        MessageBox.Show($"Звіт успішно збережено: {saveFileDialog.FileName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час створення звіту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
