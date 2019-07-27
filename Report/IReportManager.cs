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
        List<Report> getReportsForCar(string CarPlate, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Report getReportByID(int ID, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool DeleteReport(int ID, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Report> getReportsForBooking(int BookingID, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool UpdateReport(Report report, string Email, string MD5PassHash);


    }
}