namespace Atc.Kepware.Configuration.Tests;

public sealed class KepwareConfigurationClientConnectivityTests
{
    [Theory]
    [InlineData("ValidChannelName", null, null, null, true)]
    [InlineData("Invalid.ChannelName", null, null, null, false)]
    [InlineData(" InvalidChannelName", null, null, null, false)]
    [InlineData("_ValidChannelName", null, null, null, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", null, null, true)]
    [InlineData("ValidChannelName", "Invalid.DeviceName", null, null, false)]
    [InlineData("ValidChannelName", " InvalidDeviceName", null, null, false)]
    [InlineData("ValidChannelName", "_ValidDeviceName", null, null, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", "ValidTagGroupName", null, true)]
    [InlineData("ValidChannelName", "ValidDeviceName", "Invalid.TagGroupName", null, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", " InvalidTagGroupName", null, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", "_ValidTagGroupName", null, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", "ValidTagGroupName", new[] { "ValidTag1", "ValidTag2" }, true)]
    [InlineData("ValidChannelName", "ValidDeviceName", "ValidTagGroupName", new[] { "ValidTag1", "Invalid.Tag2" }, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", "ValidTagGroupName", new[] { "ValidTag1", " InvalidTag2" }, false)]
    [InlineData("ValidChannelName", "ValidDeviceName", "ValidTagGroupName", new[] { "ValidTag1", "_InvalidTag2" }, false)]
    public void IsValidConnectivityName(
        string channelName,
        string? deviceName,
        string? tagGroupNameOrTagName,
        string[]? tagGroupStructure,
        bool expectedIsValid)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);
        var methodInfo = typeof(KepwareConfigurationClient).GetMethod("IsValidConnectivityName", BindingFlags.NonPublic | BindingFlags.Static);

        // Act
        var parameters = new object[] { channelName, deviceName, tagGroupNameOrTagName, tagGroupStructure, null };
        var result = (bool?)methodInfo!.Invoke(client, parameters) ?? false;

        // Assert
        Assert.Equal(expectedIsValid, result);
    }
}