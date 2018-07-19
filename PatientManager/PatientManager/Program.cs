using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManager.Patients;
using PatientManager.Shift;
using PatientManager.Staff;

namespace PatientManager
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            CreateRooms();
            UnitCensus FamilySuites = new UnitCensus();


            void CreateRooms()
            {
                Room rm5620 = new Room(5620, false);
                Room rm5621 = new Room(5621, true);
                Room rm5622 = new Room(5622, false);
                Room rm5624 = new Room(5624, false);
                Room rm5625 = new Room(5625, true);
                Room rm5626 = new Room(5626, false);
                Room rm5627 = new Room(5627, false);
            }
        }

    }
}
