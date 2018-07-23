using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class DeliveryType
	{
        PatientType thisType;
        public enum PatientType { Vag, CS, Gyn};
        public int DefaultLOS;
        public int InitialAcuity;

        public DeliveryType(PatientType t)
        {
            thisType = t;
            if(t == PatientType.CS)
            {
                DefaultLOS = 3;
                InitialAcuity = 4;
            }
            else if (t == PatientType.Gyn)
            {
                DefaultLOS = 1;
                InitialAcuity = 4;
            }
            else //Vag or unknown
            {
                DefaultLOS = 2;
                InitialAcuity = 3;
            }
        }

        public override string ToString()
        {
            return thisType.ToString();
        }
    }
}
