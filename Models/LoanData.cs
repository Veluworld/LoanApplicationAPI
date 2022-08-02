using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApplicationAPI.Models
{
    public class LoanData
    {
        public int ApplicactionId  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string LoanAmount { get; set; }
        public string LoanType { get; set; }
        public string LoanTerm { get; set; }
        public string PropertyAddress { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDae { get; set; }
        public string ModifiedBy { get; set; }

    }
}
