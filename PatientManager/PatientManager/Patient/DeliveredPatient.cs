using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class DeliveredPatient : Patient
	{

        Room _room;
        List<Newborn> _newborns;

        public DeliveryType PatientType { get; }
        public DateTime DeliveryDate { get; set; }
		public Room Room
		{
			get
			{
                return _room;
			}
			set
			{
                _room = value;
                _room.Available = false;
			}
		}

		public List<Newborn> Newborns
		{
			get
			{
                return _newborns;
			}
			set
			{
                if (PatientType.Equals(DeliveryType.PatientType.Gyn))
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    List<Newborn> _newborns = new List<Newborn>();
                }
			}
		}

		public int CurrentLengthOfStay { get; set; }
        public int PlannedLOS { get; set; }

		public DateTime PlannedDischargeDay { get; set; }

		public bool UpdatePlannedDischargeDay(DateTime newDischargeDay)
		{
            PlannedDischargeDay = newDischargeDay;
            return true;
		}

		public int Acuity { get; set; }

		public DeliveredPatient(AnticipatedPatient patient, DeliveryType delivType, DateTime date, Room room) : base(patient)
		{
            PatientType = delivType;
            DeliveryDate = date;
            Room = room;
            Newborns = new List<Newborn> { };
            CurrentLengthOfStay = 0;
            PlannedLOS = delivType.InitialAcuity;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLOS);
            Acuity = delivType.InitialAcuity;
		}

		public DeliveredPatient(string lastName, string attending, bool nicu, bool confidential, bool nonEng, bool pih, bool medicaid, DeliveryType delivType, DateTime date, Room room) : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            PatientType = delivType;
            DeliveryDate = date;
            Room = room;
            Newborns = new List<Newborn> { };
            CurrentLengthOfStay = 0;
            PlannedLOS = delivType.DefaultLOS;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLOS);
            Acuity = delivType.InitialAcuity;
        }
	}
}
