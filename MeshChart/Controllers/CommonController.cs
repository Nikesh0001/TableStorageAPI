using ChartLibrary.DTOModel;
using ChartLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography.Xml;

namespace MeshChart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {

        IChartRepository chartRepository;
        public CommonController(IChartRepository chartRepository)
        {
            this.chartRepository = chartRepository;
        }


        //Getting Data based 
        [HttpGet]
        public ActionResult<IEnumerable<ChartData>> GetData()
        {
            var Data = chartRepository.GetAll();
            return Ok(Data);
        }



    }
}
