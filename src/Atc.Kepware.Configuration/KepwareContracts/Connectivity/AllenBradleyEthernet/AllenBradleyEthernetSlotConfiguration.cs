namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Internal model for Allen-Bradley Ethernet slot configuration from Kepware API.
/// </summary>
internal sealed class AllenBradleyEthernetSlotConfiguration
{
    /// <summary>
    /// Gets or sets the module type.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_SLOT_CONFIGURATION_MODULE")]
    public AllenBradleyEthernetSlotModuleType Module { get; set; } = AllenBradleyEthernetSlotModuleType.NoModule;

    /// <summary>
    /// Gets or sets the number of input words.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_SLOT_CONFIGURATION_INPUT_WORDS")]
    public int InputWords { get; set; }

    /// <summary>
    /// Gets or sets the number of output words.
    /// </summary>
    [JsonPropertyName("allenbradley_ethernet.DEVICE_SLOT_CONFIGURATION_OUTPUT_WORDS")]
    public int OutputWords { get; set; }
}
