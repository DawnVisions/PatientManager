using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientManager.Patients;
using PatientManager.Shifts;
using PatientManager.Staff;

namespace PatientManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            ThisDay = new Shifts.Day(DateTime.Today);
            CurrentShift = NewShift();

            SetUpDataGridBinding();

            UpdateLabels();
        }

        static UnitCensus FamilySuites = new UnitCensus();

        void SetUpDataGridBinding()
        {
            anticipatedPatientBindingSource.DataSource = FamilySuites.AnticipatedPatients;
            deliveredPatientBindingSource.DataSource = FamilySuites.DeliveredPatients;
            CurrentNurseComboBox.ValueType = typeof(string);
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
            rooms.Add(new Room(5628, showerRoom: true));
            rooms.Add(new Room(5629, showerRoom: false));
            rooms.Add(new Room(5631, showerRoom: false));
            rooms.Add(new Room(5632, showerRoom: true));
            rooms.Add(new Room(5634, showerRoom: false));
            rooms.Add(new Room(5635, showerRoom: false));
            rooms.Add(new Room(5637, showerRoom: false));
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

        //Opens Add Patient Form
        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            FormAddPatient newPatient = new FormAddPatient(AllRooms, ThisDay.Date);
            newPatient.SavedPatient += AddPatient_SavedPatient;
            newPatient.Show();
        }

        //Adds patient to data grid from event triggered by Add Patient Form
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

        //Discharge patient button
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
            FormAddPatient editPatient = new FormAddPatient(AllRooms, ThisDay.Date, patientToEdit);
            editPatient.SavedPatient += AddPatient_SavedPatient;
            editPatient.Show();
        }  
        private void EditAnticipatedButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs ea = new DataGridViewCellEventArgs(0,0);
            AnticipatedGrid_CellDoubleClick(sender, ea);
        }
        
        //Go to form that adds staff to shift
        private void StaffOnShiftButton_Click(object sender, EventArgs e)
        {
            FormStaffOnShift shiftStaff = new FormStaffOnShift(CurrentShift);
            shiftStaff.ReturnedFromStaff += AddRoles_ReturnedFromStaff;
            shiftStaff.Show();
        }

        //Adds roles based on what roles the staff member can perform into drop down box
        private void AddRoles_ReturnedFromStaff(object sender, EventArgs e)
        {
            PPNurseRoles.ValueType = typeof(Roles);
            foreach (PPAssignment assignment in CurrentShift.PPShiftAssignments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(PPStaffGrid);
                row.Cells[0].Value = assignment.Nurse;
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)row.Cells[1];
                foreach (Roles role in assignment.Nurse.MyRoles)
                {
                    comboCell.Items.Add(role);
                }
                PPStaffGrid.Rows.Add(row);
            }
            NsyRoles.ValueType = typeof(Roles);
            foreach (NsyAssignment assignment in CurrentShift.NsyShiftAssignments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(NsyStaffGrid);
                row.Cells[0].Value = assignment.Nurse;
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)row.Cells[1];
                foreach (Roles role in assignment.Nurse.MyRoles)
                {
                    comboCell.Items.Add(role);
                }
                NsyStaffGrid.Rows.Add(row);
            }
            PCTRoles.ValueType = typeof(Roles);
            foreach (PCTAssignment assignment in CurrentShift.PCTShiftAssignments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(PctStaffGrid);
                row.Cells[0].Value = assignment.PCT;
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)row.Cells[1];
                foreach (Roles role in assignment.PCT.MyRoles)
                {
                    comboCell.Items.Add(role);
                }
                PctStaffGrid.Rows.Add(row);
            }
        }

        //Next shift button
        private void NextButton_Click(object sender, EventArgs e)
        {
            NewShift();
            SetUpDataGridBinding();
            NsyStaffGrid.Rows.Clear();
            PPStaffGrid.Rows.Clear();
            PctStaffGrid.Rows.Clear();
            for (int i = 0; i < DeliveredGrid.RowCount; i++)
            {
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)DeliveredGrid.Rows[i].Cells[10];
                comboCell.Items.Clear();
                comboCell.Items.Add("");
                comboCell.Value = "";
            }
        }

        //If nurse is working the floor, adds nurse to the combo box on the delivered patients data grid
        private void PPStaffGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CurrentNurseComboBox.Items.Clear();
            for(int i = 0; i < PPStaffGrid.RowCount; i++)
            {
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)PPStaffGrid.Rows[i].Cells[1];
                string selectedText = Convert.ToString(comboCell.FormattedValue.ToString());
                if (selectedText == "Floor")
                {
                    CurrentNurseComboBox.Items.Add(PPStaffGrid.Rows[i].Cells[0].Value.ToString());
                }
            }
        }
        
        //Sets LastName text color to red if the patient is confidential
        private void DeliveredGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i<DeliveredGrid.RowCount; i++)
            {
                DeliveredPatient patient = (DeliveredPatient)DeliveredGrid.Rows[i].DataBoundItem;
                if (patient.Confidential)
                {
                    DeliveredGrid.Rows[i].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
