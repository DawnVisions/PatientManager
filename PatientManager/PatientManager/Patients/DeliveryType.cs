using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
    public enum PatientType { Unknown, Vag, CS, Gyn };

    public class VagDeliveryType : IDeliveryType
    {
        public PatientType Type => PatientType.Vag;
        public int LengthOfStay => 2;
        public int InitialAcuity => 3;
    }

    public class CSDeliveryType : IDeliveryType
    {
        public PatientType Type => PatientType.CS;
        public int LengthOfStay => 3;
        public int InitialAcuity => 4;
    }

    public class GynDeliveryType : IDeliveryType
    {
        public PatientType Type => PatientType.Gyn;
        public int LengthOfStay => 1;
        public int InitialAcuity => 4;
    }

    public interface IDeliveryType
    {
        PatientType Type { get; }
        int LengthOfStay { get; }
        int InitialAcuity { get; }
    }
}
