using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shifts
{
	public class Shift
	{
        public enum DayOrNight { Days, Nights}

        public enum PPRoles { CCL, Floor, Nursery, OnCall, Recovery, Pulled, HUA, PCT, Other}

        public enum PCTRoles { HUA, PCT}

        public enum NsyRoles { Nursery, NsyAdmit, NICU, Intermediate, Other}

        public DayOrNight ThisShift { get;  }

        public BindingList<PPAssignment> PPShiftAssignments { get; set; }

		public BindingList<NsyAssignment> NsyShiftAssignments { get; set; }

		public BindingList<PCTAssignment> PCTShiftAssignments { get; set; }

        public Shift (DayOrNight shift)
        {
            ThisShift = shift;
            PPShiftAssignments = new BindingList<PPAssignment>();
            NsyShiftAssignments = new BindingList<NsyAssignment>();
            PCTShiftAssignments = new BindingList<PCTAssignment>();
        }

        public override string ToString()
        {
            return ThisShift.ToString();
        }
    }
}
