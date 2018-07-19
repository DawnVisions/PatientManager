using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Shift
{
	public interface IUnlicensedRole : IRole
	{
		Staff PPHUA
		{
			get;
			set;
		}

		PCT LDHUA
		{
			get;
			set;
		}

		Staff PPTech
		{
			get;
			set;
		}

		PCT LDTech
		{
			get;
			set;
		}

		Staff TriageHUA
		{
			get;
			set;
		}
	}
}
