namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec608705104Client;

/// <summary>
/// Specifies the Cause of Transmission (COT) Size for IEC 60870-5-104 Client.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values are defined by the IEC 60870-5-104 protocol.")]
public enum Iec608705104CotSizeType
{
    /// <summary>
    /// One octet for COT.
    /// </summary>
    OneOctet = 1,

    /// <summary>
    /// Two octets for COT (default).
    /// </summary>
    TwoOctets = 2,
}