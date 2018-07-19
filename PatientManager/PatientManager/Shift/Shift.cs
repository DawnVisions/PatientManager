using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Shift
{
	public abstract class Shift
	{
		public List<Nurse> PPNursesScheduled
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

		public List<NurseryNurse> NBNScheduled
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
