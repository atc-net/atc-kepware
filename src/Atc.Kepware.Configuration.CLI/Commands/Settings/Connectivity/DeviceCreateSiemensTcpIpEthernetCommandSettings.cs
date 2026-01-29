namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateSiemensTcpIpEthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--device-id <DEVICE-ID>")]
    [Description("Device IP address")]
    public string DeviceId { get; init; } = "255.255.255.255";

    [CommandOption("--model [MODEL]")]
    [Description("Device model (S7200, S7300, S7400, S71200, S71500, NetLinkS7300, NetLinkS7400)")]
    public FlagValue<SiemensTcpIpEthernetDeviceModelType>? Model { get; init; } = new();

    [CommandOption("--port")]
    [Description("Port number for device (0-65535)")]
    [DefaultValue(102)]
    public int Port { get; init; }

    [CommandOption("--mpi-id")]
    [Description("MPI ID for NetLink adapters (0-126)")]
    [DefaultValue(0)]
    public int MpiId { get; init; }

    [CommandOption("--max-pdu-size [MAX-PDU-SIZE]")]
    [Description("Maximum PDU size in bytes (Bytes240, Bytes480, Bytes960)")]
    public FlagValue<SiemensTcpIpEthernetMaxPduType>? MaxPduSize { get; init; } = new();

    [CommandOption("--local-tsap")]
    [Description("Local TSAP address in hexadecimal (0-65535)")]
    [DefaultValue(0x4D57)]
    public int LocalTsap { get; init; }

    [CommandOption("--remote-tsap")]
    [Description("Remote TSAP address in hexadecimal (0-65535)")]
    [DefaultValue(0x4D57)]
    public int RemoteTsap { get; init; }

    [CommandOption("--link-type [LINK-TYPE]")]
    [Description("Link type for S7-300/400/1200/1500 (PG, OP, PC)")]
    public FlagValue<SiemensTcpIpEthernetLinkType>? LinkType { get; init; } = new();

    [CommandOption("--cpu-rack")]
    [Description("CPU rack number (0-7)")]
    [DefaultValue(0)]
    public int CpuRack { get; init; }

    [CommandOption("--cpu-slot")]
    [Description("CPU slot number (1-31)")]
    [DefaultValue(2)]
    public int CpuSlot { get; init; }

    [CommandOption("--byte-order [BYTE-ORDER]")]
    [Description("Byte order for 16/32-bit values (BigEndian, LittleEndian)")]
    public FlagValue<SiemensTcpIpEthernetByteOrderType>? ByteOrder { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(DeviceId))
        {
            return ValidationResult.Error("--device-id is required.");
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (MpiId < 0 || MpiId > 126)
        {
            return ValidationResult.Error("--mpi-id must be between 0 and 126.");
        }

        if (LocalTsap < 0 || LocalTsap > 65535)
        {
            return ValidationResult.Error("--local-tsap must be between 0 and 65535.");
        }

        if (RemoteTsap < 0 || RemoteTsap > 65535)
        {
            return ValidationResult.Error("--remote-tsap must be between 0 and 65535.");
        }

        if (CpuRack < 0 || CpuRack > 7)
        {
            return ValidationResult.Error("--cpu-rack must be between 0 and 7.");
        }

        if (CpuSlot < 1 || CpuSlot > 31)
        {
            return ValidationResult.Error("--cpu-slot must be between 1 and 31.");
        }

        return ValidationResult.Success();
    }
}