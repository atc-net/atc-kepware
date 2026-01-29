// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// The specific type of device model for Allen-Bradley ControlLogix Ethernet.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Allen-Bradley%20ControlLogix%20Ethernet/Devices
/// Section: servermain.DEVICE_MODEL
/// </remarks>
public enum ControlLogixDeviceModelType
{
    ControlLogix5500 = 0,
    CompactLogix5300 = 1,
    FlexLogix5400 = 2,
    SoftLogix5800 = 3,
    DhPlusGatewayPlc5 = 4,
    DhPlusGatewaySlc504 = 5,
    ControlNetGatewayPlc5C = 6,
    EipGatewayMicroLogix = 7,
    EipGatewaySlcFixed = 8,
    EipGatewaySlcModular = 9,
    EipGatewayPlc5 = 10,
    SerialGatewayControlLogix = 11,
    SerialGatewayCompactLogix = 12,
    SerialGatewayFlexLogix = 13,
    SerialGatewaySoftLogix = 14,
    EniControlLogix5500 = 15,
    EniCompactLogix5300 = 16,
    EniFlexLogix5400 = 17,
    EniMicroLogix = 18,
    EniSlc500FixedIO = 19,
    EniSlc500ModularIO = 20,
    EniPlc5 = 21,
    MicroLogix1100 = 22,
    MicroLogix1400 = 23,
}