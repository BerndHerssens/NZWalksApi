namespace NZWalksApi.Business.Services;

public interface ILogger
{
    void LogException(Exception ex);
    void LogMessage(string message);
}