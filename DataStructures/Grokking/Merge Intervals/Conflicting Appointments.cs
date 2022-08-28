using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Conflicting_Appointments
    {
        List<Interval> Appointments;
        public Conflicting_Appointments()
        {
            Appointments = new List<Interval>();
            Appointments.Add(new Interval(1, 4));
            Appointments.Add(new Interval(2, 5));
            Appointments.Add(new Interval(7, 9));
        }

        public bool canAttendAllAppointments()
        {

            Appointments.Sort((i1, i2) => i1.start.CompareTo(i2.start));


            for (int i = 1; i < Appointments.Count; i++)
                if (Appointments[i].start < Appointments[i - 1].end)
                    return false;

            return true;
        }

        private bool areOverLapping(Interval i1, Interval i2)
        {
            return (i1.start >= i2.start && i1.start <= i2.end) || (i2.start >= i1.start && i2.start <= i1.end);
        }
    }
}