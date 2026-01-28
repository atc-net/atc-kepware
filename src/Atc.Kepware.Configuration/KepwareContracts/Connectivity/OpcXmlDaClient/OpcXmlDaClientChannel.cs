namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcXmlDaClient;

/// <summary>
/// Channel properties for the OPC XML-DA Client driver.
/// </summary>
internal sealed class OpcXmlDaClientChannel : ChannelBase, IOpcXmlDaClientChannel
{
    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_SERVER_URL")]
    public string ServerUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_HTTP_TIMEOUT_SEC")]
    public int HttpTimeout { get; set; } = 30;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_SUBSCRIPTION_UPDATE_RATE_MS")]
    public int SubscriptionUpdateRate { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_READ_TIMEOUT_MS")]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_WRITE_TIMEOUT_MS")]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_LOCALE_ID")]
    public string? LocaleId { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_USE_HTTP_AUTHENTICATION")]
    public bool UseHttpAuthentication { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_HTTP_AUTHENTICATION_USER_NAME")]
    public string? HttpAuthenticationUserName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.CHANNEL_HTTP_AUTHENTICATION_PASSWORD")]
    public string? HttpAuthenticationPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ServerUrl)}: {ServerUrl}, {nameof(HttpTimeout)}: {HttpTimeout}";
}
