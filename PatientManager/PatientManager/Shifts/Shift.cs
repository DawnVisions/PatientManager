using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
	public class Shift
	{
        public enum DayOrNight { Days, Nights}

        public enum PPRoles { CCL, Floor, Nursery, OnCall, Recovery, Pulled, Ill, Other}

        public enum PCTRoles { HUA, PCT}

        public enum NsyRoles { Nursery, NsyAdmit, NICU, Intermediate}

        public DayOrNight ThisShift { get;  }

        public List<PPAssignment> PPShiftAssignments { get; set; }

		public List<NsyAssignment> NsyShiftAssignments { get; set; }

		public List<PCTAssignment> PCTShiftAssignments { get; set; }

        public Shift (DayOrNight shift)
        {
            ThisShift = shift;
        }

        public override string ToString()
        {
            return ThisShift.ToString();
        }
    }
}
