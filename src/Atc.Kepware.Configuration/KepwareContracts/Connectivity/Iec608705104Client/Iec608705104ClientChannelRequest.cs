namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec608705104Client;

/// <summary>
/// Channel request properties for the IEC 60870-5-104 Client driver.
/// </summary>
internal sealed class Iec608705104ClientChannelRequest : ChannelRequestBase, IIec608705104ClientChannelRequest
{
    public Iec608705104ClientChannelRequest()
        : base(DriverType.Iec608705104Client)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_DESTINATION_HOST")]
    public string DestinationHost { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_DESTINATION_PORT")]
    public int DestinationPort { get; set; } = 2404;

    /// <inheritdoc />
    [Range(1, 255)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_CONNECT_TIMEOUT")]
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_COT_SIZE")]
    public Iec608705104CotSizeType CotSize { get; set; } = Iec608705104CotSizeType.TwoOctets;

    /// <inheritdoc />
    [Range(0, 254)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_ORIGINATOR_ADDRESS")]
    public int OriginatorAddress { get; set; }

    /// <inheritdoc />
    [Range(1, 255)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T1_SEC")]
    public int T1 { get; set; } = 15;

    /// <inheritdoc />
    [Range(1, 255)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T2_SEC")]
    public int T2 { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 172800)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_T3_SEC")]
    public int T3 { get; set; } = 20;

    /// <inheritdoc />
    [Range(1, 12)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_K")]
    public int K { get; set; } = 12;

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_W")]
    public int W { get; set; } = 8;

    /// <inheritdoc />
    [Range(2, 253)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_RX_BUFFER_SIZE")]
    public int RxBufferSize { get; set; } = 253;

    /// <inheritdoc />
    [Range(10, int.MaxValue)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_INCREMENTAL_TIMEOUT")]
    public int IncrementalTimeout { get; set; } = 30000;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_60870_5_104_master.CHANNEL_FIRST_CHAR_WAIT")]
    public int FirstCharWait { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}
