namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.Iec61850MmsClient;

/// <summary>
/// Specifies the level at which data is grouped and polled.
/// </summary>
public enum Iec61850MmsClientDevicePollingLevelType
{
    /// <summary>
    /// Poll at logical node level.
    /// </summary>
    [Description("Logical Node")]
    LogicalNode = 0,

    /// <summary>
    /// Poll at functional constraint level.
    /// </summary>
    [Description("Functional Constraint")]
    FunctionalConstraint = 1,

    /// <summary>
    /// Poll at data object level.
    /// </summary>
    [Description("Data Object")]
    DataObject = 2,

    /// <summary>
    /// Poll at attribute level.
    /// </summary>
    [Description("Attribute")]
    Attribute = 3,
}
