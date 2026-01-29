// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The community for the tags that are not pre-configured in the driver for Allen-Bradley Bulletin 1609.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20Bulletin%201609/Devices
/// Section: a-b_bulletin_1609.DEVICE_COMMUNITY
/// </remarks>
public enum Bulletin1609CommunityType
{
    Private = 0,
    Public = 1,
    Custom = 3,
}
