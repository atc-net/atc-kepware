namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcXmlDaClient;

/// <summary>
/// Channel request properties for the OPC XML-DA Client driver.
/// </summary>
internal sealed class OpcXmlDaClientChannelRequest : ChannelRequestBase, IOpcXmlDaClientChannelRequest
{
    public OpcXmlDaClientChannelRequest()
        : base(DriverType.OpcXmlDaClient)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("opcxmldaclient.CHANNEL_SERVER_URL")]
    public string ServerUrl { get; set; } = "http://localhost:80/Kepware/xmldaservice.asp";

    /// <inheritdoc />
    [Range(0, 3600)]
    [JsonPropertyName("opcxmldaclient.CHANNEL_KEEP_ALIVE_SEC")]
    public int KeepAlive { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_TRUSTED_CERTS_PATH")]
    public string? TrustedCertificatesPath { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_ITEM_PATH_DELIMITER")]
    public OpcXmlDaClientItemPathDelimiter ItemPathDelimiter { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_PROXY_SERVER_ADDRESS")]
    public string? ProxyServerAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("opcxmldaclient.CHANNEL_PROXY_PORT")]
    public int ProxyPort { get; set; } = 8080;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_PROXY_USERNAME")]
    public string? ProxyUsername { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_PROXY_PASSWORD")]
    public string? ProxyPassword { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_HTTP_AUTH_USERNAME")]
    public string? HttpAuthUsername { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_HTTP_AUTH_PASSWORD")]
    public string? HttpAuthPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ServerUrl)}: {ServerUrl}, {nameof(KeepAlive)}: {KeepAlive}";
}
