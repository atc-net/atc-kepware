// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Determines the automatic tag generation action to be taken on device startup.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/EUROMAP%2063/Devices
/// Section: servermain.DEVICE_TAG_GENERATION_ON_STARTUP
/// </remarks>
public enum EuroMap63DeviceTagGenerationOnStartupType
{
    /// <summary>
    /// Prevents the driver from adding any OPC tags to the tag space of the server.
    /// This is the default setting.
    /// </summary>
    DoNotGenerateOnStartup = 0,

    /// <summary>
    /// Causes the driver to evaluate the device for tag information.
    /// It also adds tags to the tag space of the server every time the server is launched.
    /// </summary>
    AlwaysGenerateOnStartup = 1,

    /// <summary>
    /// Causes the driver to evaluate the target device for tag information
    /// the first time the project is run.
    /// It also adds any OPC tags to the server tag space as needed.
    /// </summary>
    GenerateOnFirstStartup = 2,
}