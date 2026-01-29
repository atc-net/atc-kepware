namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyEthernet;

/// <summary>
/// Represents a slot configuration for Allen-Bradley Ethernet SLC devices.
/// </summary>
public class AllenBradleyEthernetSlotConfiguration
{
    /// <summary>
    /// Gets or sets the module type for this slot.
    /// </summary>
    public AllenBradleyEthernetSlotModuleType Module { get; set; } = AllenBradleyEthernetSlotModuleType.NoModule;

    /// <summary>
    /// Gets or sets the number of input words for generic modules.
    /// </summary>
    /// <remarks>
    /// Only applicable when Module is set to GenericModule.
    /// Valid range: 0-255.
    /// </remarks>
    public int InputWords { get; set; }

    /// <summary>
    /// Gets or sets the number of output words for generic modules.
    /// </summary>
    /// <remarks>
    /// Only applicable when Module is set to GenericModule.
    /// Valid range: 0-255.
    /// </remarks>
    public int OutputWords { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Module)}: {Module}, {nameof(InputWords)}: {InputWords}, {nameof(OutputWords)}: {OutputWords}";
}