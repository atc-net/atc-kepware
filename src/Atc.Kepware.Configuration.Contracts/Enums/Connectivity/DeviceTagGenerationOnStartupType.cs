// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The automatic tag generation action to be taken on device startup.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/{driver}/Devices
/// Section: servermain.DEVICE_TAG_GENERATION_ON_STARTUP
/// </remarks>
public enum DeviceTagGenerationOnStartupType
{
    DoNotGenerateOnStartup = 0,
    AlwaysGenerateOnStartup = 1,
    GenerateOnFirstStartup = 2,
}
