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
    public partial class editSpacesForm : Form
    {
        private readonly int id;
        readonly bool edit;
        public editSpacesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces);
            edit = false;
        }

        /// <param name="spaceID">Номер місця</param>
        /// <param name="spaceStatus">Статус місця</param>
        /// <param name="pricePerHour">Ціна за годину</param>
        /// <param name="location">Опис (локація)</param>
        /// <param name="tariffID">Номер тарифу</param>

        public editSpacesForm(int spaceID, string spaceStatus, decimal pricePerHour,
            string location, int tariffID) : this() 
        {
            spacesTableAdapter.Fill(kursova_carParkingDataSet.Spaces);
            edit = true;
            textBox_spaceID.Text = spaceID.ToString();
            comboBox_spaceStatus.Text = spaceStatus.ToString();
            textBox_pricePerHour.Text = pricePerHour.ToString();
            textBox_location.Text = location;
            textBox_tariffNum.Text = tariffID.ToString();
        }

        public bool IsChanged { get; private set; }
        public Action RefreshSpacesData { get; set; }
        private void button_OK_Click(object sender, EventArgs e)
        {
            IsChanged = true;
            if (edit) // Якщо редагування
            {
                spacesTableAdapter.UpdateQuery(
                    comboBox_spaceStatus.Text, // Статус місця
                    Convert.ToDecimal(textBox_pricePerHour.Text), // Ціна за годину
                    textBox_location.Text, // Локація
                    Convert.ToInt32(textBox_tariffNum.Text), // Номер тарифу
                    Convert.ToInt32(textBox_spaceID.Text) // ID місця
                );
            }
            else // Якщо додавання
            {
                spacesTableAdapter.InsertQuery(
                    comboBox_spaceStatus.Text, // Статус місця
                    Convert.ToDecimal(textBox_pricePerHour.Text), // Ціна за годину
                    textBox_location.Text, // Локація
                    Convert.ToInt32(textBox_tariffNum.Text) // Номер тарифу
                );
            }
            RefreshSpacesData?.Invoke();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            IsChanged = false;
            Close();
        }
    }
}
