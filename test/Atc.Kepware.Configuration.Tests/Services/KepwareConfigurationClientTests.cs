namespace Atc.Kepware.Configuration.Tests.Services;

/// <summary>
/// Tests for <see cref="KepwareConfigurationClient"/> core functionality.
/// </summary>
public sealed partial class KepwareConfigurationClientTests
{
    [Fact]
    public void Constructor_WithNullLoggerFactory_ShouldNotThrow()
    {
        // Act
        var act = () =>
        {
            using var client = new KepwareConfigurationClient(loggerFactory: null);
        };

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void Constructor_WithLoggerFactory_ShouldNotThrow()
    {
        // Arrange
        var loggerFactory = NullLoggerFactory.Instance;

        // Act
        var act = () =>
        {
            using var client = new KepwareConfigurationClient(loggerFactory);
        };

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void Constructor_WithConnectionInfo_ShouldConfigureConnection()
    {
        // Arrange
        var loggerFactory = NullLoggerFactory.Instance;
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        using var client = new KepwareConfigurationClient(
            loggerFactory,
            baseUri,
            userName: "Admin",
            password: "Password",
            disableCertificateValidationCheck: true);

        // Assert
        client.IsConnectionInformationConfigured().Should().BeTrue();
    }

    [Fact]
    public void IsConnectionInformationConfigured_WithoutConnectionInfo_ShouldReturnFalse()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = client.IsConnectionInformationConfigured();

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void SetConnectionInformation_ShouldConfigureConnection()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        client.SetConnectionInformation(baseUri, "Admin", "Password");

        // Assert
        client.IsConnectionInformationConfigured().Should().BeTrue();
    }

    [Fact]
    public void SetConnectionInformation_WithoutCredentials_ShouldConfigureConnection()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        client.SetConnectionInformation(baseUri, userName: null, password: null);

        // Assert
        client.IsConnectionInformationConfigured().Should().BeTrue();
    }

    [Fact]
    public void Dispose_ShouldNotThrow()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var act = () => client.Dispose();

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    [SuppressMessage(
        "Usage",
        "CA2000:Dispose objects before losing scope",
        Justification = "Testing multiple dispose calls")]
    public void Dispose_CalledMultipleTimes_ShouldNotThrow()
    {
        // Arrange
        var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var act = () =>
        {
            client.Dispose();
            client.Dispose();
        };

        // Assert
        act.Should().NotThrow();
    }
}