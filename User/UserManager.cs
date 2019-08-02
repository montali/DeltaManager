using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.UserNS
{
    public class UserManager : IUserManager
    {
        private DBManagerInterfaceClient DBManager;
        public UserManager()
        {
            this.DBManager = new DBManagerInterfaceClient();
        }

        public bool LoginChecker(string Email, string MD5PassHash)
        {
            return DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
        }

        public bool IsAdmin(string Email, string MD5PassHash)
        {
            if (DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager))
                return DBManager.GetUserByEmail(Email).isAdmin;
            else
                return false;
        }

        public bool CreateUser(string Name, string Email, string PassHash,bool isAdmin, DateTime? LicenseExpiration = null, int LicensePoints=20)
        {
            User NewUser = new User();
            NewUser.Name = Name;
            NewUser.Email = Email;
            NewUser.PasswordHash = PassHash;
            NewUser.isAdmin = isAdmin;
            if (LicenseExpiration == null)
                NewUser.LicenseExpiration = new DateTime(1900, 1, 1);
            else
                NewUser.LicenseExpiration = (DateTime) LicenseExpiration;
                return DBManager.AddUser(NewUser);

        }

        public bool DeleteUser(User DeletableUser, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            var UserBookings = DBManager.GetBookingsForUser(DeletableUser.Email);
            foreach (var Booking in UserBookings)
            {
                DBManager.DeleteBooking(Booking);
            }
           return DBManager.DeleteUser(DeletableUser);
        }

        public bool UpdateUser(User UpdatableUser, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return DBManager.UpdateUser(UpdatableUser);
        }

        public List<User> GetUsers(string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<User> (DBManager.GetUsers());
        }

        public User GetUserByEmail (string SearchedEmail, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
            return DBManager.GetUserByEmail(SearchedEmail);
        }
        public bool AddUser (User user, string Email, string MD5PassHash)
        {
            try
            {
                DataValidator.CheckAuthorization(Email, MD5PassHash, this.DBManager);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
            return DBManager.AddUser(user);
        }
    }

}