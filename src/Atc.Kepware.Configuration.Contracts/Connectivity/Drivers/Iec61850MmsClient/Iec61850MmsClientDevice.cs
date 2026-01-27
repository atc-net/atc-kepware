namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec61850MmsClient;

public sealed class Iec61850MmsClientDevice : DeviceBase, IIec61850MmsClientDevice
{
    public Iec61850MmsClientDeviceAutoConfigSourceType AutoConfigSource { get; set; }

    public string ConfigurationFile { get; set; } = string.Empty;

    public string SubNetwork { get; set; } = string.Empty;

    public string Ied { get; set; } = string.Empty;

    public string AccessPoint { get; set; } = string.Empty;

    public bool AuthenticationEnabled { get; set; }

    public string AuthenticationPassword { get; set; } = string.Empty;

    public bool UseOptionalServerParameters { get; set; }

    public int ServerAeInvokeId { get; set; }

    public int ServerAeQualifier { get; set; }

    public int ServerApInvokeId { get; set; }

    public string ServerApplicationId { get; set; } = string.Empty;

    public string ServerTransportSelector { get; set; } = string.Empty;

    public string ServerSessionSelector { get; set; } = string.Empty;

    public string ServerPresentationSelector { get; set; } = string.Empty;

    public bool UseOptionalClientParameters { get; set; }

    public int ClientAeInvokeId { get; set; }

    public int ClientAeQualifier { get; set; }

    public int ClientApInvokeId { get; set; }

    public string ClientApplicationId { get; set; } = string.Empty;

    public string ClientTransportSelector { get; set; } = string.Empty;

    public string ClientSessionSelector { get; set; } = string.Empty;

    public string ClientPresentationSelector { get; set; } = string.Empty;

    public int BufferSize { get; set; }

    public int PlaybackRateMs { get; set; }

    public int IntegrityPollRateMs { get; set; }

    public Iec61850MmsClientDevicePollingLevelType PollingLevel { get; set; }

    public Iec61850MmsClientDeviceOrCatType OrCat { get; set; }

    public string? OrIdent { get; set; }

    public int CtlNum { get; set; }

    public bool Test { get; set; }

    public string Check { get; set; } = string.Empty;

    public bool DisplayDescriptions { get; set; }

    public bool GenerateReportedDataSets { get; set; }

    public bool TagConstraintSt { get; set; }

    public bool TagConstraintMx { get; set; }

    public bool TagConstraintCo { get; set; }

    public bool TagConstraintSp { get; set; }

    public bool TagConstraintSv { get; set; }

    public bool TagConstraintCf { get; set; }

    public bool TagConstraintDc { get; set; }

    public bool TagConstraintSg { get; set; }

    public bool TagConstraintSe { get; set; }

    public bool TagConstraintEx { get; set; }

    public bool TagConstraintBr { get; set; }

    public bool TagConstraintRp { get; set; }

    public bool TagConstraintLg { get; set; }

    public bool TagConstraintGo { get; set; }

    public bool TagConstraintGs { get; set; }

    public bool TagConstraintMs { get; set; }

    public bool TagConstraintUs { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(AutoConfigSource)}: {AutoConfigSource}, {nameof(PollingLevel)}: {PollingLevel}, {nameof(OrCat)}: {OrCat}, {nameof(BufferSize)}: {BufferSize}, {nameof(PlaybackRateMs)}: {PlaybackRateMs}, {nameof(IntegrityPollRateMs)}: {IntegrityPollRateMs}";
}
