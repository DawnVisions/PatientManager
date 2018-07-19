using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class DeliveredPatient : Patient
	{

        Room _room;
        List<Newborn> _newborns;

        public DeliveryType DeliveryType { get; }
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
                if (DeliveryType is Gyn)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    List<Newborn> _newborns = new List<Newborn>;
                }
			}
		}

		public int currentLengthOfStay { get; set; }
        public int PlannedLOS { get; set; }

		public DateTime PlannedDischargeDay { get; set; }

		public bool UpdatePlannedDischargeDay(DateTime newDischargeDay)
		{
            PlannedDischargeDay = newDischargeDay;
            return true;
		}

		public int Acuity { get; set; }

		public int UpdateAcuity(int newAcuity)
		{
            Acuity = newAcuity;
            return Acuity;
		}

		public DeliveredPatient(AnticipatedPatient patient, DeliveryType delivType, DateTime date, Room room) : base(patient)
		{
            DeliveryType = delivType;
            DeliveryDate = date;
            Room = room;
            Newborns = new List<Newborn> { };
            currentLengthOfStay = 0;
            PlannedLOS = DeliveryType.DefaultLOS;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLOS);
		}

		public DeliveredPatient(string lastName, string attending, bool nicu, bool confidential, bool nonEng, bool pih, bool medicaid, DeliveryType delivType, DateTime date, Room room) : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            DeliveryType = delivType;
            DeliveryDate = date;
            Room = room;
            Newborns = new List<Newborn> { };
            currentLengthOfStay = 0;
            PlannedLOS = DeliveryType.DefaultLOS;
            PlannedDischargeDay = DateTime.Today.AddDays(PlannedLOS);
        }
	}
}
