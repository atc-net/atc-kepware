namespace Atc.Kepware.Configuration.Services;

internal static class EndpointPathTemplateConstants
{
    public const string ConfigurationBase = "config/v1/";

    public const string Devices = "devices";
    public const string Channels = ConfigurationBase + "project/channels";
    public const string Tags = "tags";
    public const string TagGroups = "tag_groups";

    public const string IotGateway = ConfigurationBase + "project/_iot_gateway";
    public const string IotGatewayMqttClients = IotGateway + "/mqtt_clients";
    public const string IotGatewayRestClients = IotGateway + "/rest_clients";
    public const string IotGatewayRestServers = IotGateway + "/rest_servers";

    public const string IotItems = "iot_items";

    public const string MeterGroups = "Meter_Groups";
    public const string AbbTotalflowMeters = "abb_totalflow_meters";
    public const string FisherRocEthernetMeters = "fisher_roc_ethernet_meters";
    public const string FisherRocPlusEthernetMeters = "fisher_rocplus_ethernet_meters";
    public const string OmniMeters = "omni_meters";
}