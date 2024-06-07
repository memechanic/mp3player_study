namespace Interfaces
{
    public class FileLogger : ILogger
    {
        const string LogPath = "..\\..\\..\\logs\\";
        public void Log(string message)
        {
            
            string filePath = LogPath + "mylog.txt";
            File.WriteAllText(filePath, message);

            ConsoleLogger cl = new ConsoleLogger();
            cl.Log("log file created");
        }
    }
}
