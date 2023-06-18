using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;

namespace Gal.Data.Fakes.Database
{
    internal class FakeDatabase
    {
        static readonly string gwpFileName = Path.Join(new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName, "Database", "gwpByCountry.csv");
        
        public FakeDatabase() 
        {
            Gwps = GetGwp();
        }

        public List<Gwp> Gwps { get; set; }

        private static List<Gwp> GetGwp()
        {
            if (!File.Exists(gwpFileName))
            {
                throw new InvalidOperationException($"{gwpFileName} is required for {nameof(FakeDatabase)}");
            }

            var result = new List<Gwp>();

            bool firstLine = true;
            foreach (var line in File.ReadLines(gwpFileName))
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }

                var lineParts = line.Split(",");
                const int startIndex = 4;
                for (int i = startIndex; i < lineParts.Length; i++)
                {
                    var item = new Gwp
                    {
                        Country = lineParts[0],
                        Lob = lineParts[3],
                        Year = 2000 + i - startIndex,
                        GwpValue = string.IsNullOrWhiteSpace(lineParts[i]) ? 0 : double.Parse(lineParts[i])
                    };
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
