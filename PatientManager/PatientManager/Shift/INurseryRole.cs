using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public interface INurseryRole : IRole
	{
		List<Nurse> NewbornNursery
		{
			get;
			set;
		}

		CoreNursery NsyAdmit
		{
			get;
			set;
		}

		CoreNursery IntermediateNICU
		{
			get;
			set;
		}
	}
}
