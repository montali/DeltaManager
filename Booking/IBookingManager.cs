using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.BookingNS
{
    [ServiceContract(Namespace = "Delta.DeltaManager.BookingNS")]
    public interface IBookingManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool BookCar(Car BookedCar, DateTime Start, DateTime End, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool DeleteBooking(Booking DeletableBooking, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool EndBooking(Booking EndedBooking, int NewKilometers, int Liters);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Booking> GetBookings(string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Booking> GetBookingsForCar(Car car, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Booking> GetBookingsForUser(string UserEmail, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Booking GetBookingByID(int ID, string Email, string MD5PassHash);


    }
}