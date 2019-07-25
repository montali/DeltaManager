using System.Collections;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.ReportNS
{
    [ServiceContract(Namespace = "Delta.DeltaManager.ReportNS")]
    public interface IReportManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool AddReport(Report report, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        ArrayList retrieveReportsForCar(Car car, string Email, string MD5PassHash);
    }
}