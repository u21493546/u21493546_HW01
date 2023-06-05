using RescueBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RescueBus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RideHistory()
        {

            return View();
        }

        public ActionResult Manage() 
        {
            var viewModel = new ViewModel
            {
                Drivers = ListRepository.GetDrivers(),
                Vehicles = ListRepository.GetVehicles()
            };
            return View(viewModel);
        }

        

        public ActionResult SelectService()
        {
            return View();
        }

        public ActionResult BookingConfirmed()
        {
            return View();
        }

        public ActionResult Booking()
        {
            var viewModel = new ViewModel
            {
                Drivers = ListRepository.GetDrivers(),
                Vehicles = ListRepository.GetVehicles()
            };
            return View(viewModel);
        }
        
        //public ActionResult GetBookingData()
        //{
        //    var Bookings = _context.Bookings.SingleOrDefualt(b => b.ID == ViewModel.Bookings.ID);
        //    Bookings = _context.Bookings.SingleOrDefualt(b => b.ID == ViewModel.Bookings.Date);
        //    Bookings = _context.Bookings.SingleOrDefualt(b => b.ID == ViewModel.Bookings.Address);

        //    Bookings.Add(Bookings);

        //    _context.SaveChanges();
        //    return View(Bookings);
        //}
    }
}