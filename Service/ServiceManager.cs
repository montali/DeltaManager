﻿using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DeltaManager.DBManagerServiceReference;

using System.Text;
using System.ServiceModel;

namespace Delta.DeltaManager.ServiceNS
{
    class ServiceManager : IServiceManager
    {
        private DBManagerInterfaceClient DBManager;
        public ServiceManager()
        {
            DBManager = new DBManagerInterfaceClient();
        }
        public bool addCarService(int Kilometers, Car ServicedCar, float TotalSpent, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            try
            {
                Service ServiceDone = new Service();
                ServiceDone.ID = DBManager.GetMaxService() + 1;
                ServiceDone.TotalSpent = TotalSpent;
                ServiceDone.ServicedCar = ServicedCar;
                ServiceDone.Kilometers = Kilometers;
                return DBManager.AddService(ServiceDone);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public List<Service> GetCarServicesForCar(string Plate, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            try
            {
                var services = DBManager.GetServicesForCar(Plate);
                if (services != null)
                    return new List<Service>(services);
                else
                    return new List<Service>();
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public Service GetServiceByID(int ID, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            try
            {
                return DBManager.GetServiceByID(ID);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public bool DeleteService (int ID, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            try
            {
                return DBManager.DeleteService(ID);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }
         public bool UpdateService(Service service, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            try
            {
                return DBManager.UpdateService(service);
            } catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
}

    }
}
