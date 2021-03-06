namespace Project.CsvIO
{
    public interface ICsvWriter
    {
        public static readonly string DEFAULT_DELIMITER = ",";
        Task WriteAsync(string path, IEnumerable<IEnumerable<string>> content);
    }
}
