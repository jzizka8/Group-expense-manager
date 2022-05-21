using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvReading
{
    public interface ICsvReader
    {
        Task<List<List<string>>> ReadAsync(string path);
    }
}
