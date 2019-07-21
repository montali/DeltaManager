using System;
using System.Collections;
using System.Collections.Generic;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.UserNS
{
    public class UserManager
    {
        private DBManagerInterfaceClient DBManager;
        public UserManager()
        {
            this.DBManager = new DBManagerInterfaceClient();
        }

        public bool LoginChecker(Hashtable Authorization)
        {
            User LoggedUser=null;
            //loggedUser= --> QUERY A DB PER USER
            if (LoggedUser != null)
                return true;
            else
                return false;
        }

        public bool IsAdmin(Hashtable Authorization)
        {
            User loggedUser = null;//DBManager.GetCurrentUserFromDB(Authorization);
            //if (User.IsAdmin())
              //  return true;
            //else
                return false;
        }

        public bool CreateUser(string Name, string Email, string PassHash,bool isAdmin)
        {
            User NewUser = new User();
            NewUser.Name = Name;
            NewUser.Email = Email;
            NewUser.PasswordHash = PassHash;
            NewUser.isAdmin = isAdmin;
            
            return DBManager.AddUser(NewUser);
        }

        public bool DeleteUser(User DeletableUser, Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return true;// return DBManager.DeleteUser(User.email);
        }

        public bool UpdateUser(User UpdatableUser, Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return false;
            }
           return true;// return DBManager.UpdateUser(UpdatableUser);
        }

        public List<User> GetUsers(Hashtable Authorization)
        {
            try
            {
                DataValidator.CheckAuthorization(Authorization);
            }
            catch (UserNotAuthorizedException e)
            {
                return null;
            }
           return new List<User> (DBManager.GetUsers());
        }
    }

}