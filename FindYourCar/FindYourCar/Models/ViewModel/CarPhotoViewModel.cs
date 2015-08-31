using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindYourCar.Models.ViewModel
{
    public class CarPhotoViewModel
    {
        public CarPhotoViewModel()
        {
            
        }

        public CarPhotoViewModel(CarPhotoModel model)
        {
            Id = model.Id;
            Contents = model.Contents;
            Image = model.Image;
        }
        /// <summary>
        /// Get and Set id
        /// </summary>
        public int Id { get; set; }

        public int CarId { set; get; }

        [AllowHtml]
        [Required]
        public string Contents { get; set; }
        /// <summary>
        /// Images
        /// </summary>
        [Required]
        public byte[] Image { get; set; }
    }
}