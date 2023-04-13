using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyzer
{
    public class StateCensus
    {
        public int ReadData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
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
    }
}
