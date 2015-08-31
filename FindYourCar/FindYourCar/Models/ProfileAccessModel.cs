using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class ProfileAccessModel
    {
        public ProfileAccessModel()
        {
            
        }
        public ProfileTypeModel ProfileType { set; get; }
        public AccessModel Access { set; get; }
    }
}