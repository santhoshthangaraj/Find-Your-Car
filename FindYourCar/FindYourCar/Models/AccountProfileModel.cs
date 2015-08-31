using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class AccountProfileModel
    {
        public AccountProfileModel()
        {
            
        }
        public AccountModel User { set; get; }
        public ProfileTypeModel Profile { set; get; }
    }
}