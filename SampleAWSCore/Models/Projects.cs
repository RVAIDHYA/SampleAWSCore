using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAWSCore.Models
{
    public class Project
    {

        public string Company { get; set; }

        public string Designation { get; set; }


        [DisplayFormat(DataFormatString = "{yyyy-mm}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{yyyy-mm}")]
        public DateTime EndDate { get; set; }

      
        public List<string> RolesPerformed { get; set; }

        public string Location { get; set; }


    }
}
