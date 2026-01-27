namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcDaClient;

/// <summary>
/// Represents an OPC DA Client channel.
/// </summary>
public class OpcDaClientChannel : ChannelBase, IOpcDaClientChannel
{
    /// <inheritdoc />
    public string ProgramId { get; set; } = string.Empty;

    /// <inheritdoc />
    public string? RemoteMachineName { get; set; }

    /// <inheritdoc />
    public OpcDaClientConnectionType ConnectionType { get; set; } = OpcDaClientConnectionType.Any;

    /// <inheritdoc />
    public int FailedConnectionRetryInterval { get; set; } = 5;

    /// <inheritdoc />
    public int ServerStatusQueryInterval { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ProgramId)}: {ProgramId}, {nameof(ConnectionType)}: {ConnectionType}";
}
