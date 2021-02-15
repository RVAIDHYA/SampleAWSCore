using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAWSCore.Models
{
    public interface IHomeRepository
    {

        public Resume GetResumeDetails(string filePath);

    }
}
