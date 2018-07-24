using System;

namespace PatientManager.Patients
{
    public interface IPatientType
    {
        PatientType Type { get; }
        int LengthOfStay { get; }
        int InitialAcuity { get; }
    }

    public enum PatientType { Unknown, Vag, CS, Gyn };

    public class VagDeliveryType : IPatientType
    {
        public PatientType Type => PatientType.Vag;
        public int LengthOfStay => 2;
        public int InitialAcuity => 3;
    }

    public class CSDeliveryType : IPatientType
    {
        public PatientType Type => PatientType.CS;
        public int LengthOfStay => 3;
        public int InitialAcuity => 4;
    }

    public class GynDeliveryType : IPatientType
    {
        public PatientType Type => PatientType.Gyn;
        public int LengthOfStay => 1;
        public int InitialAcuity => 4;
    }
}
