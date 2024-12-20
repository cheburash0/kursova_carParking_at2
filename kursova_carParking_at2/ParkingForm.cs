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
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.kursova_carParkingDataSet.Parking);

        }

        private void parkingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parkingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursova_carParkingDataSet);

        }

        private bool edit;
        private void button_addParking_Click(object sender, EventArgs e)
        {
            try
            {
                edit = false;
                var edt = new editParkingForm(); // Форма для добавления/редактирования парковки
                edt.ShowDialog();

                // Обновление данных
                parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking); // Заполнение данных парковочных мест
                MessageBox.Show("Паркувальне місце успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання паркувального місця:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editParking_Click(object sender, EventArgs e)
        {
            try
            {
                if (parkingDataGridView.SelectedRows.Count > 0)
                {
                    edit = true;

                    // Получаем ID парковочного места из выбранной строки
                    int parkingId = Convert.ToInt32(parkingDataGridView.SelectedRows[0].Cells[0].Value);

                    // Загружаем данные о парковочном месте
                    var st = new kursova_carParkingDataSet.ParkingDataTable();
                    parkingTableAdapter.FillBy(st, parkingId);

                    if (st.Rows.Count > 0)
                    {
                        object[] row = st.Rows[0].ItemArray;

                        // Открываем форму редактирования и передаем данные
                        var edt = new editParkingForm(
                            Convert.ToInt32(row[0]),   // parking_id
                            Convert.ToInt32(row[1]),   // space_id
                            Convert.ToInt32(row[2]),   // vehicle_id
                            Convert.ToDateTime(row[3]), // start_date
                            TimeSpan.Parse(row[4].ToString()), // start_time
                            Convert.ToDateTime(row[5]), // end_date
                            TimeSpan.Parse(row[6].ToString())  // end_time
                        );

                        edt.ShowDialog();

                        // Обновление данных в таблице Parking
                        parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Паркувальне місце успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Паркувальне місце не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть паркувальне місце для оновлення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час оновлення паркувального місця:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteParking_Click(object sender, EventArgs e)
        {
            try
            {
                if (parkingDataGridView.SelectedRows.Count > 0)
                {
                    // Получаем ID парковочного места
                    int parkingId = Convert.ToInt32(parkingDataGridView.SelectedRows[0].Cells[0].Value);

                    // Подтверждение удаления
                    var result = MessageBox.Show(
                        "Ви впевнені, що хочете видалити це паркувальне місце?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Выполняем удаление
                        parkingTableAdapter.DeleteQuery(parkingId);

                        // Обновляем данные
                        parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Паркувальне місце успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть паркувальне місце для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час видалення паркувального місця:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_parkingSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = comboBox_parkingSort.SelectedItem.ToString();

            // Сортировка данных по выбранному критерию
            IEnumerable<DataRow> sortedRows = null;

            switch (sortOrder)
            {
                case "Дата початку (від мін до макс)": // Сортировка по дате начала, от меньшего к большему
                    sortedRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                        .OrderBy(row => row.Field<DateTime>("start_date"));
                    break;

                case "Дата початку (від макс до мін)": // Сортировка по дате начала, от большего к меньшему
                    sortedRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                        .OrderByDescending(row => row.Field<DateTime>("start_date"));
                    break;

                case "Дата кінця (від мін до макс)": // Сортировка по дате окончания, от меньшего к большему
                    sortedRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                        .OrderBy(row => row.Field<DateTime>("end_date"));
                    break;

                case "Дата кінця (від макс до мін)": // Сортировка по дате окончания, от большего к меньшему
                    sortedRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                        .OrderByDescending(row => row.Field<DateTime>("end_date"));
                    break;

                case "Без сортування": // Без сортировки
                default:
                    sortedRows = kursova_carParkingDataSet.Parking.AsEnumerable();
                    break;
            }

            // Обновляем dataGridView_parking
            if (sortedRows != null && sortedRows.Any())
            {
                parkingDataGridView.DataSource = sortedRows.CopyToDataTable();
            }
            else
            {
                // Если нет данных, показываем пустую таблицу
                parkingDataGridView.DataSource = kursova_carParkingDataSet.Parking.Clone();
            }

            // Добавляем поддержку выбора строк
            parkingDataGridView.SelectionChanged += (s, ev) =>
            {
                if (parkingDataGridView.CurrentRow != null)
                {
                    var rowView = (DataRowView)parkingDataGridView.CurrentRow.DataBoundItem;
                    int parkingId = Convert.ToInt32(rowView["parking_id"]);

                    // Дополнительная логика при выборе строки (если требуется)
                }
            };
        }

        private void checkBox_parkingLong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_vehicleFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox_vehicleFilter.Text.Trim();

            // Перевірка, чи введений текст є числом
            if (int.TryParse(filterText, out int vehicleId))
            {
                // Фільтруємо дані за vehicle_id
                var filteredRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                    .Where(row => row.Field<int>("vehicle_id") == vehicleId);

                // Відображаємо результати у DataGridView
                parkingDataGridView.DataSource = filteredRows.Any()
                    ? filteredRows.CopyToDataTable()
                    : kursova_carParkingDataSet.Parking.Clone();
            }
            else if (string.IsNullOrEmpty(filterText))
            {
                // Скидання фільтра
                parkingDataGridView.DataSource = kursova_carParkingDataSet.Parking;
            }
        }

        private void textBox_parkingSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_parkingSearch.Text.Trim();

            var filteredRows = kursova_carParkingDataSet.Parking.AsEnumerable()
                .Where(row => row.Field<int?>("vehicle_id")?.ToString().Contains(searchText) == true ||
                              row.Field<DateTime?>("start_date")?.ToString("dd/MM/yyyy").Contains(searchText) == true ||
                              row.Field<DateTime?>("end_date")?.ToString("dd/MM/yyyy").Contains(searchText) == true);

            // Оновлюємо DataGridView
            parkingDataGridView.DataSource = filteredRows.Any()
                ? filteredRows.CopyToDataTable()
                : kursova_carParkingDataSet.Parking.Clone();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
