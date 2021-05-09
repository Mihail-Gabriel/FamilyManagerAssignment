using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public int Salary { get; set; }

        public override bool Equals(object? obj)
        {
            if (this == obj)
            {
                return true;
            }
            Job helper = obj as Job;
            return JobTitle.Equals(helper.JobTitle) && Salary == helper.Salary;
        }
    }
}