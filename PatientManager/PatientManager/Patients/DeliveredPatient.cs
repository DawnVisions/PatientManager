using System;

namespace PatientManager.Patients
{
	public class DeliveredPatient : Patient, IHasRoom, IDischargable
	{
        public IPatientType PatientType { get; }

        public DateTime DeliveryDate { get; set; }

        public int CurrentLengthOfStay { get; set; }

        public int PlannedLengthOfStay { get; set; }

		public DateTime PlannedDischargeDay { get; set; }

        public int Acuity { get; set; }

        private Room _room;
        public Room Room
		{
			get
			{
                return _room;
			}
			private set
			{
                _room = value;
                _room.Available = false;
			}
		}

        public void Discharge()
        {
            this.Room.Available = true;
        }

		public DeliveredPatient(
            string lastName, 
            string attending, 
            bool nicu, 
            bool confidential, 
            bool nonEng, 
            bool pih,
            bool medicaid, 
            IPatientType patientType, 
            DateTime date,
            Room room) 
            : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            PatientType = patientType;
            DeliveryDate = date;
            Room = room;
            CurrentLengthOfStay = 0;
            PlannedLengthOfStay = patientType.LengthOfStay;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLengthOfStay);
            Acuity = patientType.InitialAcuity;
        }
	}
}
