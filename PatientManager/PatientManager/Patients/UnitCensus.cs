using System;
using System.ComponentModel;
using System.Linq;

namespace PatientManager.Patients
{
	public class UnitCensus
	{
		public BindingList<DeliveredPatient> DeliveredPatients = new BindingList<DeliveredPatient>();

        public BindingList<AnticipatedPatient> AnticipatedPatients = new BindingList<AnticipatedPatient>();

        public static int Capacity = 27;

		public int TotalPatients => DeliveredPatients.Count;

		public int NurseryCount
		{
			get
			{
                int total = DeliveredPatients.Count;
                foreach (Patient patient in DeliveredPatients)
                {
                    if (patient.NICU) total--;
                }
                return total;
			}
		}

		public int MinNursesNeeded
		{
			get => (DeliveredPatients.Count + AnticipatedPatients.Count) / 4;
		}

        public void AddAnticipatedPatient(AnticipatedPatient patient)
        {
            AnticipatedPatients.Add(patient);
        }

        public void AddDeliveredPatient(DeliveredPatient patient)
        {
            DeliveredPatients.Add(patient);
        }

        public void DischargePatient(DeliveredPatient patient)
        {
            patient.Discharge();
            DeliveredPatients.Remove(patient);
        }
	}
}
