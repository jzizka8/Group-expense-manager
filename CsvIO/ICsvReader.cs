namespace Project.CsvIO
{
    public interface ICsvReader
    {
        public static readonly string DEFAULT_DELIMITER = ",";
        Task<List<List<string>>> ReadAsync(string path);
    }
}
