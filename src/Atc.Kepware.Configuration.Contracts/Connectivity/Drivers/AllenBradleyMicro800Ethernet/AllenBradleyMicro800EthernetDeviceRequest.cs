namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyMicro800Ethernet;

/// <summary>
/// Device request properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
public sealed class AllenBradleyMicro800EthernetDeviceRequest : DeviceRequestBase, IAllenBradleyMicro800EthernetDeviceRequest
{
    public AllenBradleyMicro800EthernetDeviceRequest()
        : base(DriverType.AllenBradleyMicro800Ethernet)
    {
    }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int Port { get; set; } = 44818;

    /// <inheritdoc />
    public Micro800InactivityWatchdogType InactivityWatchdog { get; set; } = Micro800InactivityWatchdogType.Seconds32;

    /// <inheritdoc />
    public Micro800DefaultDataType DefaultDataType { get; set; } = Micro800DefaultDataType.Float;

    /// <inheritdoc />
    public int ArrayBlockSize { get; set; } = 120;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(InactivityWatchdog)}: {InactivityWatchdog}, {nameof(DefaultDataType)}: {DefaultDataType}, {nameof(ArrayBlockSize)}: {ArrayBlockSize}";
}