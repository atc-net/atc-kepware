namespace Atc.Kepware.Configuration.Tests;

public sealed class KepwareConfigurationClientIotGateWayAgentTests
{
    [Theory]
    [InlineData("ValidClientName", null, true)]
    [InlineData("Invalid.ClientName", null, false)]
    [InlineData(" InvalidClientName", null, false)]
    [InlineData("_ValidClientName", null, false)]
    [InlineData("ValidClientName", "ValidItemName", true)]
    [InlineData("ValidClientName", "Invalid.ItemName", false)]
    [InlineData("ValidClientName", " InvalidItemName", false)]
    [InlineData("ValidClientName", "_InvalidItemName", false)]

    public void IsValidIotGatewayName(
        string clientName,
        string? iotItemName,
        bool expectedIsValid)
    {
        // Arrange
        using var client = new KepwareConfigurationClient(NullLoggerFactory.Instance);
        var methodInfo = typeof(KepwareConfigurationClient).GetMethod("IsValidIotGatewayName", BindingFlags.NonPublic | BindingFlags.Static);

        // Act
        var parameters = new object[] { clientName, iotItemName, null };
        var result = (bool?)methodInfo!.Invoke(client, parameters) ?? false;

        // Assert
        Assert.Equal(expectedIsValid, result);
    }
}