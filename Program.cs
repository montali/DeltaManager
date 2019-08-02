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


/* Nota per Guido: vorrei gestire le eccezioni con un doppio catch: il primo catch, che catcha l'eccezione vera e propria, throwa il faultcontract senza fare altro
 * la seconda catch, catcha il faultcontract e stampa a console (del manager) l'errore. In questo modo abbiamo segnalato sia da client che da server*/
namespace DeltaManager
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("██████╗ ███████╗██╗  ████████╗ █████╗ \n██╔══██╗██╔════╝██║  ╚══██╔══╝██╔══██╗\n██║  ██║█████╗  ██║     ██║   ███████║\n██║  ██║██╔══╝  ██║     ██║   ██╔══██║\n██████╔╝███████╗███████╗██║   ██║  ██║\n╚═════╝ ╚══════╝╚══════╝╚═╝   ╚═╝  ╚═╝");
            Console.WriteLine("Welcome. I'm doing my thing. Give me a while.");
            try
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
                Console.WriteLine("\nDelta Manager is now up and running. Press RETURN to kill it gracefully.");
                Console.ReadLine();
                svcBooking.Close();
                svcCar.Close();
                svcReport.Close();
                svcService.Close();
                svcUser.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("I had a problem turning the service on. Tell those bad programmers i had this problem: {0}", e.ToString());
            }
            Console.WriteLine("Delta is now stopped. Press RETURN to kill me. ");
            Console.ReadLine();
        }
    }
}
