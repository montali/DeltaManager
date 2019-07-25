using Delta.DeltaManager.BookingNS;
using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.ReportNS;
using Delta.DeltaManager.ServiceNS;
using Delta.DeltaManager.UserNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace DeltaManager
{
    class Program
    {
        public static void Main()
        {
            ServiceHost svcBooking = new ServiceHost(typeof(BookingManager));
            ServiceHost svcCar = new ServiceHost(typeof(CarManager));
            ServiceHost svcReport = new ServiceHost(typeof(ReportManager));
            ServiceHost svcService = new ServiceHost(typeof(ServiceManager));
            ServiceHost svcUser = new ServiceHost(typeof(UserManager));

            svcBooking.Open();
            svcCar.Open();
            svcReport.Open();
            svcService.Open();
            svcUser.Open();
            Console.WriteLine("This sh*t is LIT!");
            Console.ReadLine();
            Console.WriteLine("Turning this sh*t OFF!");
            svcBooking.Close();
            svcCar.Close();
            svcReport.Close();
            svcService.Close();
            svcUser.Close();
            Console.WriteLine("This sh*t ain't LIT no more!");
            Console.ReadLine();
        }
    }
}
