using System;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
    public class PPAssignment
    {
        public Nurse Nurse { get; }
        public Shift.PPRoles Assignment { get; set; }

        public PPAssignment(Nurse nurse)
        {
            Nurse = nurse;
        }

    }
}
