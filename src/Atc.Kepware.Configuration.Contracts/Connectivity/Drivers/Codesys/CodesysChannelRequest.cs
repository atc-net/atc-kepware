namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Codesys;

/// <summary>
/// Channel properties for the CODESYS driver.
/// </summary>
public sealed class CodesysChannelRequest : ChannelRequestBase, ICodesysChannelRequest
{
    public CodesysChannelRequest()
        : base(DriverType.Codesys)
    {
    }

    /// <inheritdoc />
    [Range(1, 10)]
    public int KeepAliveMinutes { get; set; } = 1;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(KeepAliveMinutes)}: {KeepAliveMinutes}";
}
