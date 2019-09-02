using System;
using System.Collections;
using System.Linq;
using System.Text;
using Delta.DeltaManager.UserNS;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.Utils
{
    class DataValidator
    {
        public DataValidator()
        {
        }

    public static bool CheckAuthorization(string Email, string MD5PassHash, DBManagerInterfaceClient DBManager) 
        {
            User CheckingUser = DBManager.GetUserByEmail(Email);
            if (CheckingUser == null)
                return false;
            if (CheckingUser.PasswordHash != MD5PassHash)
                return false;
            else
                return true;

        }


    }
}
