namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMitsubishiFxNetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--model")]
    [Description("Device model (Fx, Fx2C, Fx0N, Fx2N, FxOpen, Fx3U)")]
    [DefaultValue(MitsubishiFxNetModel.Fx)]
    public MitsubishiFxNetModel Model { get; init; } = MitsubishiFxNetModel.Fx;
}
