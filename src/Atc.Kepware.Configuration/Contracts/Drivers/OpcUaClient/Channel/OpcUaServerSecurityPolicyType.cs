namespace Atc.Kepware.Configuration.Contracts.Drivers.OpcUaClient.Channel;

/// <summary>
/// Select the endpoint security policy.
/// Note that Basic128Rsa15 and Basic256 have been deprecated by the OPC Foundation
/// and are no longer considered to be secure.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/OPC%20UA%20Client/channels
/// Section: opcuaclient.CHANNEL_UA_SERVER_SECURITY_POLICY
/// </remarks>
public enum OpcUaServerSecurityPolicyType
{
    /// <summary>
    /// None.
    /// </summary>
    None = 0,

    /// <summary>
    /// Basic128Rsa15 - Deprecated.
    /// </summary>
    Basic128Rsa15 = 1,

    /// <summary>
    /// Basic256 - Deprecated.
    /// </summary>
    Basic256 = 2,

    /// <summary>
    /// Basic256Sha256.
    /// </summary>
    Basic256Sha256 = 3,
}