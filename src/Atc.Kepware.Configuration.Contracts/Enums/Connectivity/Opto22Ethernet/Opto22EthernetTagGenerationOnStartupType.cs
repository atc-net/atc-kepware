namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Opto22Ethernet;

/// <summary>
/// Automatic tag generation action to be taken on device startup.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Opto%2022%20Ethernet/devices
/// Section: servermain.DEVICE_TAG_GENERATION_ON_STARTUP
/// </remarks>
public enum Opto22EthernetTagGenerationOnStartupType
{
    /// <summary>
    /// Do not generate tags on startup.
    /// </summary>
    [Description("Do Not Generate on Startup")]
    DoNotGenerateOnStartup = 0,

    /// <summary>
    /// Always generate tags on startup.
    /// </summary>
    [Description("Always Generate on Startup")]
    AlwaysGenerateOnStartup = 1,

    /// <summary>
    /// Generate tags on first startup only.
    /// </summary>
    [Description("Generate on First Startup")]
    GenerateOnFirstStartup = 2,
}
