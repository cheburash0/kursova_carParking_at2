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
    }
}
