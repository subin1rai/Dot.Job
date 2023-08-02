using JobPortal.Models;

namespace JobPortal.Interface
{
    public interface IjobInterface
    {
        List<JobTitle> GetJobTitles();
        JobTitle GetByID(Guid Id);

        void AddJob(JobTitle jobtitle);

        void EditJob(JobTitle jobtitle);

        void DeleteJob(JobTitle jobTitle);

    }
}
