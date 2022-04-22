// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

public enum DeviceScanModeType
{
    /// <summary>
    /// Uses the scan rate requested by the client.
    /// </summary>
    RespectClientSpecifiedScanRate = 0,

    /// <summary>
    /// Specifies the value set as the maximum scan rate.
    /// The valid range is 10 to 99999990 milliseconds.
    /// The default is 1000 milliseconds.
    /// </summary>
    RequestDataNoFasterThanScanRate = 1,

    /// <summary>
    /// Forces tags to be scanned at the specified rate for subscribed clients.
    /// The valid range is 10 to 99999990 milliseconds.
    /// The default is 1000 milliseconds
    /// </summary>
    RequestAllDataAtScanRate = 2,

    /// <summary>
    /// Does not periodically poll tags that belong to the
    /// device nor perform a read to get an item's initial value once it becomes active.
    /// It is the OPC client's responsibility to poll for updates,
    /// either by writing to the _DemandPoll tag or by issuing explicit device
    /// reads for individual items.
    /// </summary>
    DoNotScanDemandPollOnly = 3,

    /// <summary>
    /// Forces static tags to be scanned at the rate specified
    /// in their static configuration tag properties.
    /// Dynamic tags are scanned at the client-specified scan rate.
    /// </summary>
    RespectTagSpecifiedScanRate = 4,
}