using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvReading
{
    public interface CsvWriter
    {
        Task WriteAsync(string path, List<List<string>> content);
    }
}
