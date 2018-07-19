using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class UnitCensus
	{
		public const int Capacity = 27;

		public int TotalPatients
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

		public int NurseryCount
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

		public int MinNursesNeeded
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

		public List<DeliveredPatient> DeliveredPatients
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

        public List<AnticipatedPatient> AnticipatedPatients = new List<AnticipatedPatient>();

        public bool DischargePatient()
		{
			throw new NotImplementedException();
		}

        public bool AddAnticipatedPatient(AnticipatedPatient patient)
        {
            AnticipatedPatients.Add(patient);
            return true;
        }

		public UnitCensus()
		{
			throw new NotImplementedException();
		}
	}
}
