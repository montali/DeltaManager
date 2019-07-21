using System;
using System.Collections;
using System.Collections.Generic;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.CarNS {
    public class CarManager
    {
        private DBManagerInterfaceClient DBManager;
        public CarManager()
        {
            this.DBManager = new DBManagerInterfaceClient();
        }

        public bool AddCar(Car car, Hashtable Authorization)
        {

            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            return this.DBManager.AddCar(car);
        }

        public bool DeleteCar(Car car, Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return DBManager.DeleteCar(car);
        }

        public List<Car> GetCars (Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<Car>(DBManager.GetCars());
        }

        public bool UpdateCar (Car UpdatableCar, Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return DBManager.UpdateCar(UpdatableCar);
        }

        public List<Car> GetAvailableCars(DateTime Start, DateTime End, Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<Car>(DBManager.GetAvailableCars(Start, End));
        }
    }
}