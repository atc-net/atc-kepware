namespace Atc.Kepware.Configuration.Contracts.Interfaces.IotGateway;

public interface IIotItem
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    long ProjectId { get; set; }

    /// <summary>
    /// Name of the Iot Item.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the Iot Item.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// The server tag the Iot Item is pointing to.
    /// </summary>
    string ServerTag { get; set; }

    /// <summary>
    /// Specifies the frequency, in milliseconds, at which the iot item should be scanned.
    /// </summary>
    int ScanRate { get; set; }

    /// <summary>
    /// Specifies if the tag should be published on every scan or only on data changes.
    /// </summary>
    /// <remarks>
    /// Returns <see langword="true"/> if should publish on every scan; otherwise, <see langword="false"/>.
    /// </remarks>
    bool SendEveryScan { get; set; }

    /// <summary>
    /// Specifies the DeadBand (%).
    /// </summary>
    /// <remarks>
    /// This setting is only valid for <see cref="IIotItem.SendEveryScan"/> when set to <see langword="false"/>.
    /// </remarks>
    int DeadBandPercent { get; set; }

    /// <summary>
    /// Indicates whether the Iot Item is enabled.
    /// </summary>
    bool Enabled { get; set; }
}