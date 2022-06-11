using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvIO
{
    public class CsvReader : ICsvReader
    {
        public string  Delimiter { get; set; }
        public CsvReader() :this(ICsvReader.DEFAULT_DELIMITER)
        {
        }

        public CsvReader(string delimiter)
        {
            Delimiter = delimiter;
        }
        public async Task<List<List<string>>> ReadAsync(string path)
        {
            List<List<string>> result = new();
            List<string> line;
            
            using StreamReader reader = new(path);
            
            while (!reader.EndOfStream)
            {
                
                line = new();
                string rawLine = await reader.ReadLineAsync();
                line.AddRange(rawLine.Split(Delimiter));
                result.Add(line);
            }

            return result;
        }
    }
}
