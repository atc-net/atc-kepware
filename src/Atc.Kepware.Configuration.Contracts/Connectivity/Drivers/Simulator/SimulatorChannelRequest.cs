namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Simulator;

/// <summary>
/// Channel properties for the Simulator driver.
/// </summary>
public sealed class SimulatorChannelRequest : ChannelRequestBase, ISimulatorChannelRequest
{
    public SimulatorChannelRequest()
        : base(DriverType.Simulator)
    {
    }

    /// <inheritdoc />
    public bool ItemPersistence { get; set; }

    /// <inheritdoc />
    public string? ItemPersistenceDataFile { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ItemPersistence)}: {ItemPersistence}, {nameof(ItemPersistenceDataFile)}: {ItemPersistenceDataFile}";
}