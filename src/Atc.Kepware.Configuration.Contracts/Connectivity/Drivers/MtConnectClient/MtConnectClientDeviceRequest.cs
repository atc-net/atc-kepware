namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
public sealed class MtConnectClientDeviceRequest : DeviceRequestBase, IMtConnectClientDeviceRequest
{
    public MtConnectClientDeviceRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    [MaxLength(256)]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
