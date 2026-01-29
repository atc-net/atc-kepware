namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec61850MmsClient;

public sealed class Iec61850MmsClientDeviceRequest : DeviceRequestBase, IIec61850MmsClientDeviceRequest
{
    public Iec61850MmsClientDeviceRequest()
        : base(DriverType.Iec61850MmsClient)
    {
    }

    /// <inheritdoc />
    public Iec61850MmsClientDeviceAutoConfigSourceType AutoConfigSource { get; set; } = Iec61850MmsClientDeviceAutoConfigSourceType.Device;

    /// <inheritdoc />
    [MaxLength(260)]
    public string ConfigurationFile { get; set; } = string.Empty;

    /// <inheritdoc />
    public string SubNetwork { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Ied { get; set; } = string.Empty;

    /// <inheritdoc />
    public string AccessPoint { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool AuthenticationEnabled { get; set; }

    /// <inheritdoc />
    [MaxLength(80)]
    public string AuthenticationPassword { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool UseOptionalServerParameters { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ServerAeInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ServerAeQualifier { get; set; } = 12;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ServerApInvokeId { get; set; } = 10;

    /// <inheritdoc />
    public string ServerApplicationId { get; set; } = "1,1,1,999,1";

    /// <inheritdoc />
    public string ServerTransportSelector { get; set; } = "00 01";

    /// <inheritdoc />
    public string ServerSessionSelector { get; set; } = "00 01";

    /// <inheritdoc />
    public string ServerPresentationSelector { get; set; } = "00 00 00 01";

    /// <inheritdoc />
    public bool UseOptionalClientParameters { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ClientAeInvokeId { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ClientAeQualifier { get; set; } = 12;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int ClientApInvokeId { get; set; } = 10;

    /// <inheritdoc />
    public string ClientApplicationId { get; set; } = "1,1,1,999,1";

    /// <inheritdoc />
    public string ClientTransportSelector { get; set; } = "00 01";

    /// <inheritdoc />
    public string ClientSessionSelector { get; set; } = "00 01";

    /// <inheritdoc />
    public string ClientPresentationSelector { get; set; } = "00 00 00 01";

    /// <inheritdoc />
    [Range(1, 10000)]
    public int BufferSize { get; set; } = 100;

    /// <inheritdoc />
    [Range(50, 999999999)]
    public int PlaybackRateMs { get; set; } = 2000;

    /// <inheritdoc />
    [Range(0, 999999999)]
    public int IntegrityPollRateMs { get; set; } = 5000;

    /// <inheritdoc />
    public Iec61850MmsClientDevicePollingLevelType PollingLevel { get; set; } = Iec61850MmsClientDevicePollingLevelType.LogicalNode;

    /// <inheritdoc />
    public Iec61850MmsClientDeviceOrCatType OrCat { get; set; } = Iec61850MmsClientDeviceOrCatType.BayControl;

    /// <inheritdoc />
    public string? OrIdent { get; set; }

    /// <inheritdoc />
    [Range(0, 255)]
    public int CtlNum { get; set; }

    /// <inheritdoc />
    public bool Test { get; set; }

    /// <inheritdoc />
    [MinLength(1)]
    [MaxLength(2)]
    public string Check { get; set; } = "00";

    /// <inheritdoc />
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    public bool GenerateReportedDataSets { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintSt { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintMx { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintCo { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintSp { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintSv { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintCf { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintDc { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintSg { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintSe { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintEx { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintBr { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintRp { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintLg { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintGo { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintGs { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintMs { get; set; } = true;

    /// <inheritdoc />
    public bool TagConstraintUs { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(AutoConfigSource)}: {AutoConfigSource}, {nameof(PollingLevel)}: {PollingLevel}, {nameof(OrCat)}: {OrCat}, {nameof(BufferSize)}: {BufferSize}, {nameof(PlaybackRateMs)}: {PlaybackRateMs}, {nameof(IntegrityPollRateMs)}: {IntegrityPollRateMs}";
}