using System;

namespace PatientManager.Patients
{
	public abstract class Patient
	{
        public Guid Id { get; set; }

        public string LastName { get; }

		public string Attending { get; set; }

		public bool NICU { get; set; }

		public bool Confidential { get; set; }

		public bool LanguageBarrier { get; set; }

		public bool PIH { get; set; }

		public bool Medicaid { get; }

        protected Patient(
            string lastName, 
            string attending, 
            bool nicu, 
            bool confidential,
            bool nonEng, 
            bool pih, 
            bool medicaid)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            Attending = attending;
            NICU = nicu;
            Confidential = confidential;
            LanguageBarrier = nonEng;
            PIH = pih;
            Medicaid = medicaid;
        }

        protected Patient(Patient patient)
        {
            Id = patient.Id;
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
