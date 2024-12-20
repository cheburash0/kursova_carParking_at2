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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void buttonVehicles_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm();
            vehiclesForm.Show();
        }

        private void buttonParking_Click(object sender, EventArgs e)
        {
            ParkingForm parkingForm = new ParkingForm();
            parkingForm.Show();
        }

        private void buttonSpaces_Click(object sender, EventArgs e)
        {
            SpacesForm spacesForm = new SpacesForm();
            spacesForm.Show();
        }

        private void buttonTariffs_Click(object sender, EventArgs e)
        {
            TariffsForm tariffsForm = new TariffsForm();
            tariffsForm.Show();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.Show();
        }

        private void buttonEventLog_Click(object sender, EventArgs e)
        {
            EventLogForm eventLogForm = new EventLogForm();
            eventLogForm.Show();
        }
    }
}
