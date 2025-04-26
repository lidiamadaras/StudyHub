using BlazorApp.Components.Models;
using BlazorApp.Components.Models.CSVHelpers;
using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace BlazorApp.Components.Repository
{
    public class BacRepository
    {
        private readonly string _csvFilePath;

        public BacRepository(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<Bac> GetAllBac()
        {
            using var reader = new StreamReader(_csvFilePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<CSVBacHelper>();
            var records = csv.GetRecords<Bac>().ToList();

            return records;
        }
    }
}
