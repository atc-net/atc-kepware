namespace Atc.Kepware.Configuration.Options;

/// <summary>
/// Configuration options for the Kepware Configuration Client.
/// </summary>
public class KepwareConfigurationOptions
{
    /// <summary>
    /// Gets or sets the base URI of the Kepware server.
    /// </summary>
    /// <example>https://localhost:57412/config/v1/</example>
    public Uri? BaseUri { get; set; }

    /// <summary>
    /// Gets or sets the username for authentication with the Kepware server.
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the password for authentication with the Kepware server.
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to disable SSL/TLS certificate validation.
    /// </summary>
    /// <remarks>
    /// Setting this to <c>true</c> will accept any server certificate, which is useful for
    /// development environments with self-signed certificates but should be avoided in production.
    /// </remarks>
    public bool DisableCertificateValidationCheck { get; set; } = true;
}