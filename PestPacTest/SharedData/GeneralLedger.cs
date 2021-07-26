using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class GeneralLedger
    {
        public string UseGeneralLedger { get; set; }
        public string DefaultGLCode { get; set; }
        public string GL_SuspenseAccount { get; set; }
        public string Default_PaymentGLCode_FromMOP { get; set; }
        public string SalesCodeSource { get; set; }

        #region New GL Code Data

        public string GLCode { get; set; }
        public string SalesAccount { get; set; }
        public string ARAccount { get; set; }
        public string CashAccount { get; set; }
        public string SalesTaxAccount { get; set; }
        public string DiscountAccount { get; set; }
        public string Description { get; set; }

        #endregion New GL Code Data

    }
}
