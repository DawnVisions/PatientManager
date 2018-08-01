using System;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
    public class NsyAssignment
    {
        public CoreNursery Nurse { get; }
        public Roles Assignment { get; set; }

        public NsyAssignment(CoreNursery nurse)
        {
            Nurse = nurse;
        }
    }
}
