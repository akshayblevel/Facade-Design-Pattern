using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class DemographicInfo : IAadhar
    {
        public void Capture()
        {
            Console.WriteLine("Demographic Info is captured.");
        }

        public void Validate()
        {
            Console.WriteLine("Demographic Info is verified.");
        }
    }
}
