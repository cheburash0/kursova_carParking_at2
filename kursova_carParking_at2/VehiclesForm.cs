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
    }
}
