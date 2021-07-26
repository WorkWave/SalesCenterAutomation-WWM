namespace WorkWave.PestPac.TA.SharedData
{
    public class RouteOp
    {
        public string Service { get; set; }
        public string WorkDate { get; set; }
        public string Duration { get; set; }
        public string WorkTime { get; set; }
        public string Tech { get; set; }
        public string RouteCluster { get; set; }
        public string Route { get; set; }
        public string orderNumber { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartAM { get; set; }
        public string EndPM { get; set; }
        public string KeepOrdersOnTheirCurrentWorkDate { get; set; }
        public string KeepOrdersOnTheirCurrentTechnician { get; set; }
        public string DuringOptimizationScheduleOrdersBetween_Technicians { get; set; }
        public string DoNotReAssignWorkAlreadyAssignedToATargetTech { get; set; }
        public string LatestOptimizationStatus { get; set; }
        public string UnreachableText { get; set; }
        public string OptimizationResult { get; set; }

    }
}
