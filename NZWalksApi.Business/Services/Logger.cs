namespace NZWalksApi.Business.Services
{
    public class Logger : ILogger
    {
        private readonly string logFilePath;
        private readonly int retentionDays;

        public Logger(string folder = "Logging", int retentionDays = 30)
        {
            string logFileName = $"log_{DateTime.Now:yyyyMMdd}.log";
            string rootPath = AppDomain.CurrentDomain.BaseDirectory;

            var logDirectory = Path.Combine(rootPath, folder);
            logFilePath = Path.Combine(logDirectory, logFileName);
            this.retentionDays = retentionDays;

            if (!Directory.Exists(logDirectory))
            {
                if (CanCreateDirectory(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }
            }

            CleanUpOldLogs(logDirectory);
        }

        public void LogException(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"ERROR: {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {ex.GetType()}: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine();
            }
        }

        public void LogMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"MESSAGE: {DateTime.Now:yyyy-MM-dd HH:mm:ss}:  {message}");
            }
        }

        private void CleanUpOldLogs(string logDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(logDirectory);
            foreach (FileInfo file in directoryInfo.GetFiles("log_*.log"))
            {
                if (file.CreationTime < DateTime.Now.AddDays(-retentionDays))
                {
                    file.Delete();
                }
            }
        }

        private bool CanCreateDirectory(string directoryPath)
        {
            try
            {
                // Attempt to create a temporary directory
                string tempDirectoryPath = Path.Combine(directoryPath, $"tempDir_{Guid.NewGuid()}");
                Directory.CreateDirectory(tempDirectoryPath);

                // If successful, delete the directory immediately
                Directory.Delete(tempDirectoryPath);

                return true; // User has permissions
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}