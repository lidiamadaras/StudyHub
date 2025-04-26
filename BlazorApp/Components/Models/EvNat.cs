namespace BlazorApp.Components.Models
{
    public class EvNat
    {
        public string Name { get; set; }
        public long SchoolCode { get; set; }
        public string SchoolName { get; set; }
        public string ShortSchoolName { get; set; }
        public string SchoolType { get; set; }
        public string Medium { get; set; }
        public string Location { get; set; }
        public string CountyCode { get; set; }
        public string County { get; set; }
        public string Nationality { get; set; }
        public double Romanian { get; set; }
        public double Mathematics { get; set; }
        public double? Native { get; set; } // Native can be empty, so make it nullable
        public double Avg { get; set; }
    }
}
