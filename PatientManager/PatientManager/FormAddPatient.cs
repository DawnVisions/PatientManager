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
    public partial class FormAddPatient : Form
    {
        UnitCensus FamilySuites;
        public FormAddPatient(List<Room> AllRooms, UnitCensus FamilySuites)
        {
            InitializeComponent();
            SetUpRoomComboBox(AllRooms);
            this.FamilySuites = FamilySuites;
        }

        void SetUpRoomComboBox(List<Room> AllRooms)
        {
            List<Room> AvailableRooms = new List<Room>();
            foreach (Room room in AllRooms)
            {
                if (room.Available)
                {
                    AvailableRooms.Add(room);
                }
            }
            roomBox.DataSource = AvailableRooms;
            roomBox.DisplayMember = "RoomNumber";
        }

        void AddToAnticipatedCensus(AnticipatedPatient patient)
        {
            FamilySuites.AddAnticipatedPatient(patient);
            patient.PreAssignedRoom.Available = false;
        }

        void AddToArrivedCensus(DeliveredPatient patient)
        {
            FamilySuites.AddDeliveredPatient(patient);
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
                    (Room)roomBox.SelectedItem,
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
