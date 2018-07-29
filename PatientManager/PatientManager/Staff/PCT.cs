using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Shift;

namespace PatientManager.Staff
{
	public class PCT : Staff
	{
        public PCT(string name) : base(name)
        {
            MyRoles.Add(Roles.Unlicensed);
        }
    }
}
