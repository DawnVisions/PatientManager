using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManager.Patients;
using PatientManager.Shift;

namespace PatientManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            UpdateLabels();

            StartNewDay();

            //Sets up data source for delivered patient and anticipated patient data grids
            anticipatedPatientBindingSource.DataSource = FamilySuites.AnticipatedPatients;
            deliveredPatientBindingSource.DataSource = FamilySuites.DeliveredPatients;
        }

        Shift.Day today = new Shift.Day(DateTime.Today);

        static UnitCensus FamilySuites = new UnitCensus();

        List<Room> AllRooms = CreateRooms();
        static List<Room> CreateRooms()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(5620, showerRoom: false));
            rooms.Add(new Room(5621, showerRoom: true));
            rooms.Add(new Room(5622, showerRoom: false));
            rooms.Add(new Room(5624, showerRoom: false));
            rooms.Add(new Room(5625, showerRoom: true));
            rooms.Add(new Room(5626, showerRoom: false));
            rooms.Add(new Room(5627, showerRoom: false));
            return rooms;
        }

        void UpdateLabels()
        {
            PPCensusLabel.Text = FamilySuites.TotalPatients.ToString();
            NsyCensusLabel.Text = FamilySuites.NurseryCount.ToString();
            MinNursesLabel.Text = FamilySuites.MinNursesNeeded().ToString();
            DischargesLabel.Text = today.DischargesScheduled(FamilySuites.DeliveredPatients).ToString();
            today.UpdateLOS(FamilySuites.DeliveredPatients);
        }

        void StartNewDay()
        {
            DayLabel.Text = today.ToString();
            ShiftLabel.Text = today.Days.ToString();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            FormAddPatient newPatient = new FormAddPatient(AllRooms);
            newPatient.SavedPatient += AddPatient_SavedPatient;
            newPatient.Show();
        }

        private void AddPatient_SavedPatient(object sender, SavedPatientEventArgs e)
        {
            if (e.Patient is AnticipatedPatient anticipatedPatient)
            {
                FamilySuites.AddAnticipatedPatient(anticipatedPatient);
            }
            else if (e.Patient is DeliveredPatient deliveredPatient)
            {
                FamilySuites.AddDeliveredPatient(deliveredPatient);
            }
            UpdateLabels();
        }

        private void DischargeButton_Click(object sender, EventArgs e)
        {
            var selectedRows = DeliveredGrid.SelectedRows;
            if (selectedRows == null)
            {
                MessageBox.Show("No patient selected.");
                return;
            }

            DeliveredPatient patient = DeliveredGrid.CurrentRow.DataBoundItem as DeliveredPatient;
            if (patient == null) return;

            FamilySuites.DischargePatient(patient);
            UpdateLabels();
        }

        //Edit anticipated patient or change to delivered patient
        private void AnticipatedGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AnticipatedPatient patientToEdit = AnticipatedGrid.CurrentRow.DataBoundItem as AnticipatedPatient;
            FamilySuites.AnticipatedPatients.Remove(patientToEdit);
            FormAddPatient editPatient = new FormAddPatient(AllRooms, patientToEdit);
            editPatient.SavedPatient += AddPatient_SavedPatient;
            editPatient.Show();
        }

        private void StaffOnShiftButton_Click(object sender, EventArgs e)
        {
            FormStaffOnShift shiftStaff = new FormStaffOnShift();
            shiftStaff.Show();
        }
    }
}
