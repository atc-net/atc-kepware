namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec61850MmsClient;

public sealed class Iec61850MmsClientChannel : ChannelBase, IIec61850MmsClientChannel
{
    public bool OptimizeMemoryAllocation { get; set; }
}