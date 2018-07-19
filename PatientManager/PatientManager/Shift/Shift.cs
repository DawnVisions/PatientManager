using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public abstract class Shift
	{
		public List<CorePostpartum> PPNursesScheduled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<CoreNursery> NBNScheduled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<Nurse> OnCall
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<PCT> PCTs
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
