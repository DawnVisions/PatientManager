using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Shift
{
	public interface IUnlicensedRole : IRole
	{
		PCT PPHUA
		{
			get;
			set;
		}

		PCT LDHUA
		{
			get;
			set;
		}

		PCT PPTech
		{
			get;
			set;
		}

		PCT LDTech
		{
			get;
			set;
		}

		PCT TriageHUA
		{
			get;
			set;
		}
	}
}
