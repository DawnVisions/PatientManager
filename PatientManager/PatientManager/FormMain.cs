using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManager.Patients;

namespace PatientManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            //Set up data source for delivered patient and anticipated patient grids
            anticipatedPatientBindingSource.DataSource = FamilySuites.AnticipatedPatients;
            deliveredPatientBindingSource.DataSource = FamilySuites.DeliveredPatients;
        }

        static UnitCensus FamilySuites = new UnitCensus();
        List<Room> AllRooms = CreateRooms();
        static List<Room> CreateRooms()
        {
            List<Room> rooms = new List<Room>();
            Room rm5620 = new Room(5620, false);
            Room rm5621 = new Room(5621, true);
            Room rm5622 = new Room(5622, false);
            Room rm5624 = new Room(5624, false);
            Room rm5625 = new Room(5625, true);
            Room rm5626 = new Room(5626, false);
            Room rm5627 = new Room(5627, false);
            rooms.Add(rm5620);
            rooms.Add(rm5621);
            rooms.Add(rm5622);
            rooms.Add(rm5624);
            rooms.Add(rm5625);
            rooms.Add(rm5626);
            rooms.Add(rm5627);
            return rooms;
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
    }
}
