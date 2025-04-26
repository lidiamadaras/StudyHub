using BlazorApp.Components.Models;
using BlazorApp.Components.Models.CSVHelpers;
using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace BlazorApp.Components.Repository
{
    public class AdmitereRepository
    {
        private readonly string _csvFilePath;

        public AdmitereRepository(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<Admitere> GetAllAdmitere()
        {
            using var reader = new StreamReader(_csvFilePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<CSVAdmitereHelper>();
            var records = csv.GetRecords<Admitere>().ToList();

            return records;
        }
    }
}
