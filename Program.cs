using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.UserNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeltaManager
{
    class Program
    {
        public static void Main()
        {
            CarManager cm = new CarManager();
            var cars = cm.GetAvailableCars(new DateTime(2019, 10, 10), new DateTime(2019, 11, 11), new System.Collections.Hashtable());
            foreach (var auto in cars)
            {
                Console.WriteLine("Marca: {0}\tAuto:{1}\tTarga:{2}", auto.Make, auto.Model, auto.PlateNumber);
            }
            UserManager um = new UserManager();
            um.CreateUser("Guido Sonkini", "guido@gmail.com", "fifi", false);
            var users = um.GetUsers(new System.Collections.Hashtable());
            Console.WriteLine("Added Guido.");
            foreach (var userz in users)
            {
                Console.WriteLine("Name: {0}\tEmail:{1}\tAdmin:{2}", userz.Name, userz.Email, userz.isAdmin);
            }

        }
    }
}
