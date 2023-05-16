namespace CommonLib.Logging;

public interface IAuditLog
{
    string Browser { get; set; }
    string Host { get; set; }
    string Referrer { get; set; }
    string RemoteAddress { get; set; }
    string Path { get; set; }
    string QueryString { get; set; }
    string Message { get; set; }
    string Severity { get; set; }
    string Type { get; set; }
    string UserAccount { get; set; }
    DateTime EventDate { get; set; }
    string BrowserVersion { get; set; }
    string UserAgent { get; set; }
    bool Success { get; set; }
    string App { get; set; }
    string Source { get; set; }
    string Stacktrace { get; set; }
    string Exception { get; set; }
    string Detail { get; set; }
    string AppVersion { get; set; }
    string RequestHeaders { get; set; }
    string ResponseHeaders { get; set; }
}