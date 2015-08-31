using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FindYourCar.DAO_Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using FindYourCar.Models;
using FindYourCar.Models.ViewModel;

namespace FindYourCar.Controllers
{
    
    public class AccountController : Controller
    {
        #region LogIn

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {

                bool temp = true;
                try
                {
                    temp = model.Email == "admin@FindYourProf.com";
                    temp = model.Password == "123";


                    temp = Membership.ValidateUser(model.Email, model.Password);


                }
                catch (Exception e)
                {

                    System.Console.WriteLine("Error");
                }

                return RedirectToAction("Index", "Home");

            }

            return RedirectToAction("LogIn", "Account");
        }

    #endregion

        #region Log off

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region Log On

        public ActionResult Register()
        {
            return View();
        }



        public ActionResult DoRegister(AccountViewModel model)
        {
            AccountModel accountModel = new AccountModel(model);

            AccountDAO.InsertAccount(accountModel);
            //put a call to insert Account Method

            ViewData["Message"] = "Now Enter With Your Username and Password";

            //Members is Umbraco
            //Membership.CreateUser(model.Email, model.Password);

            return RedirectToAction("LogIn");
            //AccountDAO.Verify(accountModel);





        }

        #endregion
    }
}