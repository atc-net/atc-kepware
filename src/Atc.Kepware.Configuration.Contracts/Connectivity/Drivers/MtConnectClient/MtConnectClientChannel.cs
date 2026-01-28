namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

public sealed class MtConnectClientChannel : ChannelBase, IMtConnectClientChannel
{
    public string AgentUrl { get; set; } = string.Empty;

    public int Port { get; set; }

    public int HttpTimeout { get; set; }

    public int SampleInterval { get; set; }

    public string ProbePath { get; set; } = string.Empty;

    public string CurrentPath { get; set; } = string.Empty;

    public string SamplePath { get; set; } = string.Empty;
}
