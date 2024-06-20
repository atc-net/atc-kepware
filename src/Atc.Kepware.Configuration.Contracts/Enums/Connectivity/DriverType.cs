// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

public enum DriverType
{
    None,

    [Description("EUROMAP 63")]
    EuroMap63,

    [Description("OPC UA Client")]
    OpcUaClient,

    [Description("Simulator")]
    Simulator,
}