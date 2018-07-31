using System;

namespace PatientManager.Patients
{
	public class AnticipatedPatient : Patient, IHasRoom
	{
        public PatientType AnticipatedDeliveryType { get; set; }

        public Room Room { get; set; }

        public AnticipatedPatient(
            string lastName,
            string attending,
            bool nicu,
            bool confidential,
            bool nonEng,
            bool pih,
            bool medicaid,
            Room preAssignedRoom,
            PatientType anticipatedDeliveryType) 
            : base(lastName, attending, nicu, confidential, nonEng, pih, medicaid)
        {
            AnticipatedDeliveryType = anticipatedDeliveryType;
            Room = preAssignedRoom;
        }
    }
}
