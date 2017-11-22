﻿using System.Web.Mvc;
using System.Web.Security;
using UI.Models;
using UI.Service;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult SignIn(SignInModel credentials)
        {
            if (ModelState.IsValid)
            {
                if (DataService.Service.UserService.CheckCredentials(credentials.Email, credentials.Password))
                {
                    var currentUser = DataService.Service.UserService.FindByEmail(credentials.Email);
                    string cookie = $"{currentUser.Id}-{currentUser.Role}-{currentUser.Name} {currentUser.Lastname}";

                    FormsAuthentication.SetAuthCookie(cookie, true);
                    return Redirect("/User/Main");                  
                }
            }

            return Redirect("/Home/index");
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}