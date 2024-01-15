namespace AuthAndLogs.Models
{
    public class LogsModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateCreate { get; set; }
        public string Ip { get; set; }
        public string route { get; set; }
    }
}
