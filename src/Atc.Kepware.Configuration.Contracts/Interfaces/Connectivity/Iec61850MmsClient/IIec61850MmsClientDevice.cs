namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec61850MmsClient;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "Ex is the IEC 61850 standard abbreviation for Extended Definition.")]
public interface IIec61850MmsClientDevice : IDeviceBase
{
    Iec61850MmsClientDeviceAutoConfigSourceType AutoConfigSource { get; set; }

    string ConfigurationFile { get; set; }

    string SubNetwork { get; set; }

    string Ied { get; set; }

    string AccessPoint { get; set; }

    bool AuthenticationEnabled { get; set; }

    string AuthenticationPassword { get; set; }

    bool UseOptionalServerParameters { get; set; }

    int ServerAeInvokeId { get; set; }

    int ServerAeQualifier { get; set; }

    int ServerApInvokeId { get; set; }

    string ServerApplicationId { get; set; }

    string ServerTransportSelector { get; set; }

    string ServerSessionSelector { get; set; }

    string ServerPresentationSelector { get; set; }

    bool UseOptionalClientParameters { get; set; }

    int ClientAeInvokeId { get; set; }

    int ClientAeQualifier { get; set; }

    int ClientApInvokeId { get; set; }

    string ClientApplicationId { get; set; }

    string ClientTransportSelector { get; set; }

    string ClientSessionSelector { get; set; }

    string ClientPresentationSelector { get; set; }

    int BufferSize { get; set; }

    int PlaybackRateMs { get; set; }

    int IntegrityPollRateMs { get; set; }

    Iec61850MmsClientDevicePollingLevelType PollingLevel { get; set; }

    Iec61850MmsClientDeviceOrCatType OrCat { get; set; }

    string? OrIdent { get; set; }

    int CtlNum { get; set; }

    bool Test { get; set; }

    string Check { get; set; }

    bool DisplayDescriptions { get; set; }

    bool GenerateReportedDataSets { get; set; }

    bool TagConstraintSt { get; set; }

    bool TagConstraintMx { get; set; }

    bool TagConstraintCo { get; set; }

    bool TagConstraintSp { get; set; }

    bool TagConstraintSv { get; set; }

    bool TagConstraintCf { get; set; }

    bool TagConstraintDc { get; set; }

    bool TagConstraintSg { get; set; }

    bool TagConstraintSe { get; set; }

    bool TagConstraintEx { get; set; }

    bool TagConstraintBr { get; set; }

    bool TagConstraintRp { get; set; }

    bool TagConstraintLg { get; set; }

    bool TagConstraintGo { get; set; }

    bool TagConstraintGs { get; set; }

    bool TagConstraintMs { get; set; }

    bool TagConstraintUs { get; set; }
}
