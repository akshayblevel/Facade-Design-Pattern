using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FacadePattern
{
    public class AadharFacade
    {
        DemographicInfo demographicInfo;
        BiometricInfo biometricInfo;

        public AadharFacade()
        {
            demographicInfo = new DemographicInfo();
            biometricInfo = new BiometricInfo();
        }

        public void CreateAadhar()
        {
            Console.WriteLine("*****Creating Aadhar*****");

            Thread.Sleep(2000);
            demographicInfo.Capture();

            Thread.Sleep(2000);
            demographicInfo.Validate();

            Thread.Sleep(2000);
            biometricInfo.Capture();

            Thread.Sleep(2000);
            biometricInfo.Validate();

            Thread.Sleep(2000);
            Console.WriteLine("*****Aadhar Creation Done*****");
        }
    }
}
