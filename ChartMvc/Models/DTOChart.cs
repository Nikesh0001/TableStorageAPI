﻿namespace ChartMvc.Models
{
    public class DTOChart
    {
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string Value { get; set; }
        public string FeatureDataType { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ApprovalStatus { get; set; }

    }
}
