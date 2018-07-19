using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Patients
{
	public abstract class Patient
	{
        public string LastName { get; }

		public string Attending { get; set; }

		public bool NICU { get; set; }

		public bool Confidential { get; set; }

		public bool LanguageBarrier { get; set; }

		public bool PIH { get; set; }

		public bool Medicaid { get; }

		public List<Nurse> PreviousNurses { get; set; }

        public Patient(string lastName, string attending, bool nicu, bool confidential, bool nonEng, bool pih, bool medicaid)
        {
            LastName = lastName;
            Attending = attending;
            NICU = nicu;
            Confidential = confidential;
            LanguageBarrier = nonEng;
            PIH = pih;
            Medicaid = medicaid;
        }

        public Patient(Patient patient)
        {
            LastName = patient.LastName;
            Attending = patient.Attending;
            NICU = patient.NICU;
            Confidential = patient.Confidential;
            LanguageBarrier = patient.LanguageBarrier;
            PIH = patient.PIH;
            Medicaid = patient.Medicaid;
        }
    }
}
