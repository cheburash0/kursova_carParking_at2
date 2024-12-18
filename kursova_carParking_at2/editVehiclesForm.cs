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
    public partial class editVehiclesForm : Form
    {
        private readonly int id;
        readonly bool edit;
        public editVehiclesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            vehiclesTableAdapter.Fill(kursova_carParkingDataSet.Vehicles);
            edit = false;
        }

        /// <param name="id">Номер т/з</param>
        /// <param name="clientID">Номер клієнта</param>
        /// <param name="licencePlate">Номерний знак</param>
        /// <param name="model">Марка та модель</param>
        /// <param name="color">Колір</param>
        /// <param name="vehicleType">Тип т/з</param>
        
        public editVehiclesForm (int id, int clientID, 
            string licencePlate, string model, string color, string vehicleType): this()
        {
            vehiclesTableAdapter.Fill(kursova_carParkingDataSet.Vehicles);
            edit = true;
            textBox_vehicleID.Text = id.ToString();
            textBox_clientID.Text = clientID.ToString();
            textBox_licencePlate.Text = licencePlate.ToString();
            textBox_model.Text = model.ToString();
            textBox_color.Text = color.ToString();
            comboBox_vehicleType.Text = vehicleType.ToString();
        }

        private void editVehiclesForm_Load(object sender, EventArgs e)
        {
            LoadAboutVehiclesData();
        }

        private void LoadAboutVehiclesData()
        {
            try
            {
                // Создаем новый DataTable для хранения результата SQL-запроса
                var aboutVehiclesTable = new DataTable();

                // Создаем SQL-запрос для объединения таблиц Clients и Vehicles
                string query = @"
                    SELECT Vehicles.client_id, Clients.first_name, 
                           Vehicles.vehicle_id, Vehicles.model, Vehicles.licence_plate
                    FROM Vehicles
                    JOIN Clients ON Vehicles.client_id = Clients.client_id";

                // Используем SqlDataAdapter для выполнения запроса
                using (var connection = new System.Data.SqlClient.SqlConnection(vehiclesTableAdapter.Connection.ConnectionString))
                using (var adapter = new System.Data.SqlClient.SqlDataAdapter(query, connection))
                {
                    adapter.Fill(aboutVehiclesTable);
                }

                // Привязываем результат запроса к dataGridView_aboutVehicles
                dataGridView_aboutVehicles.DataSource = aboutVehiclesTable;
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
                vehiclesTableAdapter.UpdateQuery(Convert.ToInt32(textBox_clientID.Text),
                    textBox_licencePlate.Text,
                    textBox_model.Text,
                    textBox_color.Text,
                    comboBox_vehicleType.Text,
                    Convert.ToInt32(textBox_vehicleID.Text));
            }
            else 
            {
                vehiclesTableAdapter.InsertQuery(Convert.ToInt32(textBox_clientID.Text),
                    textBox_licencePlate.Text,
                    textBox_model.Text,
                    textBox_color.Text,
                    comboBox_vehicleType.Text);
            }
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_aboutVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
