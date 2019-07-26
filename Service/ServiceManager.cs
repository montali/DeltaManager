using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DeltaManager.DBManagerServiceReference;

using System.Text;

namespace Delta.DeltaManager.ServiceNS
{
    class ServiceManager : IServiceManager
    {
        private DBManagerInterfaceClient DBManager;
        public ServiceManager()
        {
            DBManager = new DBManagerInterfaceClient();
        }
        public bool addCarService(int Kilometers, Car ServicedCar, int TotalSpent, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            Service ServiceDone = new Service();
            ServiceDone.ID = DBManager.GetMaxService();
            ServiceDone.TotalSpent = TotalSpent;
            ServiceDone.ServicedCar = ServicedCar;
            ServiceDone.Kilometers = Kilometers;
           return DBManager.AddService(ServiceDone);
        }

        public List<Service> GetCarServicesForCar(Car ServicedCar, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List <Service>(DBManager.GetServicesForCar(ServicedCar));
        }
    }
}
