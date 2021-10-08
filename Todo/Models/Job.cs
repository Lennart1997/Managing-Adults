using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{nameof(JobTitle)}: {JobTitle}, {nameof(Salary)}: {Salary}";
        }
    }
    
    
    
}