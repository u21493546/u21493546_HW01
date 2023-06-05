using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Vehicle
    {
        //properites
        public string type {  get; set; }
        public string registration { get; set; }
        public string service { get; set; }
        public int DriverServiceID { get; set; }
        public string image { get; set; }
    }
}