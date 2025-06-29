using System;
using System.Data;
using System.Net;
using System.Security.Policy;
using LicensesDataAccessLayer;

namespace BussinessLayer
{
   public class clsUser
   {
    enum enMode { enUpdate , enAddnew};

    enMode _Mode = enMode.enUpdate;
    public int UserID { get; set; }
    
    public int PersonID { get; set; }
    
    public string UserName { get; set; }
    
    public string Password { get; set; } 
    
    public bool isActive { get; set; }

    public clsUser()
    {
       UserID = -1;
       PersonID = -1;
       UserName = "";
       Password = "";
       isActive = false;
       _Mode =enMode.enAddnew;


    }

    private clsUser(int userID, int personID, string userName, string password, bool isActive)
    {
           this.UserID = userID;
           this.PersonID = personID;
           this.UserName = userName;
           this.Password = password;
           this.isActive = isActive;
          _Mode = enMode.enUpdate;

    }

    private bool AddNewUser()
    {
      this.UserID = clsUserData.AddNewUser(this.PersonID,this.UserName, this.Password, this.isActive);

       return (this.UserID != -1);
    }
    
    public bool UpdateUserPass()
    {
        return clsUserData.UpdateUserPassword(this.UserID, this.Password);
    }

    private bool UpdateUser()
    {
      return clsUserData.UpdateUser(this.PersonID,this.UserName,this.Password,this.isActive);
    }

    public bool Save()
    {
            if(_Mode == enMode.enAddnew)
            {
                if(AddNewUser())
                {
                    _Mode = enMode.enUpdate;
                    return true;
                }
            }

            else
            {
                if(UpdateUser())
                {
                    return true;
                }
            }

            return false;    
    }

    public static clsUser Find(int UserID)
    {
        int PersonID = -1;
        string UserName = "";
        string Password = "";
        bool isActive = false;

        if (clsUserData.GetUserInfo(UserID, ref PersonID, ref UserName, ref Password, ref isActive))
        {
            return new clsUser(UserID, PersonID, UserName, Password, isActive);
        }
        else
           return null;    
    }

    public static clsUser Find(string Username , string password)
     {
         int PersonID = -1;
         int UserID = -1;
         bool isActive = false;

         if (clsUserData.GetUserInfo(Username,  password, ref PersonID, ref isActive , ref UserID))
         {
             return new clsUser(UserID, PersonID, Username, password, isActive);
         }
         else
             return null;
     }

    public static clsUser FindByID(int PersonID)
     {
        int UserID = -1;
        string username = "";
        string password = "";
        bool isActive = false;

       if(clsUserData.GetUserInfoByPersonID(PersonID , ref UserID , ref username , ref password , ref isActive))
        {
          return new clsUser(UserID, PersonID, username, password, isActive);
        }
          else return null;

     }

    public static bool IsUserExist(int PersonID)
     {
         return clsUserData.isUserExist(PersonID);
     }

    public static bool IsUserExist(string UserName)
     {
        return clsUserData.isUserExist(UserName);
     }

    public static DataTable GetData()
     {
        return clsUserData.GetUsersData();
     }

    public static bool CheackForLogin(string username , string password)
     {
        return clsUserData.CheackUserNameAndPassword(username, password); 
     }

    public static bool DeleteUser(int UserID)
    {
       return clsUserData.DeleteUser(UserID);
    }

     

   }
}
