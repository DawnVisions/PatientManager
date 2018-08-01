using System;

namespace PatientManager.Staff
{
	public class CoreNursery : Nurse
	{
        public CoreNursery(string name) : base(name)
        {
            MyRoles.Add(Roles.Nursery);
            MyRoles.Add(Roles.NICU);
            MyRoles.Add(Roles.Intermediate);
            MyRoles.Add(Roles.OnCall);
            MyRoles.Add(Roles.Pulled);
            MyRoles.Add(Roles.Other);
        }
    }
}
