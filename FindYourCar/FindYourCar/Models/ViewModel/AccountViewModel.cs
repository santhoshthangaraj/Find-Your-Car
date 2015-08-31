using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindYourCar.Models.ViewModel
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            
        }

        public AccountViewModel(AccountModel model)
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
        }

        [Required]
        [Display(Name = "Email")]
        public String Email { set; get; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { set; get; }

        [Display(Name = "First Name")]
        public String FirstName { set; get; }

        [Display(Name = "Middle Initial")]
        public Char MiddleInitial { set; get; }

        [Display(Name = "Last Name")]
        public String LastName { set; get; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { set; get; }

        [Phone]
        [Display(Name = "Phone Number")]
        public String PhoneNumber { set; get; }

        [Display(Name = "Address Line 1")]
        public String AddressLine1 { set; get; }

        [Display(Name = "Address Line 2")]
        public String AddressLine2 { set; get; }

        [Display(Name = "Zip Code")]
        public int ZipCode { set; get; }
    }
}