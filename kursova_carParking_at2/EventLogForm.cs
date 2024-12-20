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
    public partial class EventLogForm : Form
    {
        public EventLogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

 
        private void EventLogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.EventLog". При необходимости она может быть перемещена или удалена.
            this.eventLogTableAdapter.Fill(this.kursova_carParkingDataSet.EventLog);

        }
        private bool edit;
        private void button_addTariff_Click(object sender, EventArgs e)
        {
            try
            {
                var edt = new editEventLogForm(); // Форма для добавления записи в лог
                edt.ShowDialog();

                // Обновление данных после добавления
                eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog);
                MessageBox.Show("Запис до журналу успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час додавання запису до журналу:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editLog_Click(object sender, EventArgs e)
        {
            if (eventLogDataGridView.SelectedRows.Count > 0)
            {
                edit = true;

                // Получаем ID записи журнала из выбранной строки
                int logId = Convert.ToInt32(eventLogDataGridView.SelectedRows[0].Cells[0].Value);

                // Загружаем данные о записи журнала
                var st = new kursova_carParkingDataSet.EventLogDataTable();
                eventLogTableAdapter.FillBy(st, logId);

                if (st.Rows.Count > 0)
                {
                    object[] row = st.Rows[0].ItemArray;

                    // Открываем форму редактирования и передаем данные
                    var edt = new editEventLogForm(
                        Convert.ToInt32(row[0]),   // log_id
                        row[1].ToString(),         // log_type
                        Convert.ToDateTime(row[2]), // log_date
                        row[3].ToString(),         // log_description
                        Convert.ToInt32(row[4])    // client_id
                    );

                    edt.RefreshEventLogData = () =>
                    {
                        eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog); // Обновляем данные таблицы
                    };

                    edt.ShowDialog();

                    // Если изменения были внесены, обновляем данные
                    if (edt.IsChanged)
                    {
                        eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog);
                        kursova_carParkingDataSet.AcceptChanges();
                        MessageBox.Show("Запис журналу успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Запис журналу не знайдено для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис журналу для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteLog_Click(object sender, EventArgs e)
        {
            if (eventLogDataGridView.SelectedRows.Count > 0)
            {
                // Получаем ID записи журнала
                int logId = Convert.ToInt32(eventLogDataGridView.SelectedRows[0].Cells[0].Value);

                // Подтверждение удаления
                var result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цей запис?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем удаление
                        eventLogTableAdapter.DeleteQuery(logId);

                        // Обновляем данные
                        eventLogTableAdapter.Fill(kursova_carParkingDataSet.EventLog);
                        kursova_carParkingDataSet.AcceptChanges();

                        MessageBox.Show("Запис успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка під час видалення запису:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
