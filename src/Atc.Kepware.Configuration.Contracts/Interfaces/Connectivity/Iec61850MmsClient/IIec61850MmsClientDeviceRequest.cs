namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec61850MmsClient;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "Ex is the IEC 61850 standard abbreviation for Extended Definition.")]
public interface IIec61850MmsClientDeviceRequest
{
    /// <summary>
    /// Specify the source for automatic device configuration.
    /// When Device is selected, tags will be created using the online device self-description services.
    /// When File is specified, tags will be created from the configured SCL file.
    /// </summary>
    Iec61850MmsClientDeviceAutoConfigSourceType AutoConfigSource { get; set; }

    /// <summary>
    /// Specify the SCL file to import the configuration from.
    /// The selected file can have an .icd, .cid, or .scd extension.
    /// </summary>
    string ConfigurationFile { get; set; }

    /// <summary>
    /// Specify a SubNetwork for automatic device configuration.
    /// </summary>
    string SubNetwork { get; set; }

    /// <summary>
    /// Specify an Intelligent Electronic Device (IED) for automatic device configuration.
    /// </summary>
    string Ied { get; set; }

    /// <summary>
    /// Specify an AccessPoint for automatic device configuration.
    /// </summary>
    string AccessPoint { get; set; }

    /// <summary>
    /// Specify Yes to use Association Control Service Element (ACSE) authentication.
    /// </summary>
    bool AuthenticationEnabled { get; set; }

    /// <summary>
    /// Specify the password for ACSE authentication.
    /// </summary>
    string AuthenticationPassword { get; set; }

    /// <summary>
    /// Specify Yes to have the Server Parameters available for editing and included when initiating a connection with a device.
    /// </summary>
    bool UseOptionalServerParameters { get; set; }

    /// <summary>
    /// Specify the server ACSE AE Invoke ID.
    /// </summary>
    int ServerAeInvokeId { get; set; }

    /// <summary>
    /// Specify the server ACSE AE Qualifier.
    /// </summary>
    int ServerAeQualifier { get; set; }

    /// <summary>
    /// Specify the server ACSE AP Invoke ID.
    /// </summary>
    int ServerApInvokeId { get; set; }

    /// <summary>
    /// Specify the server ACSE Application ID.
    /// It must be from 3 to 10 integers, and delimited by commas.
    /// </summary>
    string ServerApplicationId { get; set; }

    /// <summary>
    /// Specify the server OSI-TSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ServerTransportSelector { get; set; }

    /// <summary>
    /// Specify the server OSI-SSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ServerSessionSelector { get; set; }

    /// <summary>
    /// Specify the server OSI-PSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ServerPresentationSelector { get; set; }

    /// <summary>
    /// Specify Yes to have the Client Parameters available for editing and included when initiating a connection with a device.
    /// </summary>
    bool UseOptionalClientParameters { get; set; }

    /// <summary>
    /// Specify the client ACSE AE Invoke ID.
    /// </summary>
    int ClientAeInvokeId { get; set; }

    /// <summary>
    /// Specify the client ACSE AE Qualifier.
    /// </summary>
    int ClientAeQualifier { get; set; }

    /// <summary>
    /// Specify the client ACSE AP Invoke ID.
    /// </summary>
    int ClientApInvokeId { get; set; }

    /// <summary>
    /// Specify the client ACSE Application ID.
    /// It must be from 3 to 10 integers, and delimited by commas.
    /// </summary>
    string ClientApplicationId { get; set; }

    /// <summary>
    /// Specify the client OSI-TSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ClientTransportSelector { get; set; }

    /// <summary>
    /// Specify the client OSI-SSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ClientSessionSelector { get; set; }

    /// <summary>
    /// Specify the client OSI-PSEL used in establishing a remote server connection.
    /// It specifies a byte array, which is expressed as pairs of hexadecimal digits separated by zero or more spaces.
    /// </summary>
    string ClientPresentationSelector { get; set; }

    /// <summary>
    /// Specify the data buffer size.
    /// If the length of the data buffer exceeds the maximum, the oldest value on the buffer is discarded.
    /// </summary>
    int BufferSize { get; set; }

    /// <summary>
    /// Specify the amount of time, in milliseconds, before a value is removed from the data buffer after it is assigned to a tag.
    /// </summary>
    int PlaybackRateMs { get; set; }

    /// <summary>
    /// Specify the amount of time, in milliseconds, that can elapse between either receiving a report or receiving a solicited response
    /// before the driver must check the integrity of its connection with the IED.
    /// </summary>
    int IntegrityPollRateMs { get; set; }

    /// <summary>
    /// Specify the level at which data is grouped and polled.
    /// </summary>
    Iec61850MmsClientDevicePollingLevelType PollingLevel { get; set; }

    /// <summary>
    /// Specify the value of orCat when making a structured write to a control object.
    /// </summary>
    Iec61850MmsClientDeviceOrCatType OrCat { get; set; }

    /// <summary>
    /// Specify the value of the _orIdent Tag.
    /// The value must be a hex byte array (such as '01 7A F0').
    /// </summary>
    string? OrIdent { get; set; }

    /// <summary>
    /// Specify the value of the _ctlNum Tag.
    /// The value must be an 8 bit unsigned integer.
    /// </summary>
    int CtlNum { get; set; }

    /// <summary>
    /// Specify the Boolean value assigned to the _Test Tag.
    /// When Enabled, the value is 1. When Disabled, the value is 0.
    /// </summary>
    bool Test { get; set; }

    /// <summary>
    /// Specify the value of the _Check Tag.
    /// Check is a 2-bit binary number.
    /// </summary>
    string Check { get; set; }

    /// <summary>
    /// Specify Yes to apply the SCL file data attribute descriptions to the tag descriptions.
    /// </summary>
    bool DisplayDescriptions { get; set; }

    /// <summary>
    /// Specify Yes to generate tags for data sets referenced by report control blocks.
    /// </summary>
    bool GenerateReportedDataSets { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the ST Functional Constraint.
    /// </summary>
    bool TagConstraintSt { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the MX Functional Constraint.
    /// </summary>
    bool TagConstraintMx { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the CO Functional Constraint.
    /// </summary>
    bool TagConstraintCo { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the SP Functional Constraint.
    /// </summary>
    bool TagConstraintSp { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the SV Functional Constraint.
    /// </summary>
    bool TagConstraintSv { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the CF Functional Constraint.
    /// </summary>
    bool TagConstraintCf { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the DC Functional Constraint.
    /// </summary>
    bool TagConstraintDc { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the SG Functional Constraint.
    /// </summary>
    bool TagConstraintSg { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the SE Functional Constraint.
    /// </summary>
    bool TagConstraintSe { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the EX Functional Constraint.
    /// </summary>
    bool TagConstraintEx { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the BR Functional Constraint.
    /// </summary>
    bool TagConstraintBr { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the RP Functional Constraint.
    /// </summary>
    bool TagConstraintRp { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the LG Functional Constraint.
    /// </summary>
    bool TagConstraintLg { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the GO Functional Constraint.
    /// </summary>
    bool TagConstraintGo { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the GS Functional Constraint.
    /// </summary>
    bool TagConstraintGs { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the MS Functional Constraint.
    /// </summary>
    bool TagConstraintMs { get; set; }

    /// <summary>
    /// Specify Yes to generate tags with the US Functional Constraint.
    /// </summary>
    bool TagConstraintUs { get; set; }
}
