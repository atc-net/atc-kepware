namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.DnpClientEthernet;

/// <summary>
/// Specifies whether the writable I/O points use the Direct Operate or Select then Operate sequence.
/// </summary>
public enum DnpOperateModeType
{
    /// <summary>
    /// Direct Operate - Execute the operation directly.
    /// </summary>
    DirectOperate = 0,

    /// <summary>
    /// Select then Operate - Select the point before operating.
    /// </summary>
    SelectThenOperate = 1,
}