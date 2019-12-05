using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Models.DummyDataModel
{
    public class LoginViewModel
    {
        public IEnumerable<LoginModel> GetUserCredential()
        {
            List<LoginModel> loginModels = new List<LoginModel>();
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam1" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam2" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam3" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam4" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam5" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam6" });
            loginModels.Add(new LoginModel() { Password = "A1ok09000@", UserName = "alok.gautam7" });
            return loginModels;
        }
    }
}
