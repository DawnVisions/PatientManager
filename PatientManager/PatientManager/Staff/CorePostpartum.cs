using System;

namespace PatientManager.Staff
{
	public class CorePostpartum : Nurse
	{
        public CorePostpartum(string name, bool canWorkNursery) : base (name)
		{
            MyRoles.Add(Roles.Floor);
            MyRoles.Add(Roles.OnCall);
            MyRoles.Add(Roles.Recovery);
            MyRoles.Add(Roles.Pulled);
            MyRoles.Add(Roles.PCT);
            MyRoles.Add(Roles.HUA);
            MyRoles.Add(Roles.Other);
            if (canWorkNursery)
            {
                MyRoles.Add(Roles.Nursery);
            }
		}
    }
}
