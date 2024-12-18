﻿using System;
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
            string searchText = textBox_vehiclesSearch.Text.Trim();

            // Фильтрация по полям model и licence_plate
            var filteredRows = kursova_carParkingDataSet.Vehicles
                .AsEnumerable()
                .Where(row => row.Field<string>("model").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                           || row.Field<string>("licence_plate").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            // Обновляем dataGridView_vehicles
            if (filteredRows.Any())
            {
                vehiclesDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                vehiclesDataGridView.DataSource = kursova_carParkingDataSet.Vehicles.Clone(); // Пустая таблица
            }

            // Обновляем dataGridView_aboutVehicles (если необходимо отобразить текущий результат)
            if (vehiclesDataGridView.CurrentRow != null)
            {
                var rowView = (DataRowView)vehiclesDataGridView.CurrentRow.DataBoundItem;
                int vehicleId = Convert.ToInt32(rowView["vehicle_id"]);

                var aboutVehiclesFiltered = kursova_carParkingDataSet.Vehicles
                    .AsEnumerable()
                    .Where(row => row.Field<int>("vehicle_id") == vehicleId);

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
    }
}
