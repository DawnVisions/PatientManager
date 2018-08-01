using System;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
    public class PCTAssignment
    {
        public PCT PCT { get; }
        public Roles Assignment { get; set; }

        public PCTAssignment(PCT pct)
        {
            PCT = pct;
        }
    }
}
