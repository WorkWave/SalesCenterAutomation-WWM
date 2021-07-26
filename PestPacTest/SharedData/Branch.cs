using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class Branch
    {
        public string BranchName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Use_Branch_Specific_Vantiv_Account { get; set; }
        public string Use_Vantiv_Account_Updater { get; set; }
        public string Use_Branch_Specific_ARM_Collections_Account { get; set; }
    }
}
