using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Create a class Hospital with HospitalDetails() method. Create another 
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
//HospitalDetails() method.

namespace ConsoleApp4
{
    internal class Hospital
    {
        public virtual void HospitalDetails(String hName)
        {
            Console.WriteLine("Hospital Name : "+hName);
        }
    }
    internal class Apollo : Hospital
    {
        public override void HospitalDetails(String hName)
        {
            base.HospitalDetails(hName);
        }
    }

    internal class Wockhardt : Hospital
    {
        public override void HospitalDetails(String hName)
        {
            base.HospitalDetails(hName);
        }
    }

    internal class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails(String hName)
        {
            base.HospitalDetails(hName);
        }
    }
}
