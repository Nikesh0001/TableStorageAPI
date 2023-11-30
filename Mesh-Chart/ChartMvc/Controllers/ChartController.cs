using ChartMvc.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace ChartMvc.Controllers
{
    public class ChartController : Controller
    {
        private readonly string apiUrl;

        public ChartController(string apiEndpoint)
        {
            apiUrl = apiEndpoint;
        }

        public async Task<List<DTOChart>> GetChartData()
        {
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<DTOChart>>();
                }
                return new List<DTOChart>();
            }
        }


        public IActionResult Index()
        {
            List<DTOChart> chartData = GetChartData().Result; // Assuming GetChartData is an async method

            // Serialize the data to JSON
            string serializedData = Newtonsoft.Json.JsonConvert.SerializeObject(chartData);

            // Pass the serialized data to the view
            ViewBag.ChartData = serializedData;

            return View(chartData);
        }
       
    }
}
