using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;




namespace ClientSide
{
 static class ServiceClient
    
    {

        internal async static Task<List<string>> GetCarBrandsAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/Car/GetCarBrandsName/")); }




        internal async static Task<clsVehicleBrands> GetCarAsync(string prVehicleName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsVehicleBrands>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/car/GetCar?Name=" + prVehicleName));
        }

      

        //private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        //{
        //    using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
        //    using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
        //    using (HttpClient lcHttpClient = new HttpClient())
        //    {
        //        HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
        //        return await lcRespMessage.Content.ReadAsStringAsync();
        //    }
        //}

        //internal async static Task<string> InsertVehicleAsync(clsAllVehicles prVehicle)
        //{
        //    return await InsertOrUpdateAsync(prVehicle, "http://localhost:60064/api/car/PostVehicle", "POST");
        //}

        //internal async static Task<string> UpdateVehicleAsync(clsAllVehicles prVehicle)
        //{
        //    return await InsertOrUpdateAsync(prVehicle, "http://localhost:60064/api/car/PutVehicle", "PUT");
        //}

        //internal async static Task<string> DeleteVehicleAsync(clsAllVehicles prVehicle)
        //{
        //    using (HttpClient lcHttpClient = new HttpClient())
        //    {
        //        HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
        //            ($"http://localhost:60064/api/car/DeleteVehicleDetails?Name={prVehicle.Name}");
        //        return await lcRespMessage.Content.ReadAsStringAsync();
        //    }

        //}
    }


}
