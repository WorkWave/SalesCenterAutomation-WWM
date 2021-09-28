namespace WorkWave.PestPac.TA.SharedData
{
    public class ServiceOrder
    {
        public string ServiceOrderNumber { get; set; }
        public string ServiceOrderNumber1 { get; set; }
        public bool ExpectedServiceOrderTaxCheck { get; set; }
        public string ServiceOrderNumber2 { get; set; }
        public string ServiceOrderDuration { get; set; }
        public string ServiceOrderCode { get; set; }
        public string ServiceOrderPrice { get; set; }
        public string ServiceOrderWorkTime { get; set; }
        public string ServiceOrderTech1 { get; set; }
        public string ServiceOrderWorkDate { get; set; }
        public string ServiceOrderMeasurementAmount { get; set; }
        public string ServiceOrderMeasurementType { get; set; }
        public string ServiceOrderTargets { get; set; }
        public string ExpectedCommissionTech1 { get; set; }

        public string ExpectedCommissionTech2 { get; set; }
        public string ExpectedCommissionSales1 { get; set; }
        public string ExpectedCommissionSales2 { get; set; }
        public string Tech1Bonus { get; set; }
        public string Sales1Bonus { get; set; }
        public string ExpectedTech1Bonus { get; set; }
        public string ExpectedSales1Bonus { get; set; }
        public string Tech2Bonus { get; set; }
        public string Sales2Bonus { get; set; }
        public string ExpectedTech2Bonus { get; set; }
        public string ExpectedSales2Bonus { get; set; }
        public string ServiceOrderType { get; set; }
        public string Material_ChemicalCode1 { get; set; }
        public string Material_Quantity1 { get; set; }
        public string Material_Dilution1 { get; set; }
        public string Material_UndilutedQty1 { get; set; }
        public string Inspection_ReportFormat { get; set; }
        public string SelectionCriteria_OrderNumber { get; set; }
        public string OrderBranch { get; set; }
        public bool Tech1Availability { get; set; }
        public string PostOrderTo { get; set; }
        public string LocationGLCode { get; set; }
        public string ServiceCode_GLCode { get; set; }
        public string AmountToAuthorize { get; set; }
        public string PostedServiceOrder_LastBatchNumber { get; set; }
        public string SecondServiceCode { get; set; }
        public string DeleteLineOne { get; set; }
        public string DeleteLineTwo { get; set; }
        public string DeleteLineTwoCheck { get; set; }
        public string UnitPrice { get; set; }
        public string ActivityComment { get; set; }
        public string ActiveDevices { get; set; }
        public string LocationNotify { get; set; }
        public string SchedulingConstraints { get; set; }
        public string EarliestTime { get; set; }
        public string EarliestTimeAMPM { get; set; }
        public string LatestTime { get; set; }
        public string LatestTimeAMPM { get; set; }
    }
}