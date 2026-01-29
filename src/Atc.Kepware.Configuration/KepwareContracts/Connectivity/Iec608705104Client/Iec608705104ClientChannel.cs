namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec608705104Client;

/// <summary>
/// Channel properties for the IEC 60870-5-104 Client driver.
/// </summary>
internal sealed class Iec608705104ClientChannel : ChannelBase, IIec608705104ClientChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_DESTINATION_HOST")]
    public string DestinationHost { get; set; } = string.Empty;

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_DESTINATION_PORT")]
    public int DestinationPort { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_CONNECT_TIMEOUT")]
    public int ConnectTimeout { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_COT_SIZE")]
    public Iec608705104CotSizeType CotSize { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_ORIGINATOR_ADDRESS")]
    public int OriginatorAddress { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T1_SEC")]
    public int T1 { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T2_SEC")]
    public int T2 { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T3_SEC")]
    public int T3 { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_K")]
    public int K { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_W")]
    public int W { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_RX_BUFFER_SIZE")]
    public int RxBufferSize { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_INCREMENTAL_TIMEOUT")]
    public int IncrementalTimeout { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_FIRST_CHAR_WAIT")]
    public int FirstCharWait { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}