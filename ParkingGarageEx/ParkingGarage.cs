using ParkingGarageEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageEx
{
    internal class ParkingGarage
    {
        public int ParkingSpots { get; set; } = 50;
        public double BasePrice { get; set; } = 300;
        public double MaxPrice { get; set; } = 1500;
        public List<Vehicle> ParkedVehicles { get; private set; } = [];

        public void CheckIn(Vehicle vehicle)
        {
            if (vehicle == null ||
                vehicle.Model == null ||
                vehicle.Plate == null ||
                vehicle.CheckInTime == null)
            {
                throw new ArgumentException("INVALID ARGUMENTS");
            }
            var found = CheckIfPresent(vehicle.Plate);
            if (found)
            {
                throw new Exception("Vehicle is already present");
            }
            if (ParkedVehicles.Count() >= ParkingSpots)
            {
                throw new Exception("Parking lot is full");
            }
            vehicle.Plate = vehicle.Plate.Replace(" ", "");
            ParkedVehicles.Add(vehicle);
            Console.WriteLine("Makina u shtua ne parking");

        }

        public bool CheckIfPresent(string plate)
        {
            bool found = false;
            var cleanPlate = plate.Replace(" ", "");
            //metoda .Replace ben replace hapsirave dmth " " me asgj "" , dmth i fshin 
            foreach (var vehicle in ParkedVehicles)
            {
                if (string.Equals(cleanPlate, vehicle.Plate, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public void CheckOut(Vehicle vehicle)
        //regulloje te marr string targen si parameter sepse mund t ket mshum se 2 makina t njejta e targa i dallon 
        //ose mund ta lesh sepse mund t supozojme qe makines i krijohet nje emer kur ben checkin dmth kur
        //inicializohet objekti dhe me ate i bejm checkout
        //me e sakta eshte ajo tek gr- shikoje n shpi
        {
            Console.WriteLine("Enter plate number for the vehicle you want to checkout");
            string plate = Console.ReadLine();
            bool found = CheckIfPresent(plate);
            if (found)
            {
                ParkedVehicles.Remove(vehicle);
            }
            else if (!found)
            {
                throw new Exception("Vehicle is not in the parking lot");
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }

        public Dictionary<string, int> GetSummary()
        {

        }

        public decimal GetInvoice(string plate)
        {

        }

        //Plotso metodat edhe rregullo metoden CheckIfPresent
        //qe t kthej type Vehicle e ta implementoj pjesen e
        //foreachit qe ta perdorim per metodat e tjera
        


        //Shembull per metodat statike
        public static void Print()
        {
            Console.WriteLine("This is a static method");
            //i perket vetem klases
            //nuk e aksesojm dot nepermjet obj dmth ObjName.Print()
            //por e aksesojm EmrKlase.Print()-- njesoj dhe me property nqs i bejm statike
            // psh Console.WriteLine-- Console eshte emr i klases dhe WriteLine eshte statike
            //ose Int32.Parse()-- Int32 eshte emr i klases
        }
    }
}
