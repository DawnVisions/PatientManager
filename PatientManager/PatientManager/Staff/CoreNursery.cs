using System;

namespace PatientManager.Staff
{
	public class CoreNursery : Nurse
	{
        public CoreNursery(string name) : base(name)
        {
            MyRoles.Add(Roles.Nursery);
        }
    }
}
