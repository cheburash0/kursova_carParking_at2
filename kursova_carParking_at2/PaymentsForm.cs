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
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.kursova_carParkingDataSet.Payments);

        }

        private bool edit;
        private void ApplySortingOrFiltering()
        {
            // Если активен фильтр
            string selectedFilter = comboBox_paymentsFilter.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedFilter) && selectedFilter != "Без фільтру")
            {
                comboBox_paymentsFilter_SelectedIndexChanged(null, null);
            }

            // Если активна сортировка
            string selectedSort = comboBox_paymentsSort.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSort) && selectedSort != "Без сортування")
            {
                comboBox_paymentsSort_SelectedIndexChanged(null, null);
            }
        }
        private void button_addPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var edt = new editPaymentsForm
                {
                    RefreshPaymentsData = () =>
                    {
                        paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments); // Обновляем данные в таблице
                        ApplySortingOrFiltering(); // Применяем сортировку и фильтрацию, если они активны
                    }
                };

                edt.ShowDialog();

                if (edt.IsChanged)
                {
                    paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
                    ApplySortingOrFiltering();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання платежу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editPayment_Click(object sender, EventArgs e)
        {
            if (paymentsDataGridView.SelectedRows.Count > 0)
            {
                int paymentId = Convert.ToInt32(paymentsDataGridView.SelectedRows[0].Cells[0].Value);

                var st = new kursova_carParkingDataSet.PaymentsDataTable();
                paymentsTableAdapter.FillBy(st, paymentId);

                if (st.Rows.Count > 0)
                {
                    object[] row = st.Rows[0].ItemArray;

                    var edt = new editPaymentsForm(
                        Convert.ToInt32(row[0]),   // payment_id
                        Convert.ToDecimal(row[1]), // amount
                        Convert.ToDateTime(row[2]), // payment_date
                        Convert.ToInt32(row[3])    // parking_id
                    )
                    {
                        RefreshPaymentsData = () =>
                        {
                            paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
                            ApplySortingOrFiltering();
                        }
                    };

                    edt.ShowDialog();

                    if (edt.IsChanged)
                    {
                        paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
                        ApplySortingOrFiltering();
                    }
                }
                else
                {
                    MessageBox.Show("Платіж не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Виберіть платіж для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deletePayment_Click(object sender, EventArgs e)
        {
            if (paymentsDataGridView.SelectedRows.Count > 0)
            {
                // Получаем ID платежа
                int paymentId = Convert.ToInt32(paymentsDataGridView.SelectedRows[0].Cells[0].Value);

                // Подтверждение удаления
                var result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цей платіж?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем удаление
                        paymentsTableAdapter.DeleteQuery(paymentId);

                        // Обновляем данные
                        paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Платіж успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка під час видалення платежу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть платіж для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_paymentsSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_paymentsSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Если текст пустой, отображаем все данные
                paymentsDataGridView.DataSource = kursova_carParkingDataSet.Payments;
            }
            else
            {
                // Фильтруем строки на основе введенного текста
                var filteredRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                    .Where(row =>
                        row.Field<Decimal>("amount").ToString().Contains(searchText) ||
                        row.Field<DateTime>("payment_date").ToString("dd.MM.yyyy").Contains(searchText) ||
                        row.Field<int>("parking_id").ToString().Contains(searchText));

                // Отображаем отфильтрованные данные
                paymentsDataGridView.DataSource = filteredRows.Any()
                    ? filteredRows.CopyToDataTable()
                    : kursova_carParkingDataSet.Payments.Clone();
            }
        }

        private void comboBox_paymentsSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = comboBox_paymentsSort.SelectedItem.ToString();

            // Сортування даних за обраним критерієм
            IEnumerable<DataRow> sortedRows = null;

            switch (sortOrder)
            {
                case "Сума (за зростанням)": // Від мінімальної до максимальної суми
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderBy(row => row.Field<decimal>("amount"));
                    break;

                case "Сума (за спаданням)": // Від максимальної до мінімальної суми
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderByDescending(row => row.Field<decimal>("amount"));
                    break;

                case "Дата платежа (зростання)": // Від найдавнішої до найсвіжішої дати
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderBy(row => row.Field<DateTime>("payment_date"));
                    break;

                case "Дата платежа (спадання)": // Від найсвіжішої до найдавнішої дати
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderByDescending(row => row.Field<DateTime>("payment_date"));
                    break;

                case "Номер місця (за зростанням)": // Від найменшого до найбільшого parking_id
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderBy(row => row.Field<int>("parking_id"));
                    break;

                case "Номер місця (за спаданням)": // Від найбільшого до найменшого parking_id
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .OrderByDescending(row => row.Field<int>("parking_id"));
                    break;

                case "Без сортування": // Без сортування
                default:
                    sortedRows = kursova_carParkingDataSet.Payments.AsEnumerable();
                    break;
            }

            // Оновлюємо dataGridView_payments
            if (sortedRows != null && sortedRows.Any())
            {
                paymentsDataGridView.DataSource = sortedRows.CopyToDataTable();
            }
            else
            {
                // Якщо даних немає, показуємо порожню таблицю
                paymentsDataGridView.DataSource = kursova_carParkingDataSet.Payments.Clone();
            }
        }

        private void comboBox_paymentsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox_paymentsFilter.SelectedItem.ToString();

            // Фільтрація даних на основі обраного критерію
            IEnumerable<DataRow> filteredRows = null;

            switch (selectedFilter)
            {
                case "Сума > 5000": // Платежи с суммой больше 5000
                    filteredRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .Where(row => row.Field<decimal>("amount") > 5000);
                    break;

                case "Сума < 5000": // Платежи с суммой меньше 5000
                    filteredRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .Where(row => row.Field<decimal>("amount") < 5000);
                    break;

                case "Дата: Останній тиждень": // Платежи за последний неделю
                    DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
                    filteredRows = kursova_carParkingDataSet.Payments.AsEnumerable()
                        .Where(row => row.Field<DateTime>("payment_date") >= oneWeekAgo);
                    break;

                case "Без фільтру": // Показуємо всі записи
                default:
                    filteredRows = kursova_carParkingDataSet.Payments.AsEnumerable();
                    break;
            }

            // Оновлюємо DataGridView
            paymentsDataGridView.DataSource = filteredRows.Any()
                ? filteredRows.CopyToDataTable()
                : kursova_carParkingDataSet.Payments.Clone();
        }

        private void paymentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
