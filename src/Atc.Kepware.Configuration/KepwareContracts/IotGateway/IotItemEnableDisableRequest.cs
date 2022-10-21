namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotItemEnableDisableRequest
{
    /// <summary>
    /// The ProjectId.
    /// </summary>
    [JsonPropertyName("PROJECT_ID")]
    public long ProjectId { get; set; }

    /// <summary>
    /// Indicates whether the Iot Item is enabled.
    /// </summary>
    [JsonPropertyName("iot_gateway.IOT_ITEM_ENABLED")]
    public bool Enabled { get; set; }

    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Enabled)}: {Enabled}";
}