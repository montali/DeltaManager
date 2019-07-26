using System.Collections;
using System.Collections.Generic;
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
        bool AddReport(string Message, string Subject, Booking ReportedBooking, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Report> retrieveReportsForCar(Car car, string Email, string MD5PassHash);
    }
}