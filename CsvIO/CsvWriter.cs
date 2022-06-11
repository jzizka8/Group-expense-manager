using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvIO
{
    public class CsvWriter:ICsvWriter
    {
        public string Delimiter { get; set; }
        public CsvWriter() : this(ICsvWriter.DEFAULT_DELIMITER)
        {
        }

        public CsvWriter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public async Task WriteAsync(string path, IEnumerable<IEnumerable<string>> content)
        {
            using StreamWriter writer = new(path);

            foreach (var line in content)
            {
                await writer.WriteLineAsync(string.Join(Delimiter, line));
            }
        }
    }
}
