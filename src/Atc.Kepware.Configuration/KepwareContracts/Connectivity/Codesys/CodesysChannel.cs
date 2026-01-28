namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Codesys;

/// <summary>
/// Channel properties for the CODESYS driver.
/// </summary>
internal class CodesysChannel : ChannelBase, ICodesysChannel
{
    [JsonPropertyName("CODESYS.CHANNEL_KEEP_ALIVE_TIMEOUT_MINUTES")]
    public int KeepAliveMinutes { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(KeepAliveMinutes)}: {KeepAliveMinutes}";
}
