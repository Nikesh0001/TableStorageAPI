using ChartLibrary.DTOModel;
using ChartLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public ActionResult<IEnumerable<ChartData>> GetData()
            {
            var Data = chartRepository.GetAll();
            return Ok(Data);
        }
    }
}
