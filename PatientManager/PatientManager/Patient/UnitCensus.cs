using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class UnitCensus
	{
		public static int Capacity = 27;

		public int TotalPatients
		{
			get
			{
				return DeliveredPatients.Count;
			}
		}

		public int NurseryCount
		{
			get
			{
                int total = DeliveredPatients.Count;
                foreach (Patient patient in DeliveredPatients)
                {
                    if (patient.NICU)
                        total--;
                }
                return total;
			}
			set
			{
                NurseryCount = value;
			}
		}

		public int MinNursesNeeded
		{
			get
			{
                return (DeliveredPatients.Count + AnticipatedPatients.Count) / 4;
			}
			set
			{
                MinNursesNeeded = value;
			}
		}

		public List<Newborn> NurseryCensus
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

        public List<DeliveredPatient> DeliveredPatients = new List<DeliveredPatient>();
        public List<AnticipatedPatient> AnticipatedPatients = new List<AnticipatedPatient>();

        public bool DischargePatient(DeliveredPatient patient)
		{
            patient.Room.Available = true;
            if (DeliveredPatients.Remove(patient))
                return true;
            else
                return false;
		}

        public bool AddAnticipatedPatient(AnticipatedPatient patient)
        {
            AnticipatedPatients.Add(patient);
            patient.PreAssignedRoom.Available = false;
            return true;
        }

        public bool AddDeliveredPatient(DeliveredPatient patient)
        {
            DeliveredPatients.Add(patient);
            patient.Room.Available = false;
            return true;
        }

		public UnitCensus()
		{
			
		}
	}
}
