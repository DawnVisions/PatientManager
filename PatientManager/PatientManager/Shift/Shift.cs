using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public class Shift
	{
        public enum DayOrNight { Days, Nights}

        public enum PPAssignments { CCL, Floor, Nursery, OnCall, Recovery, Pulled, Ill, Other}

        public enum PCTAssignments { HUA, PCT}

        public enum NsyAssignments { Nursery, NsyAdmit, NICU, Intermediate}

        public DayOrNight ThisShift { get;  }

        public List<Nurse> PPNursesScheduled { get; set; }

		public List<CoreNursery> NBNScheduled { get; set; }

		public List<PCT> PCTs { get; set; }

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
