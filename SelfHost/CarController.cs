using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
   public class CarController : System.Web.Http.ApiController
    {
        public List<string> GetCarBrandsName()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Name FROM vehiclebrands",null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }


        public clsVehicleBrands GetCar(string Name)

        {

            Dictionary<string, object> par = new Dictionary<string, object>(1);

            par.Add("Name", Name);

            DataTable lcResult =

            clsDbConnection.GetDataTable("SELECT * FROM vehiclebrands WHERE Name = @Name", par);

            if (lcResult.Rows.Count > 0)

                return new clsVehicleBrands()

                {

                    Name = (string)lcResult.Rows[0]["Name"],
                    Slogan = (string)lcResult.Rows[0]["Slogan"],
                    VehicleList = getCarDetails(Name)
                    


                };

            else

                return null;

        }
  
        public List<clsAllOrders> GetOrder()
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM orders", null);
            List <clsAllOrders> lcOrders = new List<clsAllOrders>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add(dataRow2AllOrders(dr));
            return lcOrders;

        }

       

        private List<clsAllVehicles> getCarDetails(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM cars WHERE Name = @Name", par);
            List<clsAllVehicles> lcCarDetails = new List<clsAllVehicles>();
            foreach (DataRow dr in lcResult.Rows)
                lcCarDetails.Add(dataRow2AllWork(dr));
            return lcCarDetails;
        }

        private clsAllVehicles dataRow2AllWork(DataRow prDataRow)
        {
            return new clsAllVehicles()
            {
               CarID = Convert.ToInt16(prDataRow["CarID"]),
                Model = Convert.ToString(prDataRow["Model"]),
                Year = Convert.ToInt16(prDataRow["Year"]),
                Type = Convert.ToChar(prDataRow["Type"]),
                Price = Convert.ToDecimal(prDataRow["PurchasePrice"]),
               Finnance = Convert.ToString(prDataRow["Finnance"]),
                Warranty = Convert.ToString(prDataRow["Warranty"]),
               Mileage = Convert.ToString(prDataRow["Mileage"]),
                Rego = Convert.ToInt16(prDataRow["Rego"]),
                DateLastModified = Convert.ToDateTime(prDataRow["DateLastModified"]),
               Status = Convert.ToString(prDataRow["Status"]),
                Name = Convert.ToString(prDataRow["Name"])

            };

        }

        private clsAllOrders dataRow2AllOrders(DataRow prDataRow)
        {
            return new clsAllOrders()
            {
                Name = Convert.ToString(prDataRow["Name"]),
                Email = Convert.ToString(prDataRow["Email"]),
                DatePurchased = Convert.ToDateTime(prDataRow["Date"]),
                CarID = Convert.ToInt16(prDataRow["CarID"])

            };

        }

        public string PutVehicle(clsAllVehicles prVehicle)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                   "UPDATE cars" +  "SET Model = @Model , Year = @Year, Type= @Type , PurchasePrice = @PurchasePrice, Finnance = @Finnance , Warranty = @Warranty , Mileage = @Mileage , Rego = @Rego , DateLastModified = @DateLastModified , Status = @Status , Name = @Name" +
                    "WHERE Name = @Name",
                   prepareVehicleParameters(prVehicle));
                if (lcRecCount == 1)
                    return "One vehicle updated";
                else
                    return "Unexpected vehicle insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PostVehicle(clsAllVehicles prVehicle)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                   // "INSERT Artist SET Name = @Name, Speciality = @Speciality, Phone = @Phone",
                   "INSERT INTO cars (Model, Year, Type, PurchasePrice, Finnance, Warranty, Mileage, Rego, DateLastModified, Status, Name)" +
                   "VALUES  (@Model, @Year, @Type, @PurchasePrice, @Finnance, @Warranty, @Mileage, @Rego, @DateLastModified, @Status, @Name)",
                    prepareVehicleParameters(prVehicle));
                if (lcRecCount == 1) 
                    return "One Vehicles inserted";
                else
                    return "Unexpected vehicle insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

       public string DeleteVehicleDetails(string Name)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "DELETE FROM cars WHERE CarID = @CarID",
                    prepareVehicleParameters(Name));
                if (lcRecCount == 1)
                    return "One vehicle deleted";
                else
                    return "Unexpected vehicle delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        private Dictionary<string, object> prepareVehicleParameters(clsAllVehicles prVehicle)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(3);
            par.Add("CarID", prVehicle.CarID);
            par.Add("Model", prVehicle.Model);
            par.Add("Year", prVehicle.Year);
            par.Add("Type", prVehicle.Type);
            par.Add("PurchasePrice", prVehicle.Price);
            par.Add("Finnance", prVehicle.Finnance);
            par.Add("Warranty", prVehicle.Warranty);
            par.Add("Mileage", prVehicle.Mileage);
            par.Add("Rego", prVehicle.Rego);
            par.Add("DateLastModified", prVehicle.DateLastModified.ToString("yyy-MM-dd H:mm:ss"));
            par.Add("Status", prVehicle.Status);
            par.Add("Name", prVehicle.Name);
           


            return par;
        }

        private Dictionary<string, object> prepareVehicleParameters(string prName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(2);
            par.Add("Name", prName);
            return par;
        }

    }
}
