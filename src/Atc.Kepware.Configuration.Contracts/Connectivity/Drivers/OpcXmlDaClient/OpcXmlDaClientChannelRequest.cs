namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client channel creation request.
/// </summary>
public class OpcXmlDaClientChannelRequest : ChannelRequestBase, IOpcXmlDaClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpcXmlDaClientChannelRequest"/> class.
    /// </summary>
    public OpcXmlDaClientChannelRequest()
        : base(DriverType.OpcXmlDaClient)
    {
    }

    /// <inheritdoc />
    [Required]
    public string ServerUrl { get; set; } = "http://localhost:80/Kepware/xmldaservice.asp";

    /// <inheritdoc />
    [Range(0, 3600)]
    public int KeepAlive { get; set; }

    /// <inheritdoc />
    public string? TrustedCertificatesPath { get; set; }

    /// <inheritdoc />
    public OpcXmlDaClientItemPathDelimiter ItemPathDelimiter { get; set; }

    /// <inheritdoc />
    public string? ProxyServerAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
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