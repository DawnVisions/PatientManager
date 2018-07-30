using System;
using System.Collections.Generic;
using System.Text;
using PatientManager.Patients;
using PatientManager.Shift;
using System.ComponentModel;

namespace PatientManager.Shift
{
    public class Day
    {
        DateTime Date { get; set; }
        public Shift Days;
        public Shift Nights;

        public void UpdateLOS(BindingList<DeliveredPatient> patients)
        {
            foreach (DeliveredPatient patient in patients)
            {
                patient.CurrentLengthOfStay = (int)(Date.Date - patient.DeliveryDate.Date).TotalDays;
            }
        }

        public int DischargesScheduled(BindingList<DeliveredPatient> patients)
        {
            int _dischargesScheduled = 0;
            foreach (DeliveredPatient patient in patients)
            {
                if (patient.PlannedDischargeDay.Date == this.Date.Date)
                {
                    _dischargesScheduled += 1;
                    patient.DischargeToday = true;
                }
            }
            return _dischargesScheduled;
        }

        public Day(DateTime date)
        {
            this.Date = date;
            Days = new Shift(Shift.DayOrNight.Days);
            Nights = new Shift(Shift.DayOrNight.Nights);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Date.DayOfWeek + " " + Date.ToLongDateString());
            return sb.ToString();
        }
	}
}
