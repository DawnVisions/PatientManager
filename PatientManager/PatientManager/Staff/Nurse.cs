using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Shift;
using PatientManager.Patients;

namespace PatientManager.Staff
{
	public abstract class Nurse
	{
		public bool CanWorkNursery
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

		public int MyPatientAcuity(Day day)
		{
			throw new NotImplementedException();
		}

		public List<Patient> MyPatients(Day day)
		{
			throw new NotImplementedException();
		}
	}
}
