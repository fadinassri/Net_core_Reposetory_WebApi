using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetWebApi.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Resume { get; set; }
        public  Job  AppliedJOB {get;set;}
    }
}