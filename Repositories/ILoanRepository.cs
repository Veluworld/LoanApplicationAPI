using LoanApplicationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApplicationAPI.Repositories
{
    public interface ILoanRepository
    {

        Task<IEnumerable<LoanData>> Get();
        Task<LoanData> Get(int id);
        //Task Update(LoanData loandata);
        //Task<LoanData> Create(LoanData loandata);
        //Task Delete(int id);
    }
}
