using System;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
    public class PPAssignment
    {
        public Nurse Nurse { get; }
        public Roles Assignment { get; set; }

        public PPAssignment(Nurse nurse)
        {
            Nurse = nurse;
        }

    }
}
