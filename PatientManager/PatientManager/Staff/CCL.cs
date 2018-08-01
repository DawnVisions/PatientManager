using System;

namespace PatientManager.Staff
{
	public class CCL : Nurse
	{
		public CCL(string name) : base (name)
		{
            MyRoles.Add(Roles.CCL);
            MyRoles.Add(Roles.Floor);
            MyRoles.Add(Roles.OnCall);
            MyRoles.Add(Roles.Nursery);
            MyRoles.Add(Roles.Recovery);
            MyRoles.Add(Roles.Pulled);
            MyRoles.Add(Roles.PCT);
            MyRoles.Add(Roles.HUA);
            MyRoles.Add(Roles.Other);
        }
	}
}
