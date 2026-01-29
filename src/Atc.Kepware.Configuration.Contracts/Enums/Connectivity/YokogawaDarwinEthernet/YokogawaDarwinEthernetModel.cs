namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet device model.
/// </summary>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Model names contain hyphens that must be represented as underscores.")]
public enum YokogawaDarwinEthernetModel
{
    [Description("DA100-1")]
    Da100_1 = 0,

    [Description("DA100-2")]
    Da100_2 = 1,

    [Description("DR231")]
    Dr231 = 2,

    [Description("DR232")]
    Dr232 = 3,

    [Description("DR241")]
    Dr241 = 4,

    [Description("DR242")]
    Dr242 = 5,

    [Description("DR130")]
    Dr130 = 6,

    [Description("DC100-1")]
    Dc100_1 = 7,

    [Description("DC100-2")]
    Dc100_2 = 8,
}