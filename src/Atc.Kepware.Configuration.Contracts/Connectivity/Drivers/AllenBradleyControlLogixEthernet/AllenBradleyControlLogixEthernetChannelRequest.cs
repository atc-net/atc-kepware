namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixEthernet;

/// <summary>
/// Channel request properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixEthernetChannelRequest : ChannelRequestBase, IAllenBradleyControlLogixEthernetChannelRequest
{
    public AllenBradleyControlLogixEthernetChannelRequest()
        : base(DriverType.AllenBradleyControlLogixEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
