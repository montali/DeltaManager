using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.CarNS {
    public class CarManager : ICarManager
    {
        private DBManagerInterfaceClient DBManager;
        public CarManager()
        {
            this.DBManager = new DBManagerInterfaceClient();
        }

        public bool AddCar(Car car, string Email, string MD5PassHash)
        {

            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            return this.DBManager.AddCar(car);
        }

        public Car GetCarByPlate (string Plate, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            try { 
            return this.DBManager.GetCarByPlate(Plate);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }

        }

        public bool DeleteCar(Car car, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            try { 
            var CarBookings = DBManager.GetBookingsForCar(car);
            foreach (var Booking in CarBookings)
            {
                DBManager.DeleteBooking(Booking);
            }
            var CarServices = DBManager.GetServicesForCar(car.PlateNumber);
            foreach (var Service in CarServices)
            {
                DBManager.DeleteService(Service.ID);
            }
           return DBManager.DeleteCar(car);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public List<Car> GetCars (string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            try { 
                return new List<Car>(DBManager.GetCars());
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public bool UpdateCar (Car UpdatableCar, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            try { 
                return DBManager.UpdateCar(UpdatableCar);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public List<Car> GetAvailableCars(DateTime Start, DateTime End, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            try { 
                return new List<Car>(DBManager.GetAvailableCars(Start, End));
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }
    }
}