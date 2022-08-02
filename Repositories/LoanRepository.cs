using LoanApplicationAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApplicationAPI.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LoanDataContext _context;

        public LoanRepository(LoanDataContext context)
        {
            _context = context;
        }
        //public async Task<LoanData> Create(LoanData loandata)
        //{
        //    _context.loans.Add(loandata);
        //    await _context.SaveChangesAsync();
        //    return loandata;
        //}

        //public async Task Delete(int id)
        //{
        //    var loantoDelete = await _context.loans.FindAsync(id);
        //    _context.loans.Remove(loantoDelete);
        //    await _context.SaveChangesAsync();
        //}

        public async Task<IEnumerable<LoanData>> Get()
        {
            return await _context.loans.ToListAsync();
        }

        public async Task<LoanData> Get(int id)
        {
            return await _context.loans.FindAsync(id);
        }

        //public Task Update(LoanData loandata)
        //{
        //    context.Entry(loandata)
        //}
    }
}
