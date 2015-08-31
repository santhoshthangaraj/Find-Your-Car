using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models
{
    public class DealsHistoryModel
    {
        public DealsHistoryModel()
        {
            
        }
        public CarModel Car { set; get; }
        public String CardInfo { set; get; }
        public AccountModel Buyer { set; get; }
        public DateTime DateTime { set; get; }
    }
}