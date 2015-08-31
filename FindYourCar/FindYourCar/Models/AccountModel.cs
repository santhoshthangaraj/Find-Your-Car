using System;
using FindYourCar.Models.ViewModel;

namespace FindYourCar.Models
{
    public class AccountModel
    {
        public AccountModel()
        {
            
        }

        public AccountModel(AccountViewModel model)
        {
            Email = model.Email;
            Password = model.Password;
            FirstName = model.FirstName;
            MiddleInitial = model.MiddleInitial;
            LastName = model.LastName;
            DateOfBirth = model.DateOfBirth;
            PhoneNumber = model.PhoneNumber;
            AddressLine1 = model.AddressLine1;
            AddressLine2 = model.AddressLine2;
            ZipCode = model.ZipCode;
            StartTime=DateTime.Now;
            
        }

        public String Email { set; get; }
        public String Password { set; get; }
        public String FirstName { set; get; }
        public Char MiddleInitial { set; get; }
        public String LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public String PhoneNumber { set; get; }
        public String AddressLine1 { set; get; }
        public String AddressLine2 { set; get; }
        public int ZipCode { set; get; }
        public DateTime StartTime { set; get; }


        
    }
}