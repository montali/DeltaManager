using System;
using System.Collections;
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
           return true;// return DBManager.BookCar(BookedCar, Start, End);
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
           return true;// return DBManager.DeleteBooking(DeletableBooking);
        }

        public bool EndBooking (Booking EndedBooking, int NewKilometers, int Liters)
        {
            EndedBooking.BookedCar.Kilometers = NewKilometers;
            EndedBooking.BookedCar.BurnedLiters = Liters;
           return true;// return DBManager.DeleteBooking(EndedBooking);
        }
    }
}
