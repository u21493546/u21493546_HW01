using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Bookings
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
    }
}