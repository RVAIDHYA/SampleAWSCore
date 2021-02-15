using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAWSCore.Models
{
    public class Resume
    {

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Location { get; set; }

        public string About { get; set; }

        public List<string> ProfileSummary { get; set; }

        public List<Project> Projects { get; set; }

        public Dictionary<string,string> TechnologyStack { get; set; }

        public string Education { get; set; }
    }
}
