using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetWebApi.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string SalaryRange { get; set; }
        public DateTime Deadline { get; set; }
        public int MaximumApplicant { get; set; }

    }
}