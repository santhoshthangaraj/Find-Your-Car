using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using FindYourCar.Models.ViewModel;

using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FindYourCar.DAO_Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using FindYourCar.Models;
using FindYourCar.Models.ViewModel;

namespace FindYourCar.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(SearchViewModel tempModel)
        {
            List<CarViewModel> carViewModels = new ListStack<CarViewModel>();

            //put code of search DAO

            CarDAO.GetCar(tempModel);

            return RedirectToAction("SearchResult",new{carViewModels});

        }

        public ActionResult SearchResult(List<CarViewModel> carViewModels)
        {
            return View(carViewModels);
        }
    }
}