namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

public sealed class MtConnectClientDevice : DeviceBase, IMtConnectClientDevice
{
    public string DeviceId { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
