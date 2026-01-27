namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec61850MmsClient;

/// <summary>
/// Channel properties for the IEC 61850 MMS Client driver.
/// </summary>
internal sealed class Iec61850MmsClientChannel : ChannelBase, IIec61850MmsClientChannel
{
    [JsonPropertyName("iec_61850_mms_client.CHANNEL_OPTIMIZE_MEMORY_ALLOCATION")]
    public bool OptimizeMemoryAllocation { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(OptimizeMemoryAllocation)}: {OptimizeMemoryAllocation}";
}
