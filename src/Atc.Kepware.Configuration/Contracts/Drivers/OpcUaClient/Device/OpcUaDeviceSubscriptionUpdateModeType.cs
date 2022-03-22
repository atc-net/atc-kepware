namespace Atc.Kepware.Configuration.Contracts.Drivers.OpcUaClient.Device;

/// <summary>
/// Select the subscription method.
/// Exception Mode updates subscription tags at the publishing interval if the data changes.
/// Poll Mode performs asynchronous reads on all subscription tags at the publishing interval.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/OPC%20UA%20Client/Devices
/// Section: opcuaclient.opcuaclient.DEVICE_SUBSCRIPTION_UPDATE_MODE
/// </remarks>
public enum OpcUaDeviceSubscriptionUpdateModeType
{
    /// <summary>
    /// Exception Mode updates subscription tags at the publishing interval if the data changes.
    /// </summary>
    Exception = 0,

    /// <summary>
    /// Poll Mode performs asynchronous reads on all subscription tags at the publishing interval.
    /// </summary>
    Poll = 1,
}