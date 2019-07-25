using System.Collections;
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
        bool addCarService(Service ServiceDone, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        ArrayList GetCarServicesForCar(Car ServicedCar, string Email, string MD5PassHash);
    }
}