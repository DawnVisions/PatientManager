using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Shifts;

namespace PatientManager.Staff
{
	public class PCT : Staff
	{
        public PCT(string name) : base(name)
        {
            MyRoles.Add(Roles.PCT);
            MyRoles.Add(Roles.HUA);
            MyRoles.Add(Roles.Other);
        }
    }
}
