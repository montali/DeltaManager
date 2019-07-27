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
        bool addCarService(int Kilometers, Car ServicedCar, float TotalSpent, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Service> GetCarServicesForCar(string Plate, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool DeleteService(int ID, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Service GetServiceByID(int ID, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool UpdateService(Service service, string Email, string MD5PassHash);

    }
}