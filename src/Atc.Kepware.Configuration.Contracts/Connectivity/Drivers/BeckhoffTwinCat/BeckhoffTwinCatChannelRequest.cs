namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BeckhoffTwinCat;

/// <summary>
/// Channel request properties for the Beckhoff TwinCAT driver.
/// </summary>
public sealed class BeckhoffTwinCatChannelRequest : ChannelRequestBase, IBeckhoffTwinCatChannelRequest
{
    public BeckhoffTwinCatChannelRequest()
        : base(DriverType.BeckhoffTwinCat)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
