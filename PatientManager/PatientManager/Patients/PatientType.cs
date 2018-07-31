using System;

namespace PatientManager.Patients
{
    public class PatientType
    {
        public virtual PatientTypesEnum Type { get; }
        public virtual int LengthOfStay { get; }
        public virtual int InitialAcuity { get; }

        public override string ToString()
        {
            return Type.ToString();
        }
    }

    public enum PatientTypesEnum { Unknown, Vag, CS, Gyn };

    public class VagPatientType : PatientType
    {
        public override PatientTypesEnum Type => PatientTypesEnum.Vag;
        public override int LengthOfStay => 2;
        public override int InitialAcuity => 3;
    }

    public class CSPatientType : PatientType
    {
        public override PatientTypesEnum Type => PatientTypesEnum.CS;
        public override int LengthOfStay => 3;
        public override int InitialAcuity => 4;
    }

    public class GynPatientType : PatientType
    {
        public override PatientTypesEnum Type => PatientTypesEnum.Gyn;
        public override int LengthOfStay => 1;
        public override int InitialAcuity => 4;
    }
}
