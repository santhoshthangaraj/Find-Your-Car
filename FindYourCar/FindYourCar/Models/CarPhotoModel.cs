using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace FindYourCar.Models
{
    public class CarPhotoModel{
        public CarPhotoModel()
        {
            
        }
        public int Id { set; get; }
        public int CarId { set; get; }
        public string Contents { get; set; }
        public byte[] Image { get; set; }
    }
}