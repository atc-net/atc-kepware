namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Codesys;

/// <summary>
/// Represents a CODESYS channel.
/// </summary>
public interface ICodesysChannel : IChannelBase
{
    /// <summary>
    /// Specify the number of minutes to keep an inactive connection open.
    /// </summary>
    int KeepAliveMinutes { get; set; }
}