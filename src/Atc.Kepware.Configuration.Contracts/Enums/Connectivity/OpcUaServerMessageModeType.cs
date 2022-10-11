// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Select the type of encryption to use for messages between the driver and server.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/OPC%20UA%20Client/channels
/// Section: opcuaclient.CHANNEL_UA_SERVER_MESSAGE_MODE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "OK - By Design.")]
public enum OpcUaServerMessageModeType
{
    /// <summary>
    /// None.
    /// </summary>
    None = 1,

    /// <summary>
    /// Sign.
    /// </summary>
    Sign = 2,

    /// <summary>
    /// Sign and Encrypt.
    /// </summary>
    SignAndEncrypt = 3,
}