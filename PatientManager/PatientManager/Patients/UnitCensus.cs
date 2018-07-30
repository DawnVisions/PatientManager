using System;
using System.ComponentModel;
using System.Linq;
using PatientManager.Patients;

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
                foreach (DeliveredPatient patient in DeliveredPatients)
                {
                    if (patient.NICU) total--;
                    if (patient.PatientType.Type == PatientTypesEnum.Gyn) total--;
                }
                return total;
			}
		}

        public int MinNursesNeeded()
        {
            int min = (int)Math.Ceiling((double)(DeliveredPatients.Count + AnticipatedPatients.Count) / 4);
            return min;
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
