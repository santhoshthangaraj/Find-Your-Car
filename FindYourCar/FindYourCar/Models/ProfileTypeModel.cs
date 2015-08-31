using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class ProfileTypeModel
    {
        public ProfileTypeModel()
        {
            
        }
        public int Id { set; get; }
        public String Type { set; get; }
        public String Function { set; get; }
    }
}