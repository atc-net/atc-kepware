namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet device model.
/// </summary>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Model names contain numeric identifiers that benefit from separation.")]
public enum GeEthernetModel
{
    /// <summary>
    /// 9030 - 311 model.
    /// </summary>
    [Description("9030 - 311")]
    Model9030_311 = 0,

    /// <summary>
    /// 9030 - 313 model.
    /// </summary>
    [Description("9030 - 313")]
    Model9030_313 = 1,

    /// <summary>
    /// 9030 - 331 model.
    /// </summary>
    [Description("9030 - 331")]
    Model9030_331 = 2,

    /// <summary>
    /// 9030 - 341 model.
    /// </summary>
    [Description("9030 - 341")]
    Model9030_341 = 3,

    /// <summary>
    /// 9030 - 350 model.
    /// </summary>
    [Description("9030 - 350")]
    Model9030_350 = 4,

    /// <summary>
    /// 9030 - 360 model.
    /// </summary>
    [Description("9030 - 360")]
    Model9030_360 = 5,

    /// <summary>
    /// 9070 - 731 model.
    /// </summary>
    [Description("9070 - 731")]
    Model9070_731 = 6,

    /// <summary>
    /// 9070 - 732 model.
    /// </summary>
    [Description("9070 - 732")]
    Model9070_732 = 7,

    /// <summary>
    /// 9070 - 771 model.
    /// </summary>
    [Description("9070 - 771")]
    Model9070_771 = 8,

    /// <summary>
    /// 9070 - 772 model.
    /// </summary>
    [Description("9070 - 772")]
    Model9070_772 = 9,

    /// <summary>
    /// 9070 - 781 model.
    /// </summary>
    [Description("9070 - 781")]
    Model9070_781 = 10,

    /// <summary>
    /// 9070 - 782 model.
    /// </summary>
    [Description("9070 - 782")]
    Model9070_782 = 11,

    /// <summary>
    /// GE OPEN model.
    /// </summary>
    [Description("GE OPEN")]
    GeOpen = 12,

    /// <summary>
    /// Horner OCS model.
    /// </summary>
    [Description("Horner OCS")]
    HornerOcs = 13,

    /// <summary>
    /// PACSystems model.
    /// </summary>
    [Description("PACSystems")]
    PacSystems = 14,

    /// <summary>
    /// VersaMax model.
    /// </summary>
    [Description("VersaMax")]
    VersaMax = 15,
}
