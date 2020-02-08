using System;

namespace NetWebApi.DAL
{
    public interface IUnitOfWork: IDisposable
    {
        ApplicantReposetory Applicants { get; set; }
        JobRepository Jobs { get; set; }

       
        void Save();
    }
}