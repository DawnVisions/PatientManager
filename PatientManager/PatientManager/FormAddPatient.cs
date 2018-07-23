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

        //Setting up drop down box with only the available rooms
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            DeliveryType type;
            if (vagRadio.Checked)
            {
                type = new DeliveryType(DeliveryType.PatientType.Vag);
            }
            else if (csRadio.Checked)
            {
                type = new DeliveryType(DeliveryType.PatientType.CS);
            }
            else
            {
                type = new DeliveryType(DeliveryType.PatientType.Gyn);
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
                FamilySuites.AddAnticipatedPatient(newPatient);
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
                FamilySuites.AddDeliveredPatient(newPatient);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select Anticipated or Delivered Patient");
                typeGroup.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        public void EditPatient(AnticipatedPatient patient)
        {
            FamilySuites.AnticipatedPatients.Remove(patient);
            nameBox.Text = patient.LastName;
            anticipatedRadio.Checked = true;
            AttendingBox.Text = patient.Attending;
            nicuCheck.Checked = patient.NICU;
            confidCheck.Checked = patient.Confidential;
            nonEngCheck.Checked = patient.LanguageBarrier;
            pihCheck.Checked = patient.PIH;
            medicaidCheck.Checked = patient.Medicaid;
            if (patient.AnticipatedDeliveryType.ToString() == "Vag")
                vagRadio.Checked = true;
            else if (patient.AnticipatedDeliveryType.ToString() == "CS")
                csRadio.Checked = true;
            else if (patient.AnticipatedDeliveryType.ToString() == "Gyn")
                gynButton.Checked = true;
            AddButton.Visible = false;
            EditButton.Visible = true;
        }

        //Hide delivery date if patient is anticipated
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddButton_Click(sender, e);
        }
    }
}
