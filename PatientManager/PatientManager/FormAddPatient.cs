using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManager.Patients;

namespace PatientManager
{
    public partial class FormAddPatient : Form
    {
        public event EventHandler<SavedPatientEventArgs> SavedPatient;

        public FormAddPatient(List<Room> AllRooms, AnticipatedPatient existingPatient = null)
        {
            InitializeComponent();
            deliveryDate.Value = DateTime.Today;
            SetUpRoomComboBox(AllRooms);
            if (existingPatient != null)
            {
                LoadFromPatient(existingPatient);
            }
        }

        private void LoadFromPatient(AnticipatedPatient existingPatient)
        {
            AddButton.Text = "Edit Patient";
            nameBox.Text = existingPatient.LastName;
            anticipatedRadio.Checked = true;
            AttendingBox.Text = existingPatient.Attending;
            nicuCheck.Checked = existingPatient.NICU;
            confidCheck.Checked = existingPatient.Confidential;
            nonEngCheck.Checked = existingPatient.LanguageBarrier;
            pihCheck.Checked = existingPatient.PIH;
            medicaidCheck.Checked = existingPatient.Medicaid;

            if (existingPatient.Room != null)
            {
                roomBox.SelectedItem = existingPatient.Room;
            }

            PatientTypesEnum patientType = existingPatient.AnticipatedDeliveryType.Type;
            if (patientType == PatientTypesEnum.Vag) vagRadio.Checked = true;
            else if (patientType == PatientTypesEnum.CS) csRadio.Checked = true;
            else if (patientType == PatientTypesEnum.Gyn) gynButton.Checked = true;
        }
        
        void SetUpRoomComboBox(List<Room> AllRooms) //Setting up drop down box with only the available rooms
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
            PatientType type;
            if (vagRadio.Checked)
            {
                type = new VagDeliveryType();
            }
            else if (csRadio.Checked)
            {
                type = new CSDeliveryType();
            }
            else
            {
                type = new GynDeliveryType();
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

                this.Close();
                SavedPatient?.Invoke(this, new SavedPatientEventArgs(newPatient));
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

                this.Close();
                SavedPatient?.Invoke(this, new SavedPatientEventArgs(newPatient));
            }
            else
            {
                MessageBox.Show("Please select Anticipated or Delivered Patient");
                typeGroup.ForeColor = System.Drawing.Color.Maroon;
            }
        }

       
        private void anticipatedRadio_CheckedChanged(object sender, EventArgs e) //Hides delivery date if patient is anticipated
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
