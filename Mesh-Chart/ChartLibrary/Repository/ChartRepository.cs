using ChartLibrary.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary.Repository
{
    public class ChartRepository : IChartRepository
    {
        List<ChartData> chartdata;
        public ChartRepository()
        {
            this.chartdata = new List<ChartData>()
            {
                new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 101,
                    FeatureName = "Tata",
                    FeatureId = 201,
                    Value = "200",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = true,
                    FeatureDataType = "int"

                },
                new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 102,
                    FeatureName = "Tesla",
                    FeatureId = 202,
                    Value = "4520",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = false,
                    FeatureDataType = "String"

                },
                    new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 103,
                    FeatureName = "Apple",
                    FeatureId = 203,
                    Value = "2020",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = true,
                    FeatureDataType = "String"

                },
                    new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 104,
                    FeatureName = "Amazon",
                    FeatureId = 204,
                    Value = "7545",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = false,
                    FeatureDataType = "String"

                },
                    new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 105,
                    FeatureName = "BlueOrgin",
                    FeatureId = 205,
                    Value = "6542",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = true,
                    FeatureDataType = "int"

                },
                      new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 106,
                    FeatureName = "Fidelity",
                    FeatureId = 206,
                    Value = "6522",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = true,
                    FeatureDataType = "int"

                },
                       new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 106,
                    FeatureName = "Fidelity",
                    FeatureId = 206,
                    Value = "6522",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = false,
                    FeatureDataType = "int"

                }, new ChartData()
                {

                    EntityName = "Stock",
                    EntityId = 106,
                    FeatureName = "HCL",
                    FeatureId = 206,
                    Value = "6522",
                    CreatedAt = DateTime.Now,
                    ApprovalStatus = true,
                    FeatureDataType = "int"

                }
            };
        }
        public IEnumerable<ChartData> GetAll()
        {
            return chartdata.ToList();
        }
    }
}
