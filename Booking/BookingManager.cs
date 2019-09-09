using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;


namespace Delta.DeltaManager.BookingNS
{
    public class BookingManager : IBookingManager
    {
        private DBManagerInterfaceClient DBManager;

        public BookingManager()
        {
            DBManager = new DBManagerInterfaceClient();
        }
        public bool BookCar (Car BookedCar, DateTime Start, DateTime End, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            Booking newBooking = new Booking();
            newBooking.BookedCar = BookedCar;
            newBooking.Start = Start;
            newBooking.End = End;
            newBooking.Booker = DBManager.GetUserByEmail(Email);
            newBooking.ID = DBManager.GetMaxBooking() + 1;
            try
            {
                return DBManager.BookCar(newBooking);
            } catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public bool DeleteBooking (Booking DeletableBooking, string Email, string MD5PassHash)
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
                var BookingReports = DBManager.GetReportsForBooking(DeletableBooking.ID);
                foreach (var Report in BookingReports)
                {
                    DBManager.DeleteReport(Report.ID);
                }
                return DBManager.DeleteBooking(DeletableBooking);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public bool EndBooking (Booking EndedBooking, int NewKilometers, int Liters, string Email, string MD5PassHash)
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
            var BookingReports = DBManager.GetReportsForBooking(EndedBooking.ID);
            foreach (var Report in BookingReports)
            {
                DBManager.DeleteReport(Report.ID);
            }
            EndedBooking.BookedCar.Kilometers = NewKilometers;
            EndedBooking.BookedCar.BurnedLiters += Liters;
            DBManager.UpdateCar(EndedBooking.BookedCar);
            return DBManager.DeleteBooking(EndedBooking);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }

        public List<Booking> GetBookings (string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return new List<Booking>();
            }
            try {
                return new List<Booking>(DBManager.GetBookings());
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }
        public List<Booking> GetBookingsForCar(Car car, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return new List<Booking>();
            }
            try { 
            return new List<Booking>(DBManager.GetBookingsForCar(car));
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }
        public List<Booking> GetBookingsForUser(string UserEmail, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return new List<Booking>();
            }
            try { 
            return new List<Booking>(DBManager.GetBookingsForUser(UserEmail));
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }
        public Booking GetBookingByID (int ID, string Email, string MD5PassHash)
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
            return DBManager.GetBookingByID(ID);
            }
            catch (FaultException<DatabaseFault> df)
            {
                throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
            }
        }


    }
}
