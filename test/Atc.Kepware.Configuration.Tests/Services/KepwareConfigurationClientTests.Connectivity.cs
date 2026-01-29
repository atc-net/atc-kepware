namespace Atc.Kepware.Configuration.Tests.Services;

/// <summary>
/// Connectivity-related tests for <see cref="KepwareConfigurationClient"/>.
/// </summary>
public sealed partial class KepwareConfigurationClientTests
{
    [Fact]
    public async Task IsChannelDefined_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.IsChannelDefined(
            "TestChannel",
            CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
        result.HasException.Should().BeTrue();
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public async Task IsChannelDefined_WithInvalidChannelName_ShouldReturnBadRequest(
        string channelName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.IsChannelDefined(channelName, CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task IsDeviceDefined_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.IsDeviceDefined(
            "TestChannel",
            "TestDevice",
            CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
        result.HasException.Should().BeTrue();
    }

    [Theory]
    [InlineData("ValidChannel", "Invalid.Device")]
    [InlineData("Invalid.Channel", "ValidDevice")]
    public async Task IsDeviceDefined_WithInvalidNames_ShouldReturnBadRequest(
        string channelName,
        string deviceName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.IsDeviceDefined(
            channelName,
            deviceName,
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task IsTagDefined_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.IsTagDefined(
            "TestChannel",
            "TestDevice",
            "TestTag",
            [],
            CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
        result.HasException.Should().BeTrue();
    }

    [Theory]
    [InlineData("ValidChannel", "ValidDevice", "Invalid.Tag")]
    [InlineData("ValidChannel", "Invalid.Device", "ValidTag")]
    [InlineData("Invalid.Channel", "ValidDevice", "ValidTag")]
    public async Task IsTagDefined_WithInvalidNames_ShouldReturnBadRequest(
        string channelName,
        string deviceName,
        string tagName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.IsTagDefined(
            channelName,
            deviceName,
            tagName,
            [],
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task IsTagGroupDefined_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.IsTagGroupDefined(
            "TestChannel",
            "TestDevice",
            "TestGroup",
            [],
            CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
        result.HasException.Should().BeTrue();
    }

    [Fact]
    public async Task GetChannels_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.GetChannels(CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
    }

    [Fact]
    public async Task GetDevicesByChannelName_WithoutConnectionInfo_ShouldReturnFailure()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.GetDevicesByChannelName(
            "TestChannel",
            CancellationToken.None);

        // Assert
        result.CommunicationSucceeded.Should().BeFalse();
    }

    [Theory]
    [InlineData("Invalid.Channel")]
    [InlineData(" InvalidChannel")]
    [InlineData("_InvalidChannel")]
    public async Task GetDevicesByChannelName_WithInvalidChannelName_ShouldReturnBadRequest(
        string channelName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.GetDevicesByChannelName(
            channelName,
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task GetTags_WithoutConnectionInfo_ShouldReturnStatusCode()
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);

        // Act
        var result = await client.GetTags(
            "TestChannel",
            "TestDevice",
            maxDepth: 5,
            CancellationToken.None);

        // Assert
        // GetTags returns a result based on inner HTTP call behavior
        // When connection info is not set, it will have a status code from the failed internal call
        result.HasData.Should().BeFalse();
    }

    [Theory]
    [InlineData("Invalid.Channel", "ValidDevice")]
    [InlineData("ValidChannel", "Invalid.Device")]
    public async Task GetTags_WithInvalidNames_ShouldReturnBadRequest(
        string channelName,
        string deviceName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.GetTags(
            channelName,
            deviceName,
            maxDepth: 5,
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public async Task SearchTags_WithEmptyQuery_ShouldReturnBadRequest(
        string? query)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.SearchTags(
            "Channel",
            "Device",
            query!,
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Theory]
    [InlineData("Invalid.Channel")]
    [InlineData(" InvalidChannel")]
    [InlineData("_InvalidChannel")]
    public async Task DeleteChannel_WithInvalidChannelName_ShouldReturnBadRequest(
        string channelName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.DeleteChannel(channelName, CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }

    [Theory]
    [InlineData("Invalid.Channel", "ValidDevice")]
    [InlineData("ValidChannel", "Invalid.Device")]
    public async Task DeleteDevice_WithInvalidNames_ShouldReturnBadRequest(
        string channelName,
        string deviceName)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(
            NullLoggerFactory.Instance,
            new Uri("https://localhost:57412/config/v1/"),
            "Admin",
            "Password");

        // Act
        var result = await client.DeleteDevice(
            channelName,
            deviceName,
            CancellationToken.None);

        // Assert
        result.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
    }
}