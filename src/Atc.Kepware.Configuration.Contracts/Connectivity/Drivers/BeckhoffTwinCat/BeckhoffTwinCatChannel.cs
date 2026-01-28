namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.BeckhoffTwinCat;

/// <summary>
/// Channel properties for the Beckhoff TwinCAT driver.
/// </summary>
public sealed class BeckhoffTwinCatChannel : ChannelBase, IBeckhoffTwinCatChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
