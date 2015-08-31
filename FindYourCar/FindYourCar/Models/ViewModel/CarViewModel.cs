using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindYourCar.Models.ViewModel
{
    public class CarViewModel
    {
        //public CarViewModel()
        //{
            
        //}

        //public CarViewModel(CarModel model)
        //{
        //    Id = model.Id;
        //    Make = model.Model;
        //    Make = model.Make;
        //    Year = model.Year;
        //    Variant = model.Variant;
        //    Type = model.Type;
        //    EngineType = model.EngineType;
        //    Color = model.Color;
        //    Price = model.Price;
        //    Mileage = model.Mileage;
        //    Capacity = model.Capacity;
        //    NumberOfOwners = model.NumberOfOwners;
        //    Condition = model.Condition;
        //    Status = model.Status;
        //    Transmission = model.Transmission;
        //    Fuel = model.Fuel;
        //    AdditionalInfo = model.AdditionalInfo;
        //}
        public int Id { set; get; }

        [Required]
        [Display(Name = "Make e.g. Honda")]
        public String Make { set; get; }

        [Display(Name = "Model e.g. Accord")]
        public String Model { set; get; }

        [Display(Name = "Year")]
        public int Year { set; get; }

        [Display(Name = "Variant e.g E1")]
        public String Variant { set; get; }

        [Display(Name = "Type")]
        public String Type { set; get; }

        [Display(Name = "Engine Type")]
        public String EngineType { set; get; }

        [Display(Name = "Color")]
        public String Color { set; get; }

        [Required]
        [Display(Name = "Price")]
        public int Price { set; get; }

        [Required]
        [Display(Name = "Mileage")]
        public int Mileage { set; get; }

        [Display(Name = "Capacity")]
        public String Capacity { set; get; }

        [Display(Name = "Number of Owners")]
        public int NumberOfOwners { set; get; }

        [Display(Name = "Condition")]
        public String Condition { set; get; }

        [Display(Name = "Status")]
        public String Status { set; get; }

        [Display(Name = "Transmission")]
        public String Transmission { set; get; }

        [Display(Name = "Fuel")]
        public String Fuel { set; get; }

        [Display(Name = "AdditionalInfo")]
        public String AdditionalInfo { set; get; }
    }
}