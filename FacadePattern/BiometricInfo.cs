using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class BiometricInfo : IAadhar
    {
        public void Capture()
        {
            Console.WriteLine("Biometric Info is captured.");
        }

        public void Validate()
        {
            Console.WriteLine("Biometric Info is verified.");
        }
    }
}
