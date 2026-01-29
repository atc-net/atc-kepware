namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Devices.Create;

public class DeviceCreateSnmpCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--snmp-version [SNMP-VERSION]")]
    [Description("SNMP protocol version (V1, V2c, V3)")]
    public FlagValue<SnmpVersionType>? SnmpVersion { get; init; } = new();

    [CommandOption("--port")]
    [Description("SNMP device port number (1-65535)")]
    [DefaultValue(161)]
    public int Port { get; init; }

    [CommandOption("--protocol [PROTOCOL]")]
    [Description("IP protocol (Tcp, Udp)")]
    public FlagValue<SnmpProtocolType>? Protocol { get; init; } = new();

    [CommandOption("--community [COMMUNITY]")]
    [Description("Community type for SNMP v1/v2c (Public, Private, Custom)")]
    public FlagValue<SnmpCommunityType>? Community { get; init; } = new();

    [CommandOption("--custom-community [CUSTOM-COMMUNITY]")]
    [Description("Custom community string for SNMP v1/v2c")]
    public FlagValue<string>? CustomCommunity { get; init; } = new();

    [CommandOption("--items-per-request")]
    [Description("Maximum number of items per SNMP request (1-25)")]
    [DefaultValue(25)]
    public int ItemsPerRequest { get; init; }

    [CommandOption("--username [USERNAME]")]
    [Description("SNMPv3 username")]
    public FlagValue<string>? Username { get; init; } = new();

    [CommandOption("--context-name [CONTEXT-NAME]")]
    [Description("SNMPv3 context name")]
    public FlagValue<string>? ContextName { get; init; } = new();

    [CommandOption("--security-level [SECURITY-LEVEL]")]
    [Description("SNMPv3 security level (NoAuthNoPriv, AuthNoPriv, AuthPriv)")]
    public FlagValue<SnmpSecurityLevelType>? SecurityLevel { get; init; } = new();

    [CommandOption("--authentication-style [AUTHENTICATION-STYLE]")]
    [Description("SNMPv3 authentication style (HmacMd5, HmacSha1)")]
    public FlagValue<SnmpAuthenticationProtocolType>? AuthenticationStyle { get; init; } = new();

    [CommandOption("--authentication-passphrase [AUTHENTICATION-PASSPHRASE]")]
    [Description("SNMPv3 authentication passphrase")]
    public FlagValue<string>? AuthenticationPassphrase { get; init; } = new();

    [CommandOption("--encryption-style [ENCRYPTION-STYLE]")]
    [Description("SNMPv3 encryption style (Des, Aes128, Aes192, Aes256)")]
    public FlagValue<SnmpPrivacyProtocolType>? EncryptionStyle { get; init; } = new();

    [CommandOption("--privacy-passphrase [PRIVACY-PASSPHRASE]")]
    [Description("SNMPv3 privacy passphrase")]
    public FlagValue<string>? PrivacyPassphrase { get; init; } = new();

    [CommandOption("--template [TEMPLATE]")]
    [Description("Device template type (EthernetSwitch, SinglePhaseUps, ThreePhaseUps, OtherDevice, None)")]
    public FlagValue<SnmpTemplateType>? Template { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 1 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 1 and 65535.");
        }

        if (ItemsPerRequest < 1 || ItemsPerRequest > 25)
        {
            return ValidationResult.Error("--items-per-request must be between 1 and 25.");
        }

        return ValidationResult.Success();
    }
}