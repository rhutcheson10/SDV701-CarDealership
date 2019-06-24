using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class clsVehicleBrands
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
       

        public List<clsAllVehicles> VehicleList { get; set; }
     
    }


    public class clsAllOrders
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DatePurchased { get; set; }

        public int CarID { get; set; }

        public override string ToString()

        {

            return CarID + "\t" + "\t" + Name + "\t" + "\t" + Email + "\t" + "\t" + DatePurchased;

             
        }

       
    }

    public class clsAllVehicles
    {
        
        public int CarID { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public char Type { get; set; }
        public decimal Price { get; set; }
        public string Finnance { get; set; }
        public string Warranty { get; set; }
        public string Mileage { get; set; }
        public string Rego { get; set; }
        public DateTime DateLastModified { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }

        public static readonly string FACTORY_PROMPT = "Enter N for New and S for secondhand";

        public static clsAllVehicles CarType(char prType)
        {
            return new clsAllVehicles() { Type = Char.ToUpper(prType) };
        }

        public override string ToString()

        {


            return Model + "\t" + "\t" + Year + "\t" + "\t" + Price + "\t" + "\t" + Type;

          

        }

    }

}