using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CsvIO
{
    public interface ICsvReader
    {
        public static readonly string DEFAULT_DELIMITER = ",";
        Task<List<List<string>>> ReadAsync(string path);
    }
}
