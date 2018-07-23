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
            SetUpDataGrid();
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

        void ShowAnticipatedPatients()
        {
            AnticipatedPatients.Items.Clear();
            foreach (Patient patient in FamilySuites.AnticipatedPatients)
            {
                AnticipatedPatients.Items.Add(patient.LastName);
            }
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            FormAddPatient newPatient = new FormAddPatient(AllRooms, FamilySuites, deliveredPatientBindingSource);
            newPatient.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ShowAnticipatedPatients();
        }

        void SetUpDataGrid()
        {
            //Fix columns on data grid
        }

        //Edit anticipated patient or change to delivered patient
        private void AnticipatedPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

            FormAddPatient newPatient = new FormAddPatient(AllRooms, FamilySuites, deliveredPatientBindingSource);
            newPatient.Show();
        }

        private void DischargeButton_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows == null)
            //{
            //    MessageBox.Show("No patient selected");
            //}
            //else
            //{
            //    DeliveredPatient patient = dataGridView1.SelectedRows;
            //    {
            //        if (FamilySuites.DischargePatient(patient))
            //            MessageBox.Show("{0} discharged", patient.LastName);
            //        else
            //            MessageBox.Show("Unable to complete discharge");
            //    }
            //}
        }
    }
}
