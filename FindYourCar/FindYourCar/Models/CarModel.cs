using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindYourCar.Models.ViewModel;

namespace FindYourCar.Models
{
    public class CarModel
    {
        public CarModel()
        {
            
        }

        public CarModel(CarViewModel model)
        {
           Make = model.Model;
            //Make = model.Make;
           // Year = model.Year;
            Variant = model.Variant;
            Type = model.Type;
            EngineType = model.EngineType;
            Color = model.Color;
            Price = model.Price;
            Mileage = model.Mileage;
            Capacity = model.Capacity;
            NumberOfOwners = model.NumberOfOwners;
            Condition = model.Condition;
            Status = model.Status;
            Transmission = model.Transmission;
            Fuel = model.Fuel;
            AdditionalInfo = model.AdditionalInfo;
        }
        public int Id { set; get; }
        public String Make { set; get; }
        public String Model { set; get; }
        public int Year { set; get; }
        public String Variant { set; get; }
        public String Type { set; get; }
        public String EngineType { set; get; }
        public String Color { set; get; }
        public int Price { set; get; }
        public int Mileage { set; get; }
        public String Capacity { set; get; }
        public int NumberOfOwners { set; get; }
        public String Condition { set; get; }
        public String Status { set; get; }
        public String Transmission { set; get; }
        public String Fuel { set; get; }
        public String AdditionalInfo { set; get; }

    }
}