namespace Atc.Kepware.Configuration.Contracts.Drivers;

public enum DriverType
{
    None,

    [Description("EUROMAP 63")]
    EuroMap63,

    [Description("OPC UA Client")]
    OpcUaClient,
}