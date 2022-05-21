using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvReading
{
    public class CsvReaderWriter : ICsvReader, ICsvWriter
    {
        private static readonly string DEFAULT_DELIMITER = ",";
        public string  Delimiter { get; set; }
        public CsvReaderWriter() :this(DEFAULT_DELIMITER)
        {
        }

        public CsvReaderWriter(string delimiter)
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

        public async Task WriteAsync(string path, List<List<string>> content)
        {
            using StreamWriter writer = new(path);

            foreach (var line in content)
            {
                await writer.WriteLineAsync(string.Join(Delimiter, line));
            }
        }
    }
}
