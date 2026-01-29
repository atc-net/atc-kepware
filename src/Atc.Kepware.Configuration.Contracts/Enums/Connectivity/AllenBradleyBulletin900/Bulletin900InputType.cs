// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The type of input for Allen-Bradley Bulletin 900 Enhanced models.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%20900/Devices
/// Section: a-b_bulletin_900.DEVICE_INPUT_TYPE
/// </remarks>
public enum Bulletin900InputType
{
    [Description("TC/Pt Multi Input")]
    TcPtMultiInput = 0,

    [Description("Analog Input")]
    AnalogInput = 1,
}