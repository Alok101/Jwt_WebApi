using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;
using SampleApp.Models.DummyDataModel;

namespace SampleApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("Login",new LoginModel());
        }
        [HttpPost]
        public IActionResult SignIn(LoginModel model)
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            var user = loginViewModel.GetUserCredential();
            if (user.Where(x => x.Password == model.Password && x.UserName == model.UserName) == null)
                return View();
            return View();
        }
    }
}