using CsvHelper.Configuration;

namespace BlazorApp.Components.Models.CSVHelpers
{
    public sealed class CSVAdmitereHelper : ClassMap<Admitere>
    {
        public CSVAdmitereHelper()
        {
            Map(m => m.Index).Name("index");
            Map(m => m.County).Name("county");
            Map(m => m.OriginId).Name("originId");
            Map(m => m.Origin).Name("origin");
            Map(m => m.School).Name("school");
            Map(m => m.SchoolCode).Name("schoolCode");
            Map(m => m.IgnoreNative).Name("ignoreNative");
            Map(m => m.Adm).Name("adm");
            Map(m => m.En).Name("en");
            Map(m => m.Abs).Name("abs");
            Map(m => m.Rom).Name("rom");
            Map(m => m.Mat).Name("mat");
            Map(m => m.Lmp).Name("lmp");
            Map(m => m.Lm).Name("lm");
            Map(m => m.HighSchoolName).Name("hsName");
            Map(m => m.HighSchoolId).Name("hsId");
            Map(m => m.HighSchoolProfile).Name("hsProfile");
            Map(m => m.HighSchoolLevel).Name("hsLevel");
            Map(m => m.HighSchoolType).Name("hsType");
            Map(m => m.SpecializationName).Name("specName");
            Map(m => m.SpecializationId).Name("specId");
            Map(m => m.SpecializationLanguage).Name("specLang");
            Map(m => m.SpecializationCode).Name("specCode");
        }
    }
}
