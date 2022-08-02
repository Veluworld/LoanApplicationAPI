using LoanApplicationAPI.Models;
using LoanApplicationAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApplicationAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class LoanDetailsController : ControllerBase
    {
        private readonly ILoanRepository _loanRepository;
        public LoanDetailsController(ILoanRepository loanRepository)
        {
            this._loanRepository = loanRepository;
        }
        // GET: LoanDetailsController
       
        // POST: LoanDetailsController/Delete/5
        [HttpGet]       
        public async Task<IEnumerable<LoanData>> GetLoanData()
        {
            return await _loanRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<LoanData> GetLoanData(int id)
        {
            return await _loanRepository.Get(id);
        }
    }
}
