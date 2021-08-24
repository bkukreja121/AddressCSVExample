using System;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace CsvWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvPath = Path.Combine(Environment.CurrentDirectory, @"C:\Users\bkukrej\source\repos\AddressCSV\AddressCSV\Uitility\Address.csv");
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    var rockets = AddressInfo.GetAddress();
                    csvWriter.Context.RegisterClassMap<AddressInfoClassMap>();
                    csvWriter.WriteRecords(rockets);
                }
            }
        }
    }
}
