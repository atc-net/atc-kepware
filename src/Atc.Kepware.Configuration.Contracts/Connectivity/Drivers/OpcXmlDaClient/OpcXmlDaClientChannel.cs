namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client channel.
/// </summary>
public class OpcXmlDaClientChannel : ChannelBase, IOpcXmlDaClientChannel
{
    /// <inheritdoc />
    public string ServerUrl { get; set; } = "http://localhost:80/Kepware/xmldaservice.asp";

    /// <inheritdoc />
    public int KeepAlive { get; set; }

    /// <inheritdoc />
    public string? TrustedCertificatesPath { get; set; }

    /// <inheritdoc />
    public OpcXmlDaClientItemPathDelimiter ItemPathDelimiter { get; set; }

    /// <inheritdoc />
    public string? ProxyServerAddress { get; set; }

    /// <inheritdoc />
    public int ProxyPort { get; set; } = 8080;

    /// <inheritdoc />
    public string? ProxyUsername { get; set; }

    /// <inheritdoc />
    public string? ProxyPassword { get; set; }

    /// <inheritdoc />
    public string? HttpAuthUsername { get; set; }

    /// <inheritdoc />
    public string? HttpAuthPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ServerUrl)}: {ServerUrl}, {nameof(KeepAlive)}: {KeepAlive}";
}