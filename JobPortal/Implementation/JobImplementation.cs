using JobPortal.Data;
using JobPortal.Interface;
using JobPortal.Models;

namespace JobPortal.Implementation
{
    public class JobImplementation : IjobInterface

    {

        private readonly TitleDbContext _context;

        public JobImplementation(TitleDbContext context)
        {
            _context = context;
        }
        public void AddJob(JobTitle jobtitle)
        {
            _context.JobTitles.Add(jobtitle);
            _context.SaveChanges();
        }

        public void EditJob(JobTitle jobtitle)
        {
            _context.JobTitles.Update(jobtitle);
            _context.SaveChanges();
        }
        public void DeleteJob(JobTitle jobtitle)
        {
            _context.JobTitles.Remove(jobtitle);
            _context.SaveChanges();
        }

        public JobTitle GetByID(Guid jobID)
        {
            var jobId = _context.JobTitles.Where(x => x.Id == jobID).FirstOrDefault();
            //or
            //var JobId = _context.JobTitles.Find(id);
            return jobId;
        }

        public List<JobTitle> GetJobTitles()
        {
           var allJob = _context.JobTitles.ToList();
            return allJob;
        }


    }
}
