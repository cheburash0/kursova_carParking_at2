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
    public partial class editPaymentsForm : Form
    {
        public Action RefreshPaymentsData { get; set; }
        public bool IsChanged { get; private set; } = false;
        private readonly int id;
        readonly bool edit;
        public editPaymentsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
            parkingTableAdapter.Fill(kursova_carParkingDataSet.Parking);
            spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces);
            tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
            edit = false;
        }

        /// <param name="paymentID">Номер платежа</param>
        /// <param name="amount">Сума</param>
        /// <param name="paymentDate">Дата платежа</param>
        /// <param name="parkingID">Номер паркування</param>

        public editPaymentsForm(int paymentID, decimal amount,
            DateTime paymentDate, int parkingID) : this() 
        {
            paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
            edit = true;
            textBox_paymentID.Text = paymentID.ToString();
            textBox_amount.Text = amount.ToString();    
            textBox_paymentDate.Text = paymentDate.ToString("dd.MM.yyyy");
            textBox_parkingID.Text = parkingID.ToString();
        }

        private decimal CalculateAmount(int parkingId)
        {
            try
            {
                // 1. Получить данные о парковочной сессии (Parking)
                var parkingRow = kursova_carParkingDataSet.Parking
                    .AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("parking_id") == parkingId);

                if (parkingRow == null)
                    throw new Exception("Паркувальна сесія не знайдена!");

                int spaceId = parkingRow.Field<int>("space_id");
                string startDateTimeString = $"{parkingRow.Field<DateTime>("start_date").ToString("dd.MM.yyyy")} {parkingRow.Field<TimeSpan>("start_time").ToString(@"hh\:mm\:ss")}";
                string endDateTimeString = $"{parkingRow.Field<DateTime>("end_date").ToString("dd.MM.yyyy")} {parkingRow.Field<TimeSpan>("end_time").ToString(@"hh\:mm\:ss")}";

                DateTime startDateTime = DateTime.ParseExact(startDateTimeString, "dd.MM.yyyy HH:mm:ss", null);
                DateTime endDateTime = DateTime.ParseExact(endDateTimeString, "dd.MM.yyyy HH:mm:ss", null);

                // 2. Получить данные о месте (Spaces)
                var spaceRow = kursova_carParkingDataSet.Spaces
                    .AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("space_id") == spaceId);

                if (spaceRow == null)
                    throw new Exception("Інформацію про місце не знайдено!");

                int tariffId = spaceRow.Field<int>("tariff_id");
                decimal pricePerHour = spaceRow.Field<decimal>("price_per_hour");

                // 3. Получить коэффициенты тарифа (Tariffs)
                var tariffRow = kursova_carParkingDataSet.Tariffs
                    .AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("tariff_id") == tariffId);

                if (tariffRow == null)
                    throw new Exception("Інформація про тариф не знайдена!");

                decimal dayCoefficient = tariffRow.Field<decimal>("day_coefficient");
                decimal nightCoefficient = tariffRow.Field<decimal>("night_coefficient");
                decimal monthCoefficient = tariffRow.Field<decimal>("month_coefficient");

                // 4. Расчет количества часов
                TimeSpan totalDuration = endDateTime - startDateTime;
                int totalHours = (int)totalDuration.TotalHours;

                int dayHours = 0;
                int nightHours = 0;

                DateTime current = startDateTime;
                for (int i = 0; i < totalHours; i++)
                {
                    if (current.Hour >= 6 && current.Hour < 22) // Дневное время
                        dayHours++;
                    else // Ночное время
                        nightHours++;

                    current = current.AddHours(1);
                }

                // 5. Расчет стоимости
                decimal dayCost = dayHours * pricePerHour * dayCoefficient;
                decimal nightCost = nightHours * pricePerHour * nightCoefficient;
                decimal totalCost = dayCost + nightCost;

                // Применяем месячный коэффициент, если парковка длилась более 30 дней
                if (totalDuration.TotalDays > 30)
                    totalCost *= monthCoefficient;

                return totalCost;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час розрахунку суми: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int parkingId = Convert.ToInt32(textBox_parkingID.Text);

                // Рассчитываем сумму
                decimal amount = CalculateAmount(parkingId);

                if (edit)
                {
                    paymentsTableAdapter.UpdateQuery(
                        amount, // Рассчитанная сумма
                        Convert.ToDateTime(textBox_paymentDate.Text),
                        parkingId,
                        Convert.ToInt32(textBox_paymentID.Text));
                }
                else
                {
                    // Добавляем новую запись, не указывая payment_id
                    paymentsTableAdapter.InsertQuery(
                        amount, // Рассчитанная сумма
                        Convert.ToDateTime(textBox_paymentDate.Text),
                        parkingId);

                    // После вставки обновляем данные для получения нового идентификатора
                    paymentsTableAdapter.Fill(kursova_carParkingDataSet.Payments);
                }

                IsChanged = true;
                RefreshPaymentsData?.Invoke();
                MessageBox.Show("Оплата успішно додана/оновлена!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час збереження оплати: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editPaymentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
