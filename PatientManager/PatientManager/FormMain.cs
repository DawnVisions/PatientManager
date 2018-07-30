using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManager.Patients;
using PatientManager.Shifts;

namespace PatientManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            ThisDay = new Shifts.Day(DateTime.Today);
            CurrentShift = NewShift();

            UpdateLabels();

            //Sets up data source for delivered patient and anticipated patient data grids
            anticipatedPatientBindingSource.DataSource = FamilySuites.AnticipatedPatients;
            deliveredPatientBindingSource.DataSource = FamilySuites.DeliveredPatients;
            pPAssignmentBindingSource.DataSource = CurrentShift.PPShiftAssignments;
        }

        public Shifts.Day _thisDay;
        public Shifts.Day ThisDay
        {
            get { return _thisDay; }
            set
            {
                _thisDay = value;
                DayLabel.Text = _thisDay.ToString();
                _thisDay.UpdateLOS(FamilySuites.DeliveredPatients);
                UpdateLabels();
                DeliveredGrid.Refresh();
            }
        }

        private Shift _currentShift;
        public Shift CurrentShift
        {
            get { return _currentShift; }
            set
            {
                _currentShift = value;
                ShiftLabel.Text = CurrentShift.ToString();
            }
        }

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
            DischargesLabel.Text = ThisDay.DischargesScheduled(FamilySuites.DeliveredPatients).ToString();
        }

        Shift NewShift()
        {
            if (CurrentShift == null)
            {
                CurrentShift = ThisDay.Days;
            }
            else if (CurrentShift.ThisShift == Shift.DayOrNight.Nights)
            {
                ThisDay = new Shifts.Day(ThisDay.Date.AddDays(1));
                CurrentShift = ThisDay.Days;
            }
            else
            {
                CurrentShift = ThisDay.Nights;
            }
            return CurrentShift;
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
            FormStaffOnShift shiftStaff = new FormStaffOnShift(CurrentShift);
            shiftStaff.Show();
        }

        private void EditAnticipatedButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs ea = new DataGridViewCellEventArgs(0,0);
            AnticipatedGrid_CellDoubleClick(sender, ea);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            NewShift();
        }
    }
}
