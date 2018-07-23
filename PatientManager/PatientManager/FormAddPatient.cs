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
        BindingSource deliveredPatientBindingSource;
        public FormAddPatient(List<Room> AllRooms, UnitCensus FamilySuites, BindingSource deliveredPatientBindingSource)
        {
            InitializeComponent();
            SetUpRoomComboBox(AllRooms);
            this.FamilySuites = FamilySuites;
            this.deliveredPatientBindingSource = deliveredPatientBindingSource;
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
                deliveredPatientBindingSource.Add(newPatient);
                this.Close();
            }
            else
            {
                typeGroup.ForeColor = System.Drawing.Color.Maroon;
            }
        }

        public void EditPatient(DeliveredPatient patient)
        {
            nameBox.Text = patient.LastName;
            AttendingBox.Text = patient.Attending;
            nicuCheck.Checked = patient.NICU;
            confidCheck.Checked = patient.Confidential;
            nonEngCheck.Checked = patient.LanguageBarrier;
            pihCheck.Checked = patient.PIH;
            medicaidCheck.Checked = patient.Medicaid;
            deliveryDate.Value = patient.DeliveryDate;
            //if (patient.DeliveryType == Vag)
            //    vagRadio.Checked = true;
            //else if (patient.DeliveryType == CSection)
            //    csRadio.Checked = true;
            //else if (patient.DeliveryType == Gyn)
                //gynButton.Checked = true;
            AddButton.Visible = false;
            EditButton.Visible = true;
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
