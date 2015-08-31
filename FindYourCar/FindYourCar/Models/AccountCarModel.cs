using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class AccountCarModel
    {
        public AccountCarModel()
        {
            
        }
        public AccountModel User { set; get; }
        public CarModel Car { set; get; }

    }
}