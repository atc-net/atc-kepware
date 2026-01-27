// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The default data type to assign to a tag when the default type is selected.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Micro800%20Ethernet/Devices
/// Section: allenbradley_micro800_ethernet.DEVICE_DEFAULT_DATA_TYPE
/// </remarks>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Values match Kepware API.")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Not a flags enum.")]
public enum Micro800DefaultDataType
{
    String = 0,
    Boolean = 1,
    Char = 2,
    Byte = 3,
    Short = 4,
    Word = 5,
    Long = 6,
    DWord = 7,
    Float = 8,
    Bcd = 10,
    Lbcd = 11,
}
