using System;
using PatientManager.Shifts;

namespace PatientManager.Staff
{
	public abstract class Nurse : Staff
	{
        protected Nurse (string name) : base (name)
        {

        }
		
	}
}
