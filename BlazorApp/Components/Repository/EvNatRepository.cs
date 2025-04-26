using BlazorApp.Components.Models;
using BlazorApp.Components.Models.CSVHelpers;
using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace BlazorApp.Components.Repository
{
    public class EvNatRepository
    {
        private readonly string _csvFilePath;

        public EvNatRepository(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<EvNat> GetAllEvNat()
        {
            using var reader = new StreamReader(_csvFilePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<CSVEvNatHelper>();
            var records = csv.GetRecords<EvNat>().ToList();

            return records;
        }
    }
}
