using ChartMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
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


      
    //DashBoard
    public IActionResult DashBoard()
        {
            return View();
        }

        //To Retrive data from Api
        public async Task<List<DTOChart>> GetChartData()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<DTOChart>>();
                }
                return new List<DTOChart>();
            }
        }

        //For BarChart on Approval status
        public IActionResult BarChart()
        {
            List<DTOChart> chartData = GetChartData().Result;

            string serializedData = Newtonsoft.Json.JsonConvert.SerializeObject(chartData);

            ViewBag.ChartData = serializedData;

            return View(chartData);
        }


        // For PieChart Based on EntityName
        public IActionResult PieChart()
        {
            List<DTOChart> PieChartData = GetChartData().Result;

            string serializedData = Newtonsoft.Json.JsonConvert.SerializeObject(PieChartData);

            ViewBag.ChartData = serializedData;

            return View(PieChartData);
        }



    }
}


