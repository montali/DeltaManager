using Delta.DeltaManager.CarNS;
using Delta.DeltaManager.Utils;
using System;
using System.Collections;
using DeltaManager.DBManagerServiceReference;


namespace Delta.DeltaManager.ReportNS
{


    public class ReportManager : IReportManager
    {
        DBManagerInterfaceClient DBManager;
        public ReportManager()
        {
            DBManager = new DBManagerInterfaceClient();
        }
        public bool AddReport (Report report, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return true;// return DBManager.AddReport(report);
        }

        public ArrayList retrieveReportsForCar (Car car, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return null;// return DBManager.GetReportsForCar(car);
        }
    }
}
