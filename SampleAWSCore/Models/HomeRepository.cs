using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAWSCore.Models
{
    public class HomeRepository : IHomeRepository
    {

       

        public HomeRepository()
        {
            
        }

        public Resume GetResumeDetails(string filePath)
        {

            Resume resume = new Resume();


            try
            {

                using (StreamReader file = new StreamReader(filePath))
                {
                    var data = file.ReadToEnd();
                    resume = JsonConvert.DeserializeObject<Resume>(data);

                }
            }
            catch(Exception ex)
            {

            }


            return resume;






        }
    }
}
