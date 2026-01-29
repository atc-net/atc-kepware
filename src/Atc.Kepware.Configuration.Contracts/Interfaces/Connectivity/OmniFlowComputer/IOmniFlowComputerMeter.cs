namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OmniFlowComputer;

/// <summary>
/// Interface for Omni Flow Computer meter objects.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and cannot be created or deleted via API.
/// </remarks>
public interface IOmniFlowComputerMeter : IMeterBase
{
    /// <summary>
    /// Specifies the device archive number that will store the meter's hourly historical data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber HourlyArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the device archive number that will store the meter's daily historical data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber DailyArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the device archive number that will store the meter's batch data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber BatchArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the liquid meter type that will be applied to the EFM configuration when an upload is performed.
    /// </summary>
    OmniLiquidMeterType LiquidMeterType { get; set; }
}
