using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace IndianStatesCensusAnalyzer
{
    public class InformationAnalyze
    {
        public int ReadData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new StateCensusException(StateCensusException.ExceptionType.FILE_INCORRECT, "File is incorrect");
            }
            if (!filePath.EndsWith(".csv"))
            {
                throw new StateCensusException(StateCensusException.ExceptionType.TYPE_INCORRECT, "Type is incorrect");
            }
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
            {
                throw new StateCensusException(StateCensusException.ExceptionType.DELIMETER_INCORRECT, "Delimiter is incorrect");
            }
            using (var reader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<StateCensusDAO>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine(record);
                    }
                    return records.Count() - 1;
                }
            }
        }
        public bool ReadData(string filePath, string actualheader)
        {
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Equals(actualheader))
            {
                return true;
            }
            else
            {
                throw new StateCensusException(StateCensusException.ExceptionType.HEADER_INCORRECT, "Header is incorrect");
            }
        }
    }
}