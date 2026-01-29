namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.BeckhoffTwinCat;

/// <summary>
/// Beckhoff TwinCAT default data type.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Names match Kepware API.")]
public enum BeckhoffTwinCatDefaultType
{
    /// <summary>
    /// String data type.
    /// </summary>
    String = 0,

    /// <summary>
    /// Boolean data type.
    /// </summary>
    Boolean = 1,

    /// <summary>
    /// Char data type.
    /// </summary>
    Char = 2,

    /// <summary>
    /// Byte data type.
    /// </summary>
    Byte = 3,

    /// <summary>
    /// Short data type.
    /// </summary>
    Short = 4,

    /// <summary>
    /// Word data type.
    /// </summary>
    Word = 5,

    /// <summary>
    /// Long data type.
    /// </summary>
    Long = 6,

    /// <summary>
    /// DWord data type.
    /// </summary>
    DWord = 7,

    /// <summary>
    /// Float data type.
    /// </summary>
    Float = 8,

    /// <summary>
    /// Double data type.
    /// </summary>
    Double = 9,
}