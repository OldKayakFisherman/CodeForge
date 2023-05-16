namespace CommonLib.Logging;

public interface ITrafficLog
{
    int Id { get; set; }

    int? LocalPort { get; set; }

    int? RemotePort { get; set; }

    string? LocalIP { get; set; }

    string? RemoteIP { get; set; }

    string? RequestCookies { get; set; }

    string? RequestHeaders { get; set; }

    string? Host { get; set; }

    string? RequestMethod { get; set; }

    string? RequestPath { get; set; }

    string? RequestProtocol { get; set; }

    string? RequestQuery { get; set; }

    string? RequestScheme { get; set; }

    long? RequestLength { get; set; }

    string? RequestContentType { get; set; }

    string? RequestQueryString { get; set; }

    public DateTime TrafficDate { get; set; }
}