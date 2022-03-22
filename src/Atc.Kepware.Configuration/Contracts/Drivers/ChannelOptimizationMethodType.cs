namespace Atc.Kepware.Configuration.Contracts.Drivers;

/// <summary>
/// Choose how write data is passed to the underlying communications driver
/// when more than one write exists in the write queue.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/{driverName}/channels
/// Section: servermain.CHANNEL_WRITE_OPTIMIZATIONS_METHOD
/// </remarks>
public enum ChannelOptimizationMethodType
{
    WriteAllValuesForAllTags = 0,
    WriteOnlyLatestValueForNonBooleanTags = 1,
    WriteOnlyLatestValueForAllTags = 2,
}