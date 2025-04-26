namespace BlazorApp.Components.Models
{
    public class Admitere
    {
        public int Index { get; set; }
        public string County { get; set; }
        public string OriginId { get; set; }
        public string Origin { get; set; }
        public string School { get; set; }
        public string SchoolCode { get; set; }
        public bool IgnoreNative { get; set; }

        public double Adm { get; set; }
        public double En { get; set; }
        public double Abs { get; set; }
        public double Rom { get; set; }
        public double Mat { get; set; }
        public string? Lmp { get; set; } // Optional field (nullable)
        public string Lm { get; set; }

        public string HighSchoolName { get; set; }
        public string HighSchoolId { get; set; }
        public string HighSchoolProfile { get; set; }
        public string HighSchoolLevel { get; set; }
        public string HighSchoolType { get; set; }

        public string SpecializationName { get; set; }
        public string SpecializationId { get; set; }
        public string SpecializationLanguage { get; set; }
        public string SpecializationCode { get; set; }
    }
}
