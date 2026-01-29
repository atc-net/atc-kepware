namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec61850MmsClient;

public interface IIec61850MmsClientChannel : IChannelBase
{
    /// <summary>
    /// Enable to allocate only the memory needed for the channel.
    /// </summary>
    bool OptimizeMemoryAllocation { get; set; }
}