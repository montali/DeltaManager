using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.ServiceNS
{
    [ServiceContract(Namespace = "Delta.DeltaManager.ServiceNS")]
    interface IServiceManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool addCarService(int Kilometers, Car ServicedCar, int TotalSpent, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Service> GetCarServicesForCar(Car ServicedCar, string Email, string MD5PassHash);
    }
}