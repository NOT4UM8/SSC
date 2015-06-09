using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSC.Models
{
    public class AccountModel
    {
    }

    public class LoginInputModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class AccountDataModel
    {
        public bool Login(LoginInputModel loginInput)
        {
            using (SSCEntities db = new SSCEntities())
            {
                try
                {
                    var result = (from dt in db.User
                                  where dt.Email == loginInput.Email && dt.Password == loginInput.Password
                                  select dt).FirstOrDefault();
                    if (result != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                { 
                    
                }
            }
            return false;
        }
    }
}