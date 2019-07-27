using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using Delta.DeltaManager.Utils;
using DeltaManager.DBManagerServiceReference;

namespace Delta.DeltaManager.UserNS
{
    [ServiceContract(Namespace="Delta.DeltaManager.UserNS")]
    public interface IUserManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool CreateUser(string Name, string Email, string PassHash, bool isAdmin, DateTime? LicenseExpiration = null, int LicensePoints = 20);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool DeleteUser(User DeletableUser, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<User> GetUsers(string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool IsAdmin(string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool LoginChecker(string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool UpdateUser(User UpdatableUser, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        User GetUserByEmail(string SearchedEmail, string Email, string MD5PassHash);
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool AddUser(User user, string Email, string MD5PassHash);


    }
}