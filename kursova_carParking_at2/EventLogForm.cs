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

        }

 
        private void EventLogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursova_carParkingDataSet.EventLog". При необходимости она может быть перемещена или удалена.
            this.eventLogTableAdapter.Fill(this.kursova_carParkingDataSet.EventLog);

        }
    }
}
