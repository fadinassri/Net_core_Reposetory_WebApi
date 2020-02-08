using NetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetWebApi.DAL
{
    // you to install the EntityFramework Package
    /*
     * enable-migrations
     * add-migrations IntialDBCreation
     * update-database
     * update-database -script -sourceMigration:InitialDB 
     * Get-Migrations
     * Update-Database -TargetMigration:"CategoryIdIsLong"
     */

    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("DefaultConnection")
        {

        }

        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Job> Job { get; set; }

    }
}