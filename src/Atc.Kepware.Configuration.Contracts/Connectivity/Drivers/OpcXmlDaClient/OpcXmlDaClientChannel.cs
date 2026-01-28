namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client channel.
/// </summary>
public class OpcXmlDaClientChannel : ChannelBase, IOpcXmlDaClientChannel
{
    /// <inheritdoc />
    public string ServerUrl { get; set; } = string.Empty;

    /// <inheritdoc />
    public int HttpTimeout { get; set; } = 30;

    /// <inheritdoc />
    public int SubscriptionUpdateRate { get; set; } = 1000;

    /// <inheritdoc />
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
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
