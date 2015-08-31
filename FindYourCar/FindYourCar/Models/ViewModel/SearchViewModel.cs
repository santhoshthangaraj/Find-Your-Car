using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindYourCar.Models.ViewModel
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            
        }
        public String Make { set; get; }
        public String Model { set; get; }
        public String MinPrice { set; get; }
        public String MaxPrice { set; get; }
        public string Color { set; get; }
    }
}