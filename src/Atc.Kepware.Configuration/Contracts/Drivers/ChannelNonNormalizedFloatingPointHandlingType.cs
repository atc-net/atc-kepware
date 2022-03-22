namespace Atc.Kepware.Configuration.Contracts.Drivers;

/// <summary>
/// Choose how to send invalid floating-point numbers to the client.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/{driverName}/channels
/// Section: servermain.CHANNEL_NON_NORMALIZED_FLOATING_POINT_HANDLING
/// </remarks>
public enum ChannelNonNormalizedFloatingPointHandlingType
{
    ReplaceWithZero = 0,
    Unmodified = 1,
}