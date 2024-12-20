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
    public partial class editTariffsForm : Form
    {
        public bool IsChanged { get; private set; } = false;
        private readonly int id;
        readonly bool edit;
        public editTariffsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
            edit = false;
        }


        /// <param name="tariffID">Номер тарифу</param>
        /// <param name="dayCoeff">Денний коефіцієнт</param>
        /// <param name="nightCoeff">Нічний коефіцієнт</param>
        /// <param name="monthCoeff">Опис (локація)</param>
        
        public editTariffsForm(int tariffID, decimal dayCoeff,
            decimal nightCoeff, decimal monthCoeff) : this() 
        {
            tariffsTableAdapter.Fill(kursova_carParkingDataSet.Tariffs);
            edit = true;
            textBox_tariffID.Text = tariffID.ToString();
            textBox_dayCoeff.Text = dayCoeff.ToString();
            textBox_nightCoeff.Text = nightCoeff.ToString();
            textBox_monthCoeff.Text = monthCoeff.ToString();
        }

        private void editTariffsForm_Load(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                tariffsTableAdapter.UpdateQuery(
                    Convert.ToDecimal(textBox_dayCoeff.Text),  
                    Convert.ToDecimal(textBox_nightCoeff.Text), 
                    Convert.ToDecimal(textBox_monthCoeff.Text), 
                    Convert.ToInt32(textBox_tariffID.Text));
            }
            else 
            {
                tariffsTableAdapter.InsertQuery(
                    Convert.ToDecimal(textBox_dayCoeff.Text),
                    Convert.ToDecimal(textBox_nightCoeff.Text),
                    Convert.ToDecimal(textBox_monthCoeff.Text));
            }
            IsChanged = true;
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
