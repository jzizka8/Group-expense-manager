using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvReading
{
    public interface ICsvWriter
    {
        Task WriteAsync(string path, IEnumerable<IEnumerable<string>> content);
    }
}
