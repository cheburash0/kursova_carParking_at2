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
    }
}
