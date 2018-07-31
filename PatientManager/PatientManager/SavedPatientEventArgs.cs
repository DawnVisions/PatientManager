using System;
using PatientManager.Patients;

namespace PatientManager
{
    //Event fires when a patient is saved to update data grids on FormMain
    public class SavedPatientEventArgs : EventArgs
    {
        public Patient Patient { get; }
        public SavedPatientEventArgs(Patient patient)
        {
            Patient = patient;
        }
    }
}
