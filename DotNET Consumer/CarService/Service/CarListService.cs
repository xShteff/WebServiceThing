using System;
using System.Net;
using CarService.Model;
using Newtonsoft.Json;

namespace CarService.Service
{
    public class CarListService : ICarListService
    {
        private T GetSerialisedJsonData<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        public CarList getCars()
        {
            return GetSerialisedJsonData<CarList>("http://localhost:8080/getCars");
        }

       public Car getCar(int id)
        {
            return GetSerialisedJsonData<Car>($"http://localhost:8080/getCar?id={id}");
        }
    }
}
