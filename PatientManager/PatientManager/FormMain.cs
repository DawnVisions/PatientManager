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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            anticipatedPatientBindingSource.DataSource= FamilySuites.AnticipatedPatients;
            deliveredPatientBindingSource.DataSource = FamilySuites.DeliveredPatients;
        }

        List<Room> AllRooms = CreateRooms();
        static UnitCensus FamilySuites = new UnitCensus();
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
            FormAddPatient newPatient = new FormAddPatient(AllRooms, FamilySuites);
            newPatient.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            anticipatedPatientBindingSource.ResetBindings(false);
            deliveredPatientBindingSource.ResetBindings(false);
        }

        private void DischargeButton_Click(object sender, EventArgs e)
        {
            if (DeliveredGrid.SelectedRows == null)
            {
                MessageBox.Show("No patient selected");
            }
            else
            {
                DeliveredPatient patient = (DeliveredPatient)DeliveredGrid.CurrentRow.DataBoundItem;
                {
                    if (FamilySuites.DischargePatient(patient))
                        MessageBox.Show(patient.LastName + " discharged");
                    else
                        MessageBox.Show("Unable to complete discharge");
                }
            }
        }

        //Edit anticipated patient or change to delivered patient
        private void AnticipatedGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AnticipatedPatient patientToEdit = (AnticipatedPatient)AnticipatedGrid.CurrentRow.DataBoundItem;
            patientToEdit.PreAssignedRoom.Available = true;
            FormAddPatient editPatient = new FormAddPatient(AllRooms, FamilySuites);
            editPatient.EditPatient(patientToEdit);
            editPatient.Show();
        }
    }
}
