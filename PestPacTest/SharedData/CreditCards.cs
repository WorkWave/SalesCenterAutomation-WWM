using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class CreditCards
    {
        public string CreditCard_Name { get; set; }
        public string CreditCard_Type { get; set; }
        public string CreditCard_Number { get; set; }
        public string CreditCard_ExpirationMonth { get; set; }
        public string CreditCard_ExpirationYear { get; set; }
        public string CreditCard_CCV { get; set; }
        public string PrimaryCard { get; set; }
        public string Processor { get; set; }
        public string Replacing_CreditCardName { get; set; }
        public string Replacing_CreditCardNumber { get; set; }
        public string CreditCard_StreetAddress { get; set; }
        public string CreditCard_ZIP { get; set; }

    }
}


