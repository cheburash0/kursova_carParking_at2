using kursova_carParking_at2.kursova_carParkingDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kursova_carParking_at2
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonStatsTotalRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из адаптера и приводим к decimal
                object result = paymentsTableAdapter.GetTotalRevenue();
                decimal totalRevenue = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                // Создаем таблицу для вывода
                DataTable statsTable = new DataTable();
                statsTable.Columns.Add("Загальна виручка", typeof(decimal));
                statsTable.Rows.Add(totalRevenue);

                // Привязываем таблицу к DataGridView
                dataGridView_stats.DataSource = statsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatsSpaces_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-G5PU7L6;Database=kursova_carParking;Integrated Security=True;";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = @"
                SELECT space_status AS Статус, 
                       COUNT(*) AS Кількість, 
                       CAST(COUNT(*) * 100.0 / SUM(COUNT(*)) OVER() AS DECIMAL(10,2)) AS Відсоток 
                FROM Spaces 
                GROUP BY space_status";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable statsTable = new DataTable();
                    adapter.Fill(statsTable);

                    dataGridView_stats.DataSource = statsTable;
                

                // Устанавливаем заголовки столбцов
                dataGridView_stats.Columns[0].HeaderText = "Статус місця";
                    dataGridView_stats.Columns[1].HeaderText = "Кількість";
                    dataGridView_stats.Columns[2].HeaderText = "Відсоток";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatsTopClients_Click(object sender, EventArgs e)
        {
            try
            {
                // Строка подключения
                string connectionString = "Server=DESKTOP-G5PU7L6;Database=kursova_carParking;Integrated Security=True;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // SQL-запрос для получения самых активных клиентов
                    string query = @"
                    SELECT 
                        Clients.client_id AS [ID Клієнта],
                        Clients.first_name AS [Ім'я],
                        Clients.last_name AS [Прізвище],
                    COUNT(Parking.parking_id) AS [Кількість парковок],
                    SUM(Payments.amount) AS [Загальна сума оплат]
                    FROM Clients
                    JOIN Vehicles ON Clients.client_id = Vehicles.client_id
                    JOIN Parking ON Vehicles.vehicle_id = Parking.vehicle_id
                    LEFT JOIN Payments ON Parking.parking_id = Payments.parking_id
                    GROUP BY Clients.client_id, Clients.first_name, Clients.last_name
                    ORDER BY COUNT(Parking.parking_id) DESC, SUM(Payments.amount) DESC";

                    // Выполняем запрос и наполняем таблицу
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable statsTable = new DataTable();
                    adapter.Fill(statsTable);

                    // Привязываем данные к DataGridView
                    dataGridView_stats.DataSource = statsTable;

                    // Устанавливаем заголовки столбцов
                    dataGridView_stats.Columns[0].HeaderText = "ID Клієнта";
                    dataGridView_stats.Columns[1].HeaderText = "Ім'я";
                    dataGridView_stats.Columns[2].HeaderText = "Прізвище";
                    dataGridView_stats.Columns[3].HeaderText = "Кількість парковок";
                    dataGridView_stats.Columns[4].HeaderText = "Загальна сума оплат";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatsAvgTime_Click(object sender, EventArgs e)
        {
            try
            {
                // Строка подключения
                string connectionString = "Server=DESKTOP-G5PU7L6;Database=kursova_carParking;Integrated Security=True;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // SQL-запрос для расчета среднего времени парковки в часах
                    string query = @"
            SELECT 
                Clients.client_id AS [ID Клієнта],
                Clients.first_name AS [Ім'я],
                Clients.last_name AS [Прізвище],
                AVG(CAST(DATEDIFF(MINUTE, 
                    CAST(Parking.start_date AS DATETIME) + CAST(Parking.start_time AS DATETIME),
                    CAST(Parking.end_date AS DATETIME) + CAST(Parking.end_time AS DATETIME)
                ) AS FLOAT) / 60) AS [Середній час (години)]
            FROM Clients
            JOIN Vehicles ON Clients.client_id = Vehicles.client_id
            JOIN Parking ON Vehicles.vehicle_id = Parking.vehicle_id
            GROUP BY Clients.client_id, Clients.first_name, Clients.last_name
            ORDER BY [Середній час (години)] DESC";

                    // Выполняем запрос и наполняем таблицу
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable statsTable = new DataTable();
                    adapter.Fill(statsTable);

                    // Привязываем данные к DataGridView
                    dataGridView_stats.DataSource = statsTable;

                    // Устанавливаем заголовки столбцов
                    dataGridView_stats.Columns[0].HeaderText = "ID Клієнта";
                    dataGridView_stats.Columns[1].HeaderText = "Ім'я";
                    dataGridView_stats.Columns[2].HeaderText = "Прізвище";
                    dataGridView_stats.Columns[3].HeaderText = "Середній час (години)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Назва статистики для друку
                string statisticsTitle = "Статистика"; // Динамічно змінюється залежно від обраної статистики
                if (dataGridView_stats.Columns.Count > 0)
                {
                    if (dataGridView_stats.Columns[0].HeaderText.Contains("Виручка"))
                        statisticsTitle = "Загальна виручка";
                    else if (dataGridView_stats.Columns[0].HeaderText.Contains("Статус"))
                        statisticsTitle = "Статистика зайнятості місць";
                    else if (dataGridView_stats.Columns[0].HeaderText.Contains("Клієнта"))
                        statisticsTitle = "Найактивніші клієнти";
                    else if (dataGridView_stats.Columns[0].HeaderText.Contains("Час"))
                        statisticsTitle = "Середній час паркування";
                }

                // Дата та час друку
                string dateTimeNow = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                // Формування тексту для друку
                StringBuilder printContent = new StringBuilder();
                printContent.AppendLine($"Назва статистики: {statisticsTitle}");
                printContent.AppendLine($"Дата та час створення файлу: {dateTimeNow}");
                printContent.AppendLine(new string('-', 50));

                // Формування заголовків із вирівнюванням
                List<int> columnWidths = new List<int>();
                foreach (DataGridViewColumn column in dataGridView_stats.Columns)
                {
                    int width = column.HeaderText.Length > 15 ? column.HeaderText.Length + 2 : 15; // Мінімальна ширина 15
                    columnWidths.Add(width);
                    printContent.Append($"{column.HeaderText.PadRight(width)}");
                }
                printContent.AppendLine();
                printContent.AppendLine(new string('-', 50));

                // Додавання рядків даних
                foreach (DataGridViewRow row in dataGridView_stats.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                        printContent.Append($"{cellValue.PadRight(columnWidths[i])}");
                    }
                    printContent.AppendLine();
                }

                // Вибір місця збереження файлу
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt",
                    FileName = $"{statisticsTitle.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.txt",
                    Title = "Збереження статистики"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Запис у файл
                    File.WriteAllText(saveFileDialog.FileName, printContent.ToString());
                    MessageBox.Show($"Файл успішно збережено за адресою: {saveFileDialog.FileName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час збереження статистики: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
