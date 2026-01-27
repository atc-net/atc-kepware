namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyServerEthernet;

/// <summary>
/// Allen-Bradley Server Ethernet device request - Kepware format.
/// </summary>
internal sealed class AllenBradleyServerEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyServerEthernetDeviceRequest
{
    public AllenBradleyServerEthernetDeviceRequest()
        : base(DriverType.AllenBradleyServerEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the TCP/IP port number.
    /// </summary>
    [JsonPropertyName("ab_unsolicited_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 2222;

    /// <summary>
    /// Gets or sets a value indicating whether the first word is low for 32-bit data types.
    /// </summary>
    [JsonPropertyName("ab_unsolicited_ethernet.DEVICE_FIRST_WORD_LOW")]
    public bool FirstWordLow { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}, {nameof(FirstWordLow)}: {FirstWordLow}";
}
