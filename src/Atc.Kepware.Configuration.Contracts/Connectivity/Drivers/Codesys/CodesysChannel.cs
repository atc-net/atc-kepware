namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Codesys;

/// <summary>
/// Represents a CODESYS channel.
/// </summary>
public sealed class CodesysChannel : ChannelBase, ICodesysChannel
{
    /// <inheritdoc />
    public int KeepAliveMinutes { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(KeepAliveMinutes)}: {KeepAliveMinutes}";
}
