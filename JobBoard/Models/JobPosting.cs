using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobPosting
    {
        private string _jobtitle;
        private string _description;
        private string _contactinfo;
        private static List<JobPosting> _instances = new List<JobPosting>{};
        public JobPosting (string jobtitle, string description, string contactinfo)
        {
            _description = description;
            _jobtitle = jobtitle;
            _contactinfo = contactinfo;
            _instances.Add(this);
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public string GetJobTitle()
        {
            return _jobtitle;
        }
        public void SetJobTitle(string newJobTitle)
        {
            _jobtitle = newJobTitle;
        }
        public string GetContactInfo()
        {
            return _contactinfo;
        }
        public void SetContactInfo(string newContactInfo)
        {
            _contactinfo= newContactInfo;
        }
        public static List<JobPosting> GetAll()
        {
        return _instances;
        }

        public static void ClearAll()
        {
        _instances.Clear();
        }
    }
}