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
    public partial class SpacesForm : Form
    {
        public SpacesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void spacesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spacesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursova_carParkingDataSet);

        }

        private void SpacesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Spaces". При необходимости она может быть перемещена или удалена.
            this.spacesTableAdapter.Fill(this.kursova_carParkingDataSet.Spaces);

        }

        private bool edit;
        private void ApplySortingOrFiltering()
        {
            // Якщо є активна фільтрація
            string selectedFilter = comboBox_spacesFilter.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedFilter) && selectedFilter != "Без фільтру")
            {
                comboBox_spacesFilter_SelectedIndexChanged(null, null);
            }

            // Якщо є активне сортування
            string selectedSort = comboBox_spacesSort.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSort) && selectedSort != "Без сортування")
            {
                comboBox_spacesSort_SelectedIndexChanged(null, null);
            }
        }

        private void button_addSpaces_Click(object sender, EventArgs e)
        {
            try
            {
                edit = false;
                var edt = new editSpacesForm(); // Форма для додавання/редагування місця
                edt.ShowDialog();

                // Перевіряємо, чи були зміни
                if (edt.IsChanged)
                {
                    spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces); // Заповнення даних паркувальних місць
                    MessageBox.Show("Паркувальне місце успішно додано або змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання/зміни паркувального місця:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editSpaces_Click(object sender, EventArgs e)
        {
            if (spacesDataGridView.SelectedRows.Count > 0)
            {
                edit = true;

                // Отримуємо ID місця з вибраного рядка
                int spaceId = Convert.ToInt32(spacesDataGridView.SelectedRows[0].Cells[0].Value);

                // Завантажуємо дані про місце
                var st = new kursova_carParkingDataSet.SpacesDataTable();
                spacesTableAdapter.FillBy(st, spaceId);

                if (st.Rows.Count > 0)
                {
                    object[] row = st.Rows[0].ItemArray;

                    // Відкриваємо форму редагування і передаємо дані
                    var edt = new editSpacesForm(
                        Convert.ToInt32(row[0]),   // space_id
                        row[1].ToString(),         // space_status
                        Convert.ToDecimal(row[2]), // price_per_hour
                        row[3].ToString(),         // location
                        Convert.ToInt32(row[4])    // tariff_id
                    );
                    edt.RefreshSpacesData = () =>
                    {
                        spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces); // Оновлюємо дані таблиці
                        ApplySortingOrFiltering(); // Застосовуємо сортування/фільтрацію, якщо було обрано
                    };

                    edt.ShowDialog();

                    // Якщо зміни були внесені, оновлюємо дані
                    if (edt.IsChanged)
                    {
                        spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces);
                        kursova_carParkingDataSet.AcceptChanges();
                        MessageBox.Show("Місце успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Місце не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Виберіть місце для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteSpaces_Click(object sender, EventArgs e)
        {
            if (spacesDataGridView.SelectedRows.Count > 0)
            {
                // Отримуємо ID місця
                int spaceId = Convert.ToInt32(spacesDataGridView.SelectedRows[0].Cells[0].Value);

                // Підтвердження видалення
                var result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити це місце?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Виконуємо видалення
                        spacesTableAdapter.DeleteQuery(spaceId);

                        // Оновлюємо дані
                        spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Місце успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка під час видалення місця:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть місце для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox_parkingSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_spacesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = comboBox_spacesSort.SelectedItem.ToString();

            // Сортування даних за обраним критерієм
            IEnumerable<DataRow> sortedRows = null;

            switch (sortOrder)
            {
                case "Ціна (за зростанням)": // Від мінімальної до максимальної ціни
                    sortedRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .OrderBy(row => row.Field<decimal>("price_per_hour"));
                    break;

                case "Ціна (за спаданням)": // Від максимальної до мінімальної ціни
                    sortedRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .OrderByDescending(row => row.Field<decimal>("price_per_hour"));
                    break;

                case "Без сортування": // Без сортування
                default:
                    sortedRows = kursova_carParkingDataSet.Spaces.AsEnumerable();
                    break;
            }

            // Оновлюємо dataGridView_spaces
            if (sortedRows != null && sortedRows.Any())
            {
                spacesDataGridView.DataSource = sortedRows.CopyToDataTable();
            }
            else
            {
                // Якщо даних немає, показуємо порожню таблицю
                spacesDataGridView.DataSource = kursova_carParkingDataSet.Spaces.Clone();
            }
        }

        private void comboBox_spacesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox_spacesFilter.SelectedItem.ToString();

            // Фільтрація даних на основі обраного критерію
            IEnumerable<DataRow> filteredRows = null;

            switch (selectedFilter)
            {
                case "Місце біля шлагбауму":
                    filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .Where(row => row.Field<string>("location").Equals("Місце біля шлагбауму", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Центральна частина":
                    filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .Where(row => row.Field<string>("location").Equals("Центральна частина", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Східна частина":
                    filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .Where(row => row.Field<string>("location").Equals("Східна частина", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Західна частина":
                    filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                        .Where(row => row.Field<string>("location").Equals("Західна частина", StringComparison.OrdinalIgnoreCase));
                    break;

                case "Без фільтру": // Показуємо всі записи
                default:
                    filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable();
                    break;
            }

            // Оновлюємо DataGridView
            spacesDataGridView.DataSource = filteredRows.Any()
                ? filteredRows.CopyToDataTable()
                : kursova_carParkingDataSet.Spaces.Clone();
        }

        private void textBox_spacesSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox_spacesSearch.Text.Trim();

            // Якщо поле пошуку порожнє, показуємо всі записи
            if (string.IsNullOrEmpty(filterText))
            {
                spacesDataGridView.DataSource = kursova_carParkingDataSet.Spaces;
                return;
            }

            // Виконуємо пошук за space_id, space_status або location
            var filteredRows = kursova_carParkingDataSet.Spaces.AsEnumerable()
                .Where(row =>
                {
                    // Перевірка, чи є введений текст числом (для space_id)
                    if (int.TryParse(filterText, out int spaceId))
                    {
                        return row.Field<int>("space_id") == spaceId;
                    }

                    // Пошук за текстовим співпадінням у space_status або location
                    return row.Field<string>("space_status").IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                           row.Field<string>("location").IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0;
                });

            // Відображення результатів у DataGridView
            spacesDataGridView.DataSource = filteredRows.Any()
                ? filteredRows.CopyToDataTable()
                : kursova_carParkingDataSet.Spaces.Clone();
        }
    }
}
