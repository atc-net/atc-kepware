namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client channel creation request.
/// </summary>
public class OpcXmlDaClientChannelRequest : ChannelRequestBase, IOpcXmlDaClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpcXmlDaClientChannelRequest"/> class.
    /// </summary>
    public OpcXmlDaClientChannelRequest()
        : base(DriverType.OpcXmlDaClient)
    {
    }

    /// <inheritdoc />
    [Required]
    public string ServerUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 999)]
    public int HttpTimeout { get; set; } = 30;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int SubscriptionUpdateRate { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public string? LocaleId { get; set; }

    /// <inheritdoc />
    public bool UseHttpAuthentication { get; set; }

    /// <inheritdoc />
    public string? HttpAuthenticationUserName { get; set; }

    /// <inheritdoc />
    public string? HttpAuthenticationPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(ServerUrl)}: {ServerUrl}, {nameof(HttpTimeout)}: {HttpTimeout}";
}
