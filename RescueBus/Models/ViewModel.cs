using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class ViewModel
    {
        public string SelectedService { get; set; }
        public string SelectedVehicle { get; set; }
        public string SelectedDriver { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Bookings> Bookings { get; set; }
    }
}