using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindYourCar.DAO_Models;
using FindYourCar.Models;
using FindYourCar.Models.ViewModel;

namespace FindYourCar.Controllers
{
    public class NewCarController : Controller
    {
        // GET: Car
        public ActionResult NewCarPage()
        {
            return View();
        }

        public ActionResult EnterNewCar(CarViewModel tempModel)
        {
            CarModel carModel = new CarModel(tempModel);
            int CarId=1;
            CarDAO.InsertCar(carModel);
            CarPhotoViewModel carPhotoViewModel = new CarPhotoViewModel();
            carPhotoViewModel.Id = CarId;
            return RedirectToAction("UploadPhoto", new { carPhotoViewModel });

        }

        public ActionResult UploadPhoto(CarPhotoViewModel carPhotoViewModel)
        {
            return View(carPhotoViewModel);
        }


        //Must be Edited
        public ActionResult Upload(HttpPostedFileBase file, CarPhotoViewModel carPhotoViewModel)
        {
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/img/UserCars"), pic);
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

            }
            // after successfully uploading redirect the user
            return RedirectToAction("Index", "Home");
        }

    }
}