using System.Collections.Generic;

namespace GeoJSONPlugin
{
    internal class ColumnInfo
    {
        public string Name { get; set; }
        public Dictionary<string, double> FieldUnitsDict { get; set; }

        public ColumnInfo(string Name, Dictionary<string, double> FieldUnitsDict)
        {
            this.Name = Name;
            this.FieldUnitsDict = FieldUnitsDict;
        }

        public static List<ColumnInfo> columnInfos;
        public static void Initialize()
        {
            columnInfos = new List<ColumnInfo>
            {
                new ColumnInfo("vrDistanceTraveled", new Dictionary<string, double> { { "Distance_Traveled_ft", 1/30.48 }, { "Distance_Traveled_cm", 1 } }),
                new ColumnInfo("vrHeading", new Dictionary<string, double> { { "Heading_deg", 1 } }),
                new ColumnInfo("vrSeedRateSeedsTarget", new Dictionary<string, double> { { "TargetRateAcRow<RowNum>_k", 0.40468564224/1000 }, { "TargetRateHaRow<RowNum>", 1 } }),
                new ColumnInfo("vrSeedRateSeedsActual", new Dictionary<string, double> { { "ActualRateAcRow<RowNum>_k", 0.40468564224/1000 }, { "ActualRateHaRow<RowNum>", 1 } })
            };
        }
    }
}
