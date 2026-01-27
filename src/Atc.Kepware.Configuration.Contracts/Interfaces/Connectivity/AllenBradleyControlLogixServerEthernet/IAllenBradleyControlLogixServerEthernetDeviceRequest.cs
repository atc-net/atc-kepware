namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyControlLogixServerEthernet;

public interface IAllenBradleyControlLogixServerEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Specify whether the controller module should be treated as local to or remote to the simulated EtherNet/IP module.
    /// </summary>
    ControlLogixServerModuleType ModuleType { get; set; }

    /// <summary>
    /// Specify the CPU slot of this remote controller module.
    /// </summary>
    /// <remarks>
    /// Only applicable when ModuleType is Remote. Range: 0-15.
    /// </remarks>
    int CpuSlot { get; set; }

    /// <summary>
    /// Indicate if the automatically generated client tags should be grouped like RSLogix (Expanded) or more according to the tag address (Condensed).
    /// </summary>
    ControlLogixServerTagHierarchyType TagHierarchy { get; set; }

    /// <summary>
    /// Enable or disable displaying tags as bad quality until the first write is issued to obtain valid quality status.
    /// </summary>
    bool OpcQualityBadUntilWrite { get; set; }

    /// <summary>
    /// Select Enable if byte array elements may be in packed format. Select Disable to display only the low byte of each element.
    /// </summary>
    bool PackStrings { get; set; }
}
