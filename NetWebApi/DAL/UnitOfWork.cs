using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetWebApi.DAL
{
    public class UnitOfWork :  IUnitOfWork
    {

        private ApplicationContext _context;
        public UnitOfWork()
        {
            _context = new ApplicationContext();
            Jobs = new JobRepository(_context);
            Applicants = new ApplicantReposetory(_context);
        }

        public JobRepository Jobs { get; set; }
        public ApplicantReposetory Applicants { get; set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

  
    }
}