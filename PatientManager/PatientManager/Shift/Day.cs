using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Patients;
using PatientManager.Shift;

namespace PatientManager.Shift
{
    public class Day
    {
        DateTime Date { get; set; }
        Shift Days;
        Shift Nights;

        public void UpdateLOS(List<DeliveredPatient> patients)
        {
            foreach (DeliveredPatient patient in patients)
            {
                patient.CurrentLengthOfStay += 1;
            }
        }

        public int DischargesScheduled(UnitCensus familySuites)
        {
            int _dischargesScheduled = 0;
            foreach (DeliveredPatient patient in familySuites.DeliveredPatients)
            {
                if (patient.PlannedDischargeDay == Date)
                {
                    _dischargesScheduled += 1;
                }
            }
            return _dischargesScheduled;
        }

        public Day(DateTime date)
        {
            this.Date = date;
            //Days = new Shift();
            //Nights = new Shift();
        }
	}
}
