namespace WorkWave.PestPac.TA.SharedData
{
    public class WDC
    {
        public string WDCname { get; set; }
        public string WDCdescription { get; set; }
        public string WDCApptTimeStart1 { get; set; }
        public string WDCAssignedTech { get; set; }
        public string WDCApptTimeEnd1 { get; set; }
        public string WDCApptTime1Decr { get; set; }
        public string R1WorkType1 { get; set; }
        public string R1DaysToinc1Selection { get; set; }
        public string R1DaysToninc1SSelecDay { get; set; }
        public string R1LeaveNoEarlierThan { get; set; }
        public string R1LeaveNoEarlierThanAMPM { get; set; }
        public string R1ArriveatEndBy { get; set; }
        public string R1ArriveatEndByAMPM { get; set; }
        public string R1AtAppointments { get; set; }
        public string OvernightRoute { get; set; }
        public string WDCRule { get; set; }
        public string WDCRule_DaysToInclude { get; set; }
        public string WDCRule_StartAt { get; set; }
        public string WDCRule_EndAt { get; set; }
        public string WDCRule_TotalTimeAvailablePerDay { get; set; }
        public string WDCRule_AtAppointments { get; set; }
        public string WDCRule_DrivingBetweenAppointments { get; set; }
        public string WDCRule_SetAtLunch { get; set; }
        public string WDCRule_AtLunchMins { get; set; }
        public string WDCRule_AnyTimeBetweenFrom { get; set; }
        public string WDCRule_AnyTimeBetweenFromAMPM { get; set; }
        public string WDCRule_AnyTimeBetweenTo { get; set; }
        public string WDCRule_AnyTimeBetweenToAMPM { get; set; }
        public string NoAppointmentEarlierThan { get; set; }
        public string VerifyLeaveNoEarlierThan { get; set; }
        public string ForceAppointment { get; set; }
    }
}