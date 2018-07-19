using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public interface IPostpartumRole : IRole
	{
		List<Nurse> FloorNurses
		{
			get;
			set;
		}

		CCL Coordinator
		{
			get;
			set;
		}
	}
}
