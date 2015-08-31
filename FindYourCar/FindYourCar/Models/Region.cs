using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class Region
    {
        public Region()
        {
            
        }

        public int ZipCode { set; get; }
        public String State { set; get; }
        public String City { set; get; }
    }
}