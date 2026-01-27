namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcDaClient;

/// <summary>
/// Represents an OPC DA Client channel creation request.
/// </summary>
public class OpcDaClientChannelRequest : ChannelRequestBase, IOpcDaClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpcDaClientChannelRequest"/> class.
    /// </summary>
    public OpcDaClientChannelRequest()
        : base(DriverType.OpcDaClient)
    {
    }

    /// <inheritdoc />
    [Required]
    public string ProgramId { get; set; } = string.Empty;

    /// <inheritdoc />
    public string? RemoteMachineName { get; set; }

    /// <inheritdoc />
    public OpcDaClientConnectionType ConnectionType { get; set; } = OpcDaClientConnectionType.Any;

    /// <inheritdoc />
    [Range(5, 600)]
    public int FailedConnectionRetryInterval { get; set; } = 5;

    /// <inheritdoc />
    [Range(5, 30)]
    public int ServerStatusQueryInterval { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ProgramId)}: {ProgramId}, {nameof(ConnectionType)}: {ConnectionType}";
}
