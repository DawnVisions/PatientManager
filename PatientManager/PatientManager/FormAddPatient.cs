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
    public class SavedPatientEventArgs : EventArgs
    {
        public Patient Patient { get; }

        public SavedPatientEventArgs(Patient patient)
        {
            Patient = patient;
        }
    }

    public partial class FormAddPatient : Form
    {
        public event EventHandler<SavedPatientEventArgs> SavedPatient;

        public FormAddPatient(List<Room> AllRooms, AnticipatedPatient existingPatient = null)
        {
            InitializeComponent();
            SetUpRoomComboBox(AllRooms);

            if (existingPatient != null)
            {
                LoadFromPatient(existingPatient);
            }
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
            IDeliveryType type;
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

            var patientType = existingPatient.AnticipatedDeliveryType.Type;
            if (patientType == PatientType.Vag) vagRadio.Checked = true;
            else if (patientType == PatientType.CS) csRadio.Checked = true;
            else if (patientType == PatientType.Gyn) gynButton.Checked = true;
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
    }
}
