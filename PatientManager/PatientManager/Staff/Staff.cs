using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Shift;

namespace PatientManager.Staff
{
	public abstract class Staff
	{
		public string Name { get; set; }

		public bool CanOrient { get; set; }

        List<IRole> MyRoles;
	}
}
