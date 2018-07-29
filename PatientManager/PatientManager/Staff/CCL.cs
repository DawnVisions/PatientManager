using System;

namespace PatientManager.Staff
{
	public class CCL : Nurse
	{
		public CCL(string name) : base (name)
		{
            MyRoles.Add(Roles.Postpartum);
            MyRoles.Add(Roles.Unlicensed);
            MyRoles.Add(Roles.Nursery);
		}
	}
}
