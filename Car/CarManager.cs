using System;
using System.Collections;
using System.Collections.Generic;
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
           return DBManager.DeleteCar(car);
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
           return new List<Car>(DBManager.GetCars());
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
           return DBManager.UpdateCar(UpdatableCar);
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
           return new List<Car>(DBManager.GetAvailableCars(Start, End));
        }
    }
}