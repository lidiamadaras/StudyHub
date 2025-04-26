using CsvHelper.Configuration;

namespace BlazorApp.Components.Models.CSVHelpers
{
    public sealed class CSVEvNatHelper : ClassMap<EvNat>
    {
        public CSVEvNatHelper()
        {
            Map(m => m.Name).Name("name");
            Map(m => m.SchoolCode).Name("schoolCode");
            Map(m => m.SchoolName).Name("schoolName");
            Map(m => m.ShortSchoolName).Name("shortSchoolName");
            Map(m => m.SchoolType).Name("schoolType");
            Map(m => m.Medium).Name("medium");
            Map(m => m.Location).Name("location");
            Map(m => m.CountyCode).Name("countyCode");
            Map(m => m.County).Name("county");
            Map(m => m.Nationality).Name("nationality");
            Map(m => m.Romanian).Name("romanian");
            Map(m => m.Mathematics).Name("mathematics");
            Map(m => m.Native).Name("native");
            Map(m => m.Avg).Name("avg");
        }
    }
}
