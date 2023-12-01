using ChartLibrary.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary.Repository
{
    public interface IChartRepository
    {
        IEnumerable<ChartData> GetAll();

    }
}
