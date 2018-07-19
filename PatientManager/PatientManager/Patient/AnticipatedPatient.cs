using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Staff;

namespace PatientManager.Patients
{
	public class AnticipatedPatient : Patient
	{
        
        public DeliveryType AnticipatedDeliveryType { get; set; }
        public Room PreAssignedRoom { get; set; }

		public DeliveredPatient PatientDelivered(DeliveryType type, DateTime date, DateTime time, Room room)
		{
            DeliveredPatient newPatient = new DeliveredPatient(this, type, date, room);
            return newPatient;
		}

        public AnticipatedPatient(
            string lastName,
            string attending,
            bool nicu,
            bool confidential,
            bool nonEng,
            bool pih,
            bool medicaid,
            Room preAssignedRoom,
            DeliveryType anticipatedDeliveryType) 
            : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            AnticipatedDeliveryType = anticipatedDeliveryType;
            PreAssignedRoom = preAssignedRoom;
        }
    }
}
