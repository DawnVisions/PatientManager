using System;

namespace PatientManager.Patients
{
	public class DeliveredPatient : Patient, IHasRoom, IDischargable
	{
        public IDeliveryType PatientType { get; }
        public DateTime DeliveryDate { get; set; }

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

		public int CurrentLengthOfStay { get; set; }
        public int PlannedLOS { get; set; }

		public DateTime PlannedDischargeDay { get; set; }

        public void Discharge()
        {
            this.Room.Available = true;
        }

        public int Acuity { get; set; }

		public DeliveredPatient(string lastName, string attending, bool nicu, bool confidential, bool nonEng, bool pih, bool medicaid, IDeliveryType delivType, DateTime date, Room room) : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            PatientType = delivType;
            DeliveryDate = date;
            Room = room;
            CurrentLengthOfStay = 0;
            PlannedLOS = delivType.LengthOfStay;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLOS);
            Acuity = delivType.InitialAcuity;
        }
	}
}
