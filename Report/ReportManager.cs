using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.Utils;
using System;
using System.Collections;
using DeltaManager.DBManagerServiceReference;
using System.Collections.Generic;

namespace Delta.DeltaManager.ReportNS
{


    public class ReportManager : IReportManager
    {
        DBManagerInterfaceClient DBManager;
        public ReportManager()
        {
            DBManager = new DBManagerInterfaceClient();
        }
        public bool AddReport (string Message, string Subject, Booking ReportedBooking, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            Report report = new Report();
            report.ID = DBManager.GetMaxReport() + 1;
            report.Message = Message;
            report.Subject = Subject;
            report.ReportedBooking = ReportedBooking;

           return DBManager.AddReport(report);
        }

        public List<Report> retrieveReportsForCar (Car car, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<Report>(DBManager.GetReportsForCar(car));
        }
    }
}
