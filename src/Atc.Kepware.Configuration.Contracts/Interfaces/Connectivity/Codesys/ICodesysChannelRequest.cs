namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Codesys;

/// <summary>
/// Represents a CODESYS channel request.
/// </summary>
public interface ICodesysChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the number of minutes to keep an inactive connection open.
    /// </summary>
    int KeepAliveMinutes { get; set; }
}
