using NetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetWebApi.DAL
{
    public class ApplicantReposetory : Reposetory<Applicant>, IApplicantReposetory
    {
        public ApplicantReposetory(ApplicationContext _context) : base(_context)
        {

        }

    }
}