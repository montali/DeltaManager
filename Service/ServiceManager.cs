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
        public bool addCarService(Service ServiceDone, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return true;// return DBManager.addCarService(ServiceDone);
        }

        public ArrayList GetCarServicesForCar(Car ServicedCar, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return null;// return DBManager.getCarServicesForCar(ServicedCar);
        }
    }
}
