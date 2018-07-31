using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Shifts;

namespace PatientManager.Staff
{
	public abstract class Staff
	{
		public string Name { get; set; }
    
        public List<Roles> MyRoles { get; set; }

        public enum Roles { Unlicensed, Nursery, Postpartum }

        protected Staff(string name)
        {
            Name = name;
            MyRoles = new List<Roles>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
