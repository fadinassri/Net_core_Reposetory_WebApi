using NetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetWebApi.DAL
{
    public class JobRepository : Reposetory<Job>, IJobRepository
    {
        public JobRepository(ApplicationContext _context) : base(_context)
        {
        }


    }
}