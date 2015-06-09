using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSC.Models;

namespace SSC.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginInputModel loginInput)
        {
            AccountDataModel accountData = new AccountDataModel();
            if (loginInput != null)
            {
                if (accountData.Login(loginInput) == true)
                {
                    return RedirectToAction("LoginSuccess","Account");
                }
            }
            return View();
        }

        public ActionResult LoginSuccess()
        {
            return View();
        }
    }
}
