using System;

namespace PatientManager.Patients
{
	public class DeliveredPatient : Patient, IHasRoom, IDischargable
	{
        public IPatientType PatientType { get; }

        public DateTime DeliveryDate { get; set; }

        public int CurrentLengthOfStay { get; set; }

        private int _plannedLengthOfStay;
        public int PlannedLengthOfStay
        {
            get => _plannedLengthOfStay;
            set
            {
                _plannedLengthOfStay = value;
                if (this.Medicaid && DeliveryDate.TimeOfDay.Hours < 17)
                {
                     _plannedLengthOfStay -= 1;
                }
            }
        }

        public DateTime PlannedDischargeDay
        {
            get => this.DeliveryDate.AddDays(PlannedLengthOfStay);
        }

        public bool DischargeToday { get; set; }

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
            Acuity = patientType.InitialAcuity;
        }
	}
}
