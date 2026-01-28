namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

public interface IMtConnectClientDevice : IDeviceBase
{
    string DeviceId { get; set; }
}
