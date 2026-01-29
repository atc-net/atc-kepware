namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec61850MmsClient;

/// <summary>
/// Channel properties for the IEC 61850 MMS Client driver.
/// </summary>
public sealed class Iec61850MmsClientChannelRequest : ChannelRequestBase, IIec61850MmsClientChannelRequest
{
    public Iec61850MmsClientChannelRequest()
        : base(DriverType.Iec61850MmsClient)
    {
    }

    /// <inheritdoc />
    public bool OptimizeMemoryAllocation { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(OptimizeMemoryAllocation)}: {OptimizeMemoryAllocation}";
}