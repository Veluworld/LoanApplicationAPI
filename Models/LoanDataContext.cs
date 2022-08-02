using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApplicationAPI.Models
{
    public class LoanDataContext : DbContext
    {
        public LoanDataContext(DbContextOptions<LoanDataContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<LoanData> loans { get; set; }
    }

}
