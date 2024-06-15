namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Simulator;

public interface ISimulatorDeviceRequest
{
    /// <summary>
    /// The specific type of device.
    /// </summary>
    SimulatorDeviceModel Model { get; set; }

    /// <summary>
    /// Device identifier within the channel.
    /// </summary>
    /// <remarks>
    /// It is possible to have multiple devices with the same identifier within a channel. The <see cref="Model"/>
    /// for those devices must be the same. Devices within a channel having the same identifier will share the same
    /// address space.
    /// </remarks>
    int Id { get; set; }

    /// <summary>
    /// The format of the device identifier.
    /// </summary>
    /// <remarks>
    /// Does not seem to serve any other purpose than for display in the device properties in the configurator.
    /// </remarks>
    SimulatorDeviceIdFormat IdFormat { get; set; }
}