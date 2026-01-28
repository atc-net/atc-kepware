namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.MtConnectClient;

public interface IMtConnectClientChannel : IChannelBase
{
    string AgentUrl { get; set; }

    int Port { get; set; }

    int HttpTimeout { get; set; }

    int SampleInterval { get; set; }

    string ProbePath { get; set; }

    string CurrentPath { get; set; }

    string SamplePath { get; set; }
}
