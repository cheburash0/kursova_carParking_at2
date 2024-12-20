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
    public partial class TariffsForm : Form
    {
        public TariffsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tariffsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tariffsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursova_carParkingDataSet);
        }

        private void TariffsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.Tariffs". При необходимости она может быть перемещена или удалена.
            this.tariffsTableAdapter.Fill(this.kursova_carParkingDataSet.Tariffs);
        }

        private bool edit;
        private void button_addTariff_Click(object sender, EventArgs e)
        {
            try
            {
                var edt = new editTariffsForm(); // Форма для добавления/редактирования тарифа
                edt.ShowDialog();

                // Проверяем, были ли изменения
                if (edt.IsChanged)
                {
                    // Обновляем данные в DataGridView
                    tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
                    tariffsDataGridView.DataSource = kursova_carParkingDataSet.Tariffs; // Обновляем источник данных
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання/зміни тарифу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editTariff_Click(object sender, EventArgs e)
        {
            if (tariffsDataGridView.SelectedRows.Count > 0)
            {
                edit = true;

                // Отримуємо ID тарифу з вибраного рядка
                int tariffId = Convert.ToInt32(tariffsDataGridView.SelectedRows[0].Cells[0].Value);

                // Завантажуємо дані про тариф
                var st = new kursova_carParkingDataSet.TariffsDataTable();
                tariffsTableAdapter.FillBy(st, tariffId);

                if (st.Rows.Count > 0)
                {
                    object[] row = st.Rows[0].ItemArray;

                    // Відкриваємо форму редагування і передаємо дані
                    var edt = new editTariffsForm(
                        Convert.ToInt32(row[0]),   // tariff_id
                        Convert.ToDecimal(row[1]),         // tariff_name
                        Convert.ToDecimal(row[2]),
                        Convert.ToDecimal(row[3])// tariff_price
                    );

                    edt.ShowDialog();

                    // Якщо зміни були внесені, оновлюємо дані
                    if (edt.IsChanged)
                    {
                        tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
                        kursova_carParkingDataSet.AcceptChanges();
                        MessageBox.Show("Тариф успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Тариф не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Виберіть тариф для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteTariff_Click(object sender, EventArgs e)
        {
            if (tariffsDataGridView.SelectedRows.Count > 0)
            {
                // Отримуємо ID тарифу
                int tariffId = Convert.ToInt32(tariffsDataGridView.SelectedRows[0].Cells[0].Value);

                // Підтвердження видалення
                var result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цей тариф?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Виконуємо видалення
                        tariffsTableAdapter.DeleteQuery(tariffId);

                        // Оновлюємо дані
                        tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Тариф успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка під час видалення тарифу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть тариф для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
