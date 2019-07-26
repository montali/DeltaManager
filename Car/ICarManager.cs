using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.CarNS
{
    [ServiceContract(Namespace = "Delta.DeltaManager.CarNS")]
    public interface ICarManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool AddCar(Car car, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool DeleteCar(Car car, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Car GetCarByPlate(string Plate, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Car> GetAvailableCars(DateTime Start, DateTime End, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Car> GetCars(string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool UpdateCar(Car UpdatableCar, string Email, string MD5PassHash);
    }
}