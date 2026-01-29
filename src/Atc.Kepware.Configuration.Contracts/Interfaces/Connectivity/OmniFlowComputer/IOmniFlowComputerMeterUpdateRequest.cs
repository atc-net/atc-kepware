namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OmniFlowComputer;

/// <summary>
/// Interface for Omni Flow Computer meter update requests.
/// </summary>
/// <remarks>
/// Omni Flow Computer meters are auto-generated and can only be updated (not created or deleted).
/// </remarks>
public interface IOmniFlowComputerMeterUpdateRequest
{
    /// <summary>
    /// Name of the meter (1-256 characters).
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// Description of the meter (0-255 characters).
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// Specifies the device archive number that will store the meter's hourly historical data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber? HourlyArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the device archive number that will store the meter's daily historical data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber? DailyArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the device archive number that will store the meter's batch data.
    /// A value of zero (0) disables the archive.
    /// </summary>
    OmniArchiveNumber? BatchArchiveNumber { get; set; }

    /// <summary>
    /// Specifies the liquid meter type that will be applied to the EFM configuration when an upload is performed.
    /// </summary>
    OmniLiquidMeterType? LiquidMeterType { get; set; }
}