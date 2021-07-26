using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class UnitsOfMeasure
    {
        public string UnitOfMeasureName { get; set; }
        public string Description { get; set; }
        public string Relationship_UnitOfMeasureName { get; set; }
        public string Relationship_UnitOfMeasureQuantity { get; set; }
        public bool UnitOfMeasure_AvailableInUOMTable_TrueOrFalse { get; set; }
    }
}
