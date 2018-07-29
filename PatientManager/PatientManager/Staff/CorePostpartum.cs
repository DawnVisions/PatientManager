using System;

namespace PatientManager.Staff
{
	public class CorePostpartum : Nurse
	{
        public CorePostpartum(string name, bool canWorkNursery) : base (name)
		{
            MyRoles.Add(Roles.Postpartum);
            MyRoles.Add(Roles.Unlicensed);
            if (canWorkNursery)
            {
                MyRoles.Add(Roles.Nursery);
            }
		}
    }
}
