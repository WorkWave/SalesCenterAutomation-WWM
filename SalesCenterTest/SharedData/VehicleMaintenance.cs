namespace WorkWave.PestPac.TA.SharedData
{
    public class VehicleMaintenance
    {
        public string FuelType_Code { get; set; }
        public string FuelType_Description { get; set; }
        public string ServiceType_Code { get; set; }
        public string ServiceType_Description { get; set; }
        public string ServiceType_Months { get; set; }
        public string ServiceType_Miles { get; set; }
        public string ServiceType_IncludeOn { get; set; }
        public string Vehicle_Name { get; set; }
        public string Vehicle_Model { get; set; }
        public string Vehicle_ServiceType { get; set; }
        public string Vehicle_FuelType { get; set; }
        public string FuelEconomyReport_StartingDate { get; set; }
        public string FuelEconomyReport_EndingDate { get; set; }
    }
}