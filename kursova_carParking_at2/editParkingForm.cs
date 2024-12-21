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
    public partial class editParkingForm : Form
    {
        private readonly int id;
        readonly bool edit;
        public editParkingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking);
            edit = false;
        }

        /// <param name="id">Номер паркування</param>
        /// <param name="spaceID">Номер місця</param>
        /// <param name="vehicleID">Номерний т/з</param>
        /// <param name="startDate">Дата початку паркування</param>
        /// <param name="startTime">Час початку паркування</param>
        /// <param name="endDate">Дата кінця паркування</param>
        /// <param name="endTime">Час кінця паркування</param>

        public editParkingForm(int id, int spaceID, int vehicleID,
            DateTime startDate, TimeSpan startTime, DateTime endDate, TimeSpan endTime) : this()
        {
            parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking);
            edit = true;    
            textBox_parkingID.Text = id.ToString();
            textBox_spaceID.Text = spaceID.ToString();
            textBox_vehicleID.Text = vehicleID.ToString();
            
            textBox_startDate.Text = startDate.ToString("dd/MM/yyyy");
            textBox_startTime.Text = startTime.ToString(@"hh\:mm\:ss");

            textBox_endDate.Text = endDate.ToString("dd/MM/yyyy");
            textBox_endTime.Text = endTime.ToString(@"hh\:mm\:ss");

        }
        private void editParkingForm_Load(object sender, EventArgs e)
        {
            LoadAboutSpacesData();
        }

        private void LoadAboutSpacesData()
        {
            try
            {
                // Создаем новый DataTable для результата SQL-запроса
                var aboutSpacesTable = new DataTable();

                // SQL-запрос для объединения Spaces, Parking, Vehicles и Clients
                string query = @"
            SELECT 
                Spaces.space_id, 
                Spaces.space_status AS space_status, 
                Clients.client_id, 
                Vehicles.vehicle_id
            FROM Spaces
            LEFT JOIN Parking ON Spaces.space_id = Parking.space_id
            LEFT JOIN Vehicles ON Parking.vehicle_id = Vehicles.vehicle_id
            LEFT JOIN Clients ON Vehicles.client_id = Clients.client_id";

                // Выполняем запрос и наполняем DataTable
                using (var connection = new System.Data.SqlClient.SqlConnection(parkingTableAdapter.Connection.ConnectionString))
                using (var adapter = new System.Data.SqlClient.SqlDataAdapter(query, connection))
                {
                    adapter.Fill(aboutSpacesTable);
                }

                // Привязываем результат запроса к dataGridView_aboutSpaces
                dataGridView_aboutSpaces.DataSource = aboutSpacesTable;

                // Настраиваем заголовки столбцов для удобства
                dataGridView_aboutSpaces.Columns["space_id"].HeaderText = "ID Місця";
                dataGridView_aboutSpaces.Columns["space_status"].HeaderText = "Статус";
                dataGridView_aboutSpaces.Columns["client_id"].HeaderText = "ID Клієнта";
                dataGridView_aboutSpaces.Columns["vehicle_id"].HeaderText = "ID ТЗ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час завантаження даних:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                string startDateTime = $"{textBox_startDate.Text} {textBox_startTime.Text}";
                string endDateTime = $"{textBox_endDate.Text} {textBox_endTime.Text}";
                DateTime startDateTimeParsed = DateTime.ParseExact(startDateTime, "dd.MM.yyyy HH:mm:ss", null);
                DateTime endDateTimeParsed = DateTime.ParseExact(endDateTime, "dd.MM.yyyy HH:mm:ss", null);
                DateTime currentDateTime = DateTime.Now;

                parkingTableAdapter.UpdateQuery(
                    Convert.ToInt32(textBox_spaceID.Text),
                    Convert.ToInt32(textBox_vehicleID.Text),
                    textBox_startDate.Text.ToString(),
                    textBox_startTime.Text.ToString(),
                    textBox_endDate.Text.ToString(),
                    textBox_endTime.Text.ToString(),
                    Convert.ToInt32(textBox_parkingID.Text));
                if (endDateTimeParsed < currentDateTime)
                {
                    spacesTableAdapter.UpdateStatus("Вільне", Convert.ToInt32(textBox_spaceID.Text));
                }
                else
                {
                    spacesTableAdapter.UpdateStatus("Зайняте", Convert.ToInt32(textBox_spaceID.Text));
                }
            }
            else
            {
                parkingTableAdapter.InsertQuery(
                    Convert.ToInt32(textBox_spaceID.Text),
                    Convert.ToInt32(textBox_vehicleID.Text),
                    textBox_startDate.Text.ToString(),
                    textBox_startTime.Text.ToString(),
                    textBox_endDate.Text.ToString(),
                    textBox_endTime.Text.ToString());
                spacesTableAdapter.UpdateStatus("Зайняте", Convert.ToInt32(textBox_spaceID.Text));
            }
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_aboutSpaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
