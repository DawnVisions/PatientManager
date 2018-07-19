using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManager.Patients;


namespace PatientManager
{
    public partial class AddPatient : Form
    {
        UnitCensus FamilySuites;
        public AddPatient(List<Room> AllRooms, UnitCensus FamilySuites)
        {
            InitializeComponent();
            foreach (Room room in AllRooms)
            {
                if (room.Available)
                {
                    roomBox.Items.Add(room.RoomNumber);
                }
            }
            this.FamilySuites = FamilySuites;
        }

        void AddToAnticipatedCensus(AnticipatedPatient patient)
        {
            FamilySuites.AnticipatedPatients.Add(patient);
        }

        void AddToArrivedCensus(DeliveredPatient patient)
        {
            FamilySuites.DeliveredPatients.Add(patient);
            patient.Room.Available = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DeliveryType type;
            if (vagRadio.Checked)
            {
                type = new Vag();
            }
            else if (csRadio.Checked)
            {
                type = new CSection();
            }
            else
            {
                type = new Gyn();
            }
            if (anticipatedRadio.Checked)
            {
                AnticipatedPatient newPatient = new AnticipatedPatient(
                    nameBox.Text, 
                    AttendingBox.Text, 
                    nicuCheck.Checked, 
                    confidCheck.Checked, 
                    nonEngCheck.Checked, 
                    pihCheck.Checked, 
                    medicaidCheck.Checked, 
                    type);
                AddToAnticipatedCensus(newPatient);
                this.Close();
            }
            else if (deliveredRadio.Checked)
            {
                DeliveredPatient newPatient = new DeliveredPatient(
                    nameBox.Text, 
                    AttendingBox.Text, 
                    nicuCheck.Checked, 
                    confidCheck.Checked, 
                    nonEngCheck.Checked, 
                    pihCheck.Checked, 
                    medicaidCheck.Checked, 
                    type, 
                    deliveryDate.Value, 
                    (Room)roomBox.SelectedItem);
                AddToArrivedCensus(newPatient);
                this.Close();
            }
            else
            {
                typeGroup.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        private void anticipatedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (anticipatedRadio.Checked)
            {
                deliveryDate.Visible = false;
                delivDate.Visible = false;
            }
            else
            {
                delivDate.Visible = true;
                deliveryDate.Visible = true;
            }
        }
    }
}
