namespace WorkWave.PestPac.TA.SharedData
{
    public enum PestPacData
    {
        Location,
        Customer,
        BillTo,
        GeneralLedger
    }
    
    public class PestPacData__old
    {
        public Location Location { get; set; }
        public ServiceDetail Service { get; set; }
        public ServiceOrder ServiceOrder { get; set; }
        public ServiceSetup ServiceSetup { get; set; }
        public Renewal Renewal { get; set; }
        public Invoice Invoice { get; set; }
        public Payment Payment { get; set; }
        internal TaxCodeLookup TaxCodeLookup { get; set; }
        public CreditMemo CreditMemo { get; set; }
        public CreditCards CreditCards { get; set; }
        public Tasks Tasks { get; set; }
        public Calls Calls { get; set; }
        public Leads Leads { get; set; }
        public Employee Employee { get; set; }
        public Adjustments Adjustments { get; set; }
        public Programs Programs { get; set; }
        public Documents Documents { get; set; }
        public Reports Reports { get; set; }
        public Contact Contact { get; set; }
        public Customer Customer { get; set; }
        public Threshold Threshold { get; set; }
        public RouteOp RouteOp { get; set; }
        public Warranty Warranty { get; set; }
        public Branch Branch { get; set; }
        public BillTo BillTo { get; set; }
        public NewAccountDefaults NewAccountDefaults { get; set; }
        public GeneralLedger GeneralLedger { get; set; }
        public PostingOptions PostingOptions { get; set; }
        public Devices Devices { get; set; }
        public Materials Materials { get; set; }
        public WDC WDC { get; set; }
        public Tools Tools { get; set; }
        public UnitsOfMeasure UnitsOfMeasure { get; set; }
        public Profile Profile { get; set; }
        public PrinterOrEmailSetup PrinterOrEmailSetup { get; set; }
        public Statements Statements { get; set; }
        public CompanyConfiguration CompanyConfiguration { get; set; }
        public ReleaseCCBilling ReleaseCCBilling { get; set; }
        public ACH ACH { get; set; }
        public CompanySetup CompanySetup { get; set; }
        public ScheduleType ScheduleType { get; set; }
        public Collections Collections { get; set; }
        public GenerateServiceOrders GenerateServiceOrders { get; set; }
        public Areas Areas { get; set; }
        public VehicleMaintenance VehicleMaintenance { get; set; }
        public CCAutomation CCAutomation { get; set; }
        public FormsManager FormsManager { get; set; }
        public SalesCenterData SalesCenter { get; set; }
        public FormsTracker FormsTracker { get; set; }
        public SalesStatus SalesStatus { get; set; }
        public Calls NewCode { get; set; }
    }
}