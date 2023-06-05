using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class ListRepository
    {
        //populate lists

        public static List<Driver> GetDrivers()
        {
            return new List<Driver>
            {
                new Driver{ firstName = "Tsolo", lastName = "Makeba", phoneNumber = "+27 79 345 6789", service = "ALS (Advanced Life Support)", image = "MaleStock.png", ServiceID = 1},
                new Driver{ firstName = "John", lastName = "Doe", phoneNumber = "+27 65 448 5856", service = "ALS (Advanced Life Support)", image = "MaleStock.png", ServiceID = 1},
                new Driver{ firstName = "Jenny", lastName = "Adams", phoneNumber = "+27 79 587 1558", service = "ALS (Advanced Life Support)", image = "FemaleStock.jpg", ServiceID = 1},
                new Driver{ firstName = "Kgali", lastName = "Letsika", phoneNumber = "+27 82 699 3877", service = "BLS (Basic life Support)", image = "FemaleStock.jpg", ServiceID = 2},
                new Driver{ firstName = "Noma", lastName = "Ndlovu", phoneNumber = "+27 82 675 2265", service = "BLS (Basic Life Support)", image = "FemaleStock.jpg", ServiceID = 2},
                new Driver{ firstName = "Mattias", lastName = "Kennedy", phoneNumber = "+27 66 496 5691", service = "Patient Transport", image = "MaleStock.png", ServiceID = 3},
                new Driver{ firstName = "Tomhas", lastName = "Exotic", phoneNumber = "+27 60 924 3178", service = "Patient Transport", image = "MaleStock.png", ServiceID = 3},
                new Driver{ firstName = "Thabo", lastName = "Dube", phoneNumber = "+27 76 358 9997", service = "Patient Transport", image = "MaleStock.png", ServiceID = 3},
                new Driver{ firstName = "Amanda", lastName = "Golka", phoneNumber = "+27 76 934 3792", service = "Medical Utility Vehicle", image = "FemaleStock.jpg", ServiceID = 4},
                new Driver{ firstName = "Thando", lastName = "Mbongi", phoneNumber = "+27 83 948 3162", service = "Medical Utility Vehicle", image = "FemaleStock.jpg", ServiceID = 4},
                new Driver{ firstName = "Elize", lastName = "Jantjies", phoneNumber = "+27 83 439 6721", service = "Event Medical Ambulance", image = "FemaleStock.jpg", ServiceID = 5},
                new Driver{ firstName = "Tsegho", lastName = "Chepu", phoneNumber = "+27 79 658 7956", service = "Air Ambulance", image = "MaleStock.png", ServiceID = 6},
                new Driver{ firstName = "Xander", lastName = "Matthews", phoneNumber = "+27 607 9463", service = "Air Ambulance", image = "MaleStock.png", ServiceID = 6}
            };
        }

        public static List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle{ type = "Type 1", registration = "AA00AA", service = "ALS (Advanced Life Support)", image ="VehicleStock.jpg",  DriverServiceID = 1},
                new Vehicle{ type = "Type 2", registration = "SF64BJ", service = "ALS (Advanced Life Support)", image ="VehicleStock.jpg",  DriverServiceID = 1},
                new Vehicle{ type = "Type 1", registration = "BH49TC", service = "BLS (Basic life Support)", image ="VehicleStock.jpg",  DriverServiceID = 2},
                new Vehicle{ type = "Type 3", registration = "TD99HG", service = "BLS (Basic life Support)", image ="VehicleStock.jpg",  DriverServiceID = 2},
                new Vehicle{ type = "Type 2", registration = "ZZ29UN", service = "Patient Transport", image ="VehicleStock.jpg",  DriverServiceID = 3},
                new Vehicle{ type = "Type 4", registration = "IH81PP", service = "Patient Transport", image ="VehicleStock.jpg",  DriverServiceID = 3},
                new Vehicle{ type = "Type 1", registration = "AS33BT", service = "Patient Transport", image ="VehicleStock.jpg",  DriverServiceID = 3},
                new Vehicle{ type = "Type 3", registration = "QU35WW", service = "Medical Utility Vehicle", image ="VehicleStock.jpg",  DriverServiceID = 4},
                new Vehicle{ type = "Type 2", registration = "KL49SX", service = "Event Medical Ambulance", image ="VehicleStock.jpg",  DriverServiceID = 5},
                new Vehicle{ type = "Type 5", registration = "HELI01", service = "Air Ambulance", image ="VehicleStock.jpg",  DriverServiceID = 6},
                new Vehicle{ type = "Type 5", registration = "HELI02", service = "Air Ambulance", image ="VehicleStock.jpg",  DriverServiceID = 6}
            };
        }
    }
}