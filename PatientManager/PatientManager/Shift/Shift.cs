using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public class Shift
	{
        public CCL ClinicalCareLeader { get; set; }

        public List<CorePostpartum> PPNursesScheduled { get; set; }

		public List<CoreNursery> NBNScheduled { get; set; }

		public List<Nurse> OnCall { get; set; }

		public List<PCT> PCTs { get; set; }

        public Shift(CCL Leader, List<CorePostpartum> PPnurses, List<CoreNursery> NsyNurses, List<PCT> Unlicensed)
        {
            this.ClinicalCareLeader = Leader;
            this.PPNursesScheduled = PPnurses;
            this.NBNScheduled = NsyNurses;
            this.PCTs = Unlicensed; 
        }

        public Shift(CCL Leader, List<CorePostpartum> PPnurses, List<CoreNursery> NsyNurses, List<PCT> unlicensed, List<Nurse> onCall)
        {
            this.ClinicalCareLeader = Leader;
            this.PPNursesScheduled = PPnurses;
            this.NBNScheduled = NsyNurses;
            this.PCTs = unlicensed;
            this.OnCall = onCall;
        }
    }
}
