namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Codesys;

/// <summary>
/// Channel request properties for the CODESYS driver.
/// </summary>
internal class CodesysChannelRequest : ChannelRequestBase, ICodesysChannelRequest
{
    public CodesysChannelRequest()
        : base(DriverType.Codesys)
    {
    }

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("CODESYS.CHANNEL_KEEP_ALIVE_TIMEOUT_MINUTES")]
    public int KeepAliveMinutes { get; set; } = 1;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(KeepAliveMinutes)}: {KeepAliveMinutes}";
}