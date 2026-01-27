namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec61850MmsClient;

internal sealed class Iec61850MmsClientDeviceRequest : DeviceRequestBase, IIec61850MmsClientDeviceRequest
{
    public Iec61850MmsClientDeviceRequest()
        : base(DriverType.Iec61850MmsClient)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_AUTO_CONFIG_SOURCE")]
    public Iec61850MmsClientDeviceAutoConfigSourceType AutoConfigSource { get; set; } = Iec61850MmsClientDeviceAutoConfigSourceType.Device;

    /// <inheritdoc />
    [MaxLength(260)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CONFIGURATION_FILE")]
    public string ConfigurationFile { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SUBNETWORK")]
    public string SubNetwork { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_IED")]
    public string Ied { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_ACCESSPOINT")]
    public string AccessPoint { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_AUTHENTICATION_ENABLED")]
    public bool AuthenticationEnabled { get; set; }

    /// <inheritdoc />
    [MaxLength(80)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_AUTHENTICATION_PASSWORD")]
    public string AuthenticationPassword { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_USE_OPTIONAL_PARAMS")]
    public bool UseOptionalServerParameters { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_AE_INVOKE_ID")]
    public int ServerAeInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_AE_QUALIFIER")]
    public int ServerAeQualifier { get; set; } = 12;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_AP_INVOKE_ID")]
    public int ServerApInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_APP_ID")]
    public string ServerApplicationId { get; set; } = "1,1,1,999,1";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_TRANSPORT_SELECTOR")]
    public string ServerTransportSelector { get; set; } = "00 01";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_SESSION_SELECTOR")]
    public string ServerSessionSelector { get; set; } = "00 01";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_SERVER_PRESENTATION_SELECTOR")]
    public string ServerPresentationSelector { get; set; } = "00 00 00 01";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_USE_OPTIONAL_PARAMS")]
    public bool UseOptionalClientParameters { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_AE_INVOKE_ID")]
    public int ClientAeInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_AE_QUALIFIER")]
    public int ClientAeQualifier { get; set; } = 12;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_AP_INVOKE_ID")]
    public int ClientApInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_APP_ID")]
    public string ClientApplicationId { get; set; } = "1,1,1,999,1";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_TRANSPORT_SELECTOR")]
    public string ClientTransportSelector { get; set; } = "00 01";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_SESSION_SELECTOR")]
    public string ClientSessionSelector { get; set; } = "00 01";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CLIENT_PRESENTATION_SELECTOR")]
    public string ClientPresentationSelector { get; set; } = "00 00 00 01";

    /// <inheritdoc />
    [Range(1, 10000)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_BUFFER_SIZE")]
    public int BufferSize { get; set; } = 100;

    /// <inheritdoc />
    [Range(50, 999999999)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_PLAYBACK_RATE_MS")]
    public int PlaybackRateMs { get; set; } = 2000;

    /// <inheritdoc />
    [Range(0, 999999999)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_INTEGRITY_POLL_RATE_MS")]
    public int IntegrityPollRateMs { get; set; } = 5000;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_POLLING_LEVEL")]
    public Iec61850MmsClientDevicePollingLevelType PollingLevel { get; set; } = Iec61850MmsClientDevicePollingLevelType.LogicalNode;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_ORCAT")]
    public Iec61850MmsClientDeviceOrCatType OrCat { get; set; } = Iec61850MmsClientDeviceOrCatType.BayControl;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_ORIDENT")]
    public string? OrIdent { get; set; }

    /// <inheritdoc />
    [Range(0, 255)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CTLNUM")]
    public int CtlNum { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TEST")]
    public bool Test { get; set; }

    /// <inheritdoc />
    [MinLength(1)]
    [MaxLength(2)]
    [JsonPropertyName("iec_61850_mms_client.DEVICE_CHECK")]
    public string Check { get; set; } = "00";

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_DISPLAY_DESCRIPTIONS")]
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_GENERATE_DATA_SETS")]
    public bool GenerateReportedDataSets { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_ST")]
    public bool TagConstraintSt { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_MX")]
    public bool TagConstraintMx { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_CO")]
    public bool TagConstraintCo { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_SP")]
    public bool TagConstraintSp { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_SV")]
    public bool TagConstraintSv { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_CF")]
    public bool TagConstraintCf { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_DC")]
    public bool TagConstraintDc { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_SG")]
    public bool TagConstraintSg { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_SE")]
    public bool TagConstraintSe { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_EX")]
    public bool TagConstraintEx { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_BR")]
    public bool TagConstraintBr { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_RP")]
    public bool TagConstraintRp { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_LG")]
    public bool TagConstraintLg { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_GO")]
    public bool TagConstraintGo { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_GS")]
    public bool TagConstraintGs { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_MS")]
    public bool TagConstraintMs { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("iec_61850_mms_client.DEVICE_TAG_CONSTRAINT_US")]
    public bool TagConstraintUs { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(AutoConfigSource)}: {AutoConfigSource}, {nameof(PollingLevel)}: {PollingLevel}, {nameof(OrCat)}: {OrCat}, {nameof(BufferSize)}: {BufferSize}";
}
