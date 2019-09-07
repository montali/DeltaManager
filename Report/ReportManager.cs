using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.Utils;
using System;
using System.Collections;
using DeltaManager.DBManagerServiceReference;
using System.Collections.Generic;
using System.ServiceModel;

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
            try { 
                Report report = new Report();
                report.ID = DBManager.GetMaxReport() + 1;
                report.Message = Message;
                report.Subject = Subject;
                report.ReportedBooking = ReportedBooking;
                return DBManager.AddReport(report);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
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
            try { 
                return new List<Report>(DBManager.GetReportsForCar(CarPlate));
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
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
            try { 
                return DBManager.GetReportByID(ID);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
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
            try { 
                 return DBManager.DeleteReport(ID);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
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
            try
            {
                var reports = DBManager.GetReportsForBooking(BookingID);
                if (reports != null)
                    return new List<Report>(reports);
                else
                    return new List<Report>();
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
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
            try
            {
                return DBManager.UpdateReport(report);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

    }
}
