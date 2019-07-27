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

        public List<Report> getReportsForCar (string CarPlate, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<Report>(DBManager.GetReportsForCar(CarPlate));
        }
        public Report getReportByID(int ID, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            return DBManager.GetReportByID(ID);
        }
        public bool DeleteReport(int ID, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            return DBManager.DeleteReport(ID);
        }
        public List<Report> getReportsForBooking(int BookingID, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            var reports = DBManager.GetReportsForBooking(BookingID);
            if (reports != null)
                return new List<Report>(reports);
            else
                return new List<Report>();
        }

        public bool UpdateReport(Report report, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            return DBManager.UpdateReport(report);
        }

    }
}
