namespace Atc.Kepware.Configuration.CLI.Extensions;

public static class CommandAppExtensions
{
    public static void ConfigureCommands(this CommandApp<RootCommand> app)
    {
        ArgumentNullException.ThrowIfNull(app);

        app.Configure(config =>
        {
            config.AddBranch("connectivity", ConfigureConnectivityCommands());
            config.AddBranch("iot-gateway", ConfigureIotGatewayCommands());
        });
    }

    private static Action<IConfigurator<CommandSettings>> ConfigureConnectivityCommands()
        => node =>
        {
            node.AddBranch("channels", ConfigureChannelsCommands());
            node.AddBranch("devices", ConfigureDevicesCommands());
            node.AddBranch("tags", ConfigureTagsCommands());
        };

    private static Action<IConfigurator<CommandSettings>> ConfigureChannelsCommands()
        => node =>
        {
            node.SetDescription("Commands for channels");

            ConfigureChannelGetCommands(node);

            ConfigureChannelCreateCommands(node);

            node
                .AddCommand<ChannelDeleteCommand>("delete")
                .WithDescription("Delete channel");
        };

    private static void ConfigureChannelGetCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("get", get =>
        {
            get.SetDescription("Operations related to retrieving channels.");

            get.AddCommand<ChannelsGetCommand>("all")
                .WithDescription("Retrieve all channels")
                .WithExample("connectivity channels get all");

            get.AddCommand<ChannelGetEuroMap63Command>("euromap63")
                .WithDescription("Get a EuroMap63 channel.")
                .WithExample("connectivity channels get euromap63 -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Get a OPC UA Client channel.")
                .WithExample("connectivity channels get opcuaclient -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetModbusTcpIpEthernetCommand>("modbustcpipethernet")
                .WithDescription("Get a Modbus TCP/IP Ethernet channel.")
                .WithExample("connectivity channels get modbustcpipethernet -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetAllenBradleyControlLogixEthernetCommand>("allenbradleycontrollogixethernet")
                .WithDescription("Get an Allen-Bradley ControlLogix Ethernet channel.")
                .WithExample("connectivity channels get allenbradleycontrollogixethernet -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetAllenBradleyEthernetCommand>("allenbradleyethernet")
                .WithDescription("Get an Allen-Bradley Ethernet channel.")
                .WithExample("connectivity channels get allenbradleyethernet -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetSiemensTcpIpEthernetCommand>("siemenstcpipethernet")
                .WithDescription("Get a Siemens TCP/IP Ethernet channel.")
                .WithExample("connectivity channels get siemenstcpipethernet -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetSiemensS7PlusEthernetCommand>("siemenss7plusethernet")
                .WithDescription("Get a Siemens S7 Plus Ethernet channel.")
                .WithExample("connectivity channels get siemenss7plusethernet -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetOpcDaClientCommand>("opcdaclient")
                .WithDescription("Get an OPC DA Client channel.")
                .WithExample("connectivity channels get opcdaclient -s [server-url] --name [channelName]");

            get.AddCommand<ChannelGetOmronFinsEthernetCommand>("omronfinsethernet")
                .WithDescription("Get an Omron FINS Ethernet channel.")
                .WithExample("connectivity channels get omronfinsethernet -s [server-url] --name [channelName]");

            ConfigureChannelGetCommandsExtended(get);
        });

    private static void ConfigureChannelGetCommandsExtended(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetMitsubishiEthernetCommand>("mitsubishiethernet")
            .WithDescription("Get a Mitsubishi Ethernet channel.")
            .WithExample("connectivity channels get mitsubishiethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetBacNetIpCommand>("bacnetip")
            .WithDescription("Get a BACnet/IP channel.")
            .WithExample("connectivity channels get bacnetip -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetMqttClientCommand>("mqttclient")
            .WithDescription("Get an MQTT Client channel.")
            .WithExample("connectivity channels get mqttclient -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetDnpClientEthernetCommand>("dnpclientethernet")
            .WithDescription("Get a DNP Client Ethernet channel.")
            .WithExample("connectivity channels get dnpclientethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAllenBradleyControlLogixServerEthernetCommand>("allenbradleycontrollogixserverethernet")
            .WithDescription("Get an Allen-Bradley ControlLogix Server Ethernet channel.")
            .WithExample("connectivity channels get allenbradleycontrollogixserverethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAllenBradleyMicro800EthernetCommand>("allenbradleymicro800ethernet")
            .WithDescription("Get an Allen-Bradley Micro800 Ethernet channel.")
            .WithExample("connectivity channels get allenbradleymicro800ethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAllenBradleyServerEthernetCommand>("allenbradleyserverethernet")
            .WithDescription("Get an Allen-Bradley Server Ethernet channel.")
            .WithExample("connectivity channels get allenbradleyserverethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetSiemensTcpIpServerEthernetCommand>("siemenstcpipserverethernet")
            .WithDescription("Get a Siemens TCP/IP Server Ethernet channel.")
            .WithExample("connectivity channels get siemenstcpipserverethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetMitsubishiCncEthernetCommand>("mitsubishicncethernet")
            .WithDescription("Get a Mitsubishi CNC Ethernet channel.")
            .WithExample("connectivity channels get mitsubishicncethernet -s [server-url] --name [channelName]");
    }

    private static void ConfigureChannelCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating channels.");
            create.AddCommand<ChannelCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 channel (if not exists).")
                .WithExample("connectivity channels create euromap63 -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client channel (if not exists).")
                .WithExample("connectivity channels create opcuaclient -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateModbusTcpIpEthernetCommand>("modbustcpipethernet")
                .WithDescription("Creates a Modbus TCP/IP Ethernet channel (if not exists).")
                .WithExample("connectivity channels create modbustcpipethernet -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateAllenBradleyControlLogixEthernetCommand>("allenbradleycontrollogixethernet")
                .WithDescription("Creates an Allen-Bradley ControlLogix Ethernet channel (if not exists).")
                .WithExample("connectivity channels create allenbradleycontrollogixethernet -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateAllenBradleyEthernetCommand>("allenbradleyethernet")
                .WithDescription("Creates an Allen-Bradley Ethernet channel (if not exists).")
                .WithExample("connectivity channels create allenbradleyethernet -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateSiemensTcpIpEthernetCommand>("siemenstcpipethernet")
                .WithDescription("Creates a Siemens TCP/IP Ethernet channel (if not exists).")
                .WithExample("connectivity channels create siemenstcpipethernet -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateSiemensS7PlusEthernetCommand>("siemenss7plusethernet")
                .WithDescription("Creates a Siemens S7 Plus Ethernet channel (if not exists).")
                .WithExample("connectivity channels create siemenss7plusethernet -s [server-url] --name [channelName] --description [description]");

            create.AddCommand<ChannelCreateOpcDaClientCommand>("opcdaclient")
                .WithDescription("Creates an OPC DA Client channel (if not exists).")
                .WithExample("connectivity channels create opcdaclient -s [server-url] --name [channelName] --program-id [programId]");

            create.AddCommand<ChannelCreateOmronFinsEthernetCommand>("omronfinsethernet")
                .WithDescription("Creates an Omron FINS Ethernet channel (if not exists).")
                .WithExample("connectivity channels create omronfinsethernet -s [server-url] --name [channelName] --description [description]");

            ConfigureChannelCreateCommandsExtended(create);
        });

    private static void ConfigureChannelCreateCommandsExtended(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateMitsubishiEthernetCommand>("mitsubishiethernet")
            .WithDescription("Creates a Mitsubishi Ethernet channel (if not exists).")
            .WithExample("connectivity channels create mitsubishiethernet -s [server-url] --name [channelName] --description [description]");

        create.AddCommand<ChannelCreateBacNetIpCommand>("bacnetip")
            .WithDescription("Creates a BACnet/IP channel (if not exists).")
            .WithExample("connectivity channels create bacnetip -s [server-url] --name [channelName] --description [description]");

        create.AddCommand<ChannelCreateMqttClientCommand>("mqttclient")
            .WithDescription("Creates an MQTT Client channel (if not exists).")
            .WithExample("connectivity channels create mqttclient -s [server-url] --name [channelName] --host [host] --port [port]");

        create.AddCommand<ChannelCreateDnpClientEthernetCommand>("dnpclientethernet")
            .WithDescription("Creates a DNP Client Ethernet channel (if not exists).")
            .WithExample("connectivity channels create dnpclientethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateAllenBradleyControlLogixServerEthernetCommand>("allenbradleycontrollogixserverethernet")
            .WithDescription("Creates an Allen-Bradley ControlLogix Server Ethernet channel (if not exists).")
            .WithExample("connectivity channels create allenbradleycontrollogixserverethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateAllenBradleyMicro800EthernetCommand>("allenbradleymicro800ethernet")
            .WithDescription("Creates an Allen-Bradley Micro800 Ethernet channel (if not exists).")
            .WithExample("connectivity channels create allenbradleymicro800ethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateAllenBradleyServerEthernetCommand>("allenbradleyserverethernet")
            .WithDescription("Creates an Allen-Bradley Server Ethernet channel (if not exists).")
            .WithExample("connectivity channels create allenbradleyserverethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateSiemensTcpIpServerEthernetCommand>("siemenstcpipserverethernet")
            .WithDescription("Creates a Siemens TCP/IP Server Ethernet channel (if not exists).")
            .WithExample("connectivity channels create siemenstcpipserverethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateMitsubishiCncEthernetCommand>("mitsubishicncethernet")
            .WithDescription("Creates a Mitsubishi CNC Ethernet channel (if not exists).")
            .WithExample("connectivity channels create mitsubishicncethernet -s [server-url] --name [channelName]");
    }

    private static Action<IConfigurator<CommandSettings>> ConfigureDevicesCommands()
        => node =>
        {
            node.SetDescription("Commands for devices");

            ConfigureDeviceGetCommands(node);

            ConfigureDeviceCreateCommands(node);

            node
                .AddCommand<DeviceDeleteCommand>("delete")
                .WithDescription("Delete device from channel");
        };

    private static void ConfigureDeviceGetCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("get", get =>
        {
            get.SetDescription("Operations related to retrieving devices.");

            get
                .AddCommand<DevicesGetByChannelCommand>("all")
                .WithDescription("Retrieve all devices by channel-name")
                .WithExample("connectivity devices get all -s [server-url] --channel-name [channelName]");

            get.AddCommand<DeviceGetEuroMap63Command>("euromap63")
                .WithDescription("Get a EuroMap63 device.")
                .WithExample("connectivity devices get euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Get a OPC UA Client device.")
                .WithExample("connectivity devices get opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetModbusTcpIpEthernetCommand>("modbustcpipethernet")
                .WithDescription("Get a Modbus TCP/IP Ethernet device.")
                .WithExample("connectivity devices get modbustcpipethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetAllenBradleyControlLogixEthernetCommand>("allenbradleycontrollogixethernet")
                .WithDescription("Get an Allen-Bradley ControlLogix Ethernet device.")
                .WithExample("connectivity devices get allenbradleycontrollogixethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetAllenBradleyEthernetCommand>("allenbradleyethernet")
                .WithDescription("Get an Allen-Bradley Ethernet device.")
                .WithExample("connectivity devices get allenbradleyethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetSiemensTcpIpEthernetCommand>("siemenstcpipethernet")
                .WithDescription("Get a Siemens TCP/IP Ethernet device.")
                .WithExample("connectivity devices get siemenstcpipethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetSiemensS7PlusEthernetCommand>("siemenss7plusethernet")
                .WithDescription("Get a Siemens S7 Plus Ethernet device.")
                .WithExample("connectivity devices get siemenss7plusethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetOpcDaClientCommand>("opcdaclient")
                .WithDescription("Get an OPC DA Client device.")
                .WithExample("connectivity devices get opcdaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetOmronFinsEthernetCommand>("omronfinsethernet")
                .WithDescription("Get an Omron FINS Ethernet device.")
                .WithExample("connectivity devices get omronfinsethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            ConfigureDeviceGetCommandsExtended(get);
        });

    private static void ConfigureDeviceGetCommandsExtended(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetMitsubishiEthernetCommand>("mitsubishiethernet")
            .WithDescription("Get a Mitsubishi Ethernet device.")
            .WithExample("connectivity devices get mitsubishiethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetBacNetIpCommand>("bacnetip")
            .WithDescription("Get a BACnet/IP device.")
            .WithExample("connectivity devices get bacnetip -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetMqttClientCommand>("mqttclient")
            .WithDescription("Get an MQTT Client device.")
            .WithExample("connectivity devices get mqttclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetDnpClientEthernetCommand>("dnpclientethernet")
            .WithDescription("Get a DNP Client Ethernet device.")
            .WithExample("connectivity devices get dnpclientethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAllenBradleyControlLogixServerEthernetCommand>("allenbradleycontrollogixserverethernet")
            .WithDescription("Get an Allen-Bradley ControlLogix Server Ethernet device.")
            .WithExample("connectivity devices get allenbradleycontrollogixserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAllenBradleyMicro800EthernetCommand>("allenbradleymicro800ethernet")
            .WithDescription("Get an Allen-Bradley Micro800 Ethernet device.")
            .WithExample("connectivity devices get allenbradleymicro800ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAllenBradleyServerEthernetCommand>("allenbradleyserverethernet")
            .WithDescription("Get an Allen-Bradley Server Ethernet device.")
            .WithExample("connectivity devices get allenbradleyserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetSiemensTcpIpServerEthernetCommand>("siemenstcpipserverethernet")
            .WithDescription("Get a Siemens TCP/IP Server Ethernet device.")
            .WithExample("connectivity devices get siemenstcpipserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetMitsubishiCncEthernetCommand>("mitsubishicncethernet")
            .WithDescription("Get a Mitsubishi CNC Ethernet device.")
            .WithExample("connectivity devices get mitsubishicncethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");
    }

    private static void ConfigureDeviceCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating devices.");

            create.AddCommand<DeviceCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 device (if not exists).")
                .WithExample("connectivity devices create euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName] --description [description] --session-file-path [filePath]");

            create.AddCommand<DeviceCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client device (if not exists).")
                .WithExample("connectivity devices create opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName] --description [description] ");

            create.AddCommand<DeviceCreateModbusTcpIpEthernetCommand>("modbustcpipethernet")
                .WithDescription("Creates a Modbus TCP/IP Ethernet device (if not exists).")
                .WithExample("connectivity devices create modbustcpipethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            create.AddCommand<DeviceCreateAllenBradleyControlLogixEthernetCommand>("allenbradleycontrollogixethernet")
                .WithDescription("Creates an Allen-Bradley ControlLogix Ethernet device (if not exists).")
                .WithExample("connectivity devices create allenbradleycontrollogixethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            create.AddCommand<DeviceCreateAllenBradleyEthernetCommand>("allenbradleyethernet")
                .WithDescription("Creates an Allen-Bradley Ethernet device (if not exists).")
                .WithExample("connectivity devices create allenbradleyethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            create.AddCommand<DeviceCreateSiemensTcpIpEthernetCommand>("siemenstcpipethernet")
                .WithDescription("Creates a Siemens TCP/IP Ethernet device (if not exists).")
                .WithExample("connectivity devices create siemenstcpipethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            create.AddCommand<DeviceCreateSiemensS7PlusEthernetCommand>("siemenss7plusethernet")
                .WithDescription("Creates a Siemens S7 Plus Ethernet device (if not exists).")
                .WithExample("connectivity devices create siemenss7plusethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            create.AddCommand<DeviceCreateOpcDaClientCommand>("opcdaclient")
                .WithDescription("Creates an OPC DA Client device (if not exists).")
                .WithExample("connectivity devices create opcdaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            create.AddCommand<DeviceCreateOmronFinsEthernetCommand>("omronfinsethernet")
                .WithDescription("Creates an Omron FINS Ethernet device (if not exists).")
                .WithExample("connectivity devices create omronfinsethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

            ConfigureDeviceCreateCommandsExtended(create);
        });

    private static void ConfigureDeviceCreateCommandsExtended(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateMitsubishiEthernetCommand>("mitsubishiethernet")
            .WithDescription("Creates a Mitsubishi Ethernet device (if not exists).")
            .WithExample("connectivity devices create mitsubishiethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateBacNetIpCommand>("bacnetip")
            .WithDescription("Creates a BACnet/IP device (if not exists).")
            .WithExample("connectivity devices create bacnetip -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateMqttClientCommand>("mqttclient")
            .WithDescription("Creates an MQTT Client device (if not exists).")
            .WithExample("connectivity devices create mqttclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateDnpClientEthernetCommand>("dnpclientethernet")
            .WithDescription("Creates a DNP Client Ethernet device (if not exists).")
            .WithExample("connectivity devices create dnpclientethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateAllenBradleyControlLogixServerEthernetCommand>("allenbradleycontrollogixserverethernet")
            .WithDescription("Creates an Allen-Bradley ControlLogix Server Ethernet device (if not exists).")
            .WithExample("connectivity devices create allenbradleycontrollogixserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateAllenBradleyMicro800EthernetCommand>("allenbradleymicro800ethernet")
            .WithDescription("Creates an Allen-Bradley Micro800 Ethernet device (if not exists).")
            .WithExample("connectivity devices create allenbradleymicro800ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateAllenBradleyServerEthernetCommand>("allenbradleyserverethernet")
            .WithDescription("Creates an Allen-Bradley Server Ethernet device (if not exists).")
            .WithExample("connectivity devices create allenbradleyserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateSiemensTcpIpServerEthernetCommand>("siemenstcpipserverethernet")
            .WithDescription("Creates a Siemens TCP/IP Server Ethernet device (if not exists).")
            .WithExample("connectivity devices create siemenstcpipserverethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateMitsubishiCncEthernetCommand>("mitsubishicncethernet")
            .WithDescription("Creates a Mitsubishi CNC Ethernet device (if not exists).")
            .WithExample("connectivity devices create mitsubishicncethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");
    }

    private static Action<IConfigurator<CommandSettings>> ConfigureTagsCommands()
        => node =>
        {
            node.SetDescription("Commands for tags");

            node
                .AddCommand<TagsGetCommand>("get")
                .WithDescription("Get tags for channel and device");

            ConfigureTagCreateCommands(node);
            ConfigureTagDeleteCommands(node);

            node
                .AddCommand<TagsSearchCommand>("search")
                .WithDescription("Search tags")
                .WithExample("connectivity tags search -s [server-url] --search MyTag")
                .WithExample("connectivity tags search -s [server-url] --search *Tag")
                .WithExample("connectivity tags search -s [server-url] --search My*")
                .WithExample("connectivity tags search -s [server-url] --search *yt*");
        };

    private static void ConfigureTagCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating tags and tag groups.");

            create.AddCommand<TagsCreateTagCommand>("tag")
                .WithDescription("Creates a tag (if not exists).")
                .WithExample("connectivity tags create tag -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagName] --address [tagAddress] --scan-rate [scanRate] --data-type [dataType] --client-access [clientAccess] --description [description]");

            create.AddCommand<TagsCreateTagGroupCommand>("taggroup")
                .WithDescription("Creates a tag group (if not exists).")
                .WithExample("connectivity tags create taggroup -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagGroupName] --description [description]");
        });

    private static void ConfigureTagDeleteCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("delete", create =>
        {
            create.SetDescription("Operations related to deleting tags and tag groups.");

            create.AddCommand<TagsDeleteTagCommand>("tag")
                .WithDescription("Delete a tag (if exists).")
                .WithExample("connectivity tags delete tag -s [server-url] --name [tagName]");

            create.AddCommand<TagsDeleteTagGroupCommand>("taggroup")
                .WithDescription("Deletes a tag group (if exists).")
                .WithExample("connectivity tags delete taggroup -s [server-url] --name [tagGroupName]");
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureIotGatewayCommands()
        => node =>
        {
            node.AddBranch("iot-agent", ConfigureIotAgentCommands());
            node.AddBranch("iot-item", ConfigureIotItemCommands());
        };

    private static Action<IConfigurator<CommandSettings>> ConfigureIotAgentCommands()
        => node =>
        {
            node.SetDescription("Commands for iot agents");

            ConfigureIotAgentMqttClientCommands(node);
            ConfigureIotAgentRestClientCommands(node);
            ConfigureIotAgentRestServerCommands(node);
        };

    private static void ConfigureIotAgentMqttClientCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("mqtt-client", mqttClient =>
        {
            mqttClient.SetDescription("Operations related to MQTT Client Iot Agents");

            mqttClient.AddCommand<IotAgentCreateMqttClientCommand>("create")
                .WithDescription("Create a mqtt-client iot agent (if not exists).")
                .WithExample("iot-gateway iot-agent mqtt-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]");

            mqttClient.AddCommand<IotAgentGetMqttClientCommand>("get")
                .WithDescription("Get a single mqtt-client iot agent.")
                .WithExample("iot-gateway iot-agent mqtt-client get -s [server-url] --name [iotAgentName]");

            mqttClient.AddCommand<IotAgentGetAllMqttClientsCommand>("all")
                .WithDescription("Get all mqtt-client iot agents.")
                .WithExample("iot-gateway iot-agent mqtt-client all -s [server-url]");

            mqttClient.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a mqtt-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent mqtt-client enable -s [server-url] --name [iotAgentName]");

            mqttClient.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a mqtt-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent mqtt-client disable -s [server-url] --name [iotAgentName]");

            mqttClient.AddCommand<IotAgentUpdateMqttClientCommand>("update")
                .WithDescription("Update a mqtt-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent mqtt-client update -s [server-url] --name [iotAgentName] --url [url]");

            mqttClient.AddCommand<IotAgentDeleteMqttClientCommand>("delete")
                .WithDescription("Delete a mqtt-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent mqtt-client delete -s [server-url] --name [iotAgentName]");
        });

    private static void ConfigureIotAgentRestClientCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-client", restClient =>
        {
            restClient.SetDescription("Operations related to Rest Client Iot Agents");

            restClient.AddCommand<IotAgentCreateRestClientCommand>("create")
                .WithDescription("Create a rest-client iot agent (if not exists).")
                .WithExample("iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]");

            restClient.AddCommand<IotAgentGetRestClientCommand>("get")
                .WithDescription("Get a single rest-client iot agent.")
                .WithExample("iot-gateway iot-agent rest-client get -s [server-url] --name [iotAgentName]");

            restClient.AddCommand<IotAgentGetAllRestClientsCommand>("all")
                .WithDescription("Get all rest-client iot agents.")
                .WithExample("iot-gateway iot-agent rest-client all -s [server-url]");

            restClient.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a rest-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-client enable -s [server-url] --name [iotAgentName]");

            restClient.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a rest-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-client disable -s [server-url] --name [iotAgentName]");

            restClient.AddCommand<IotAgentUpdateRestClientCommand>("update")
                .WithDescription("Update a rest-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-client update -s [server-url] --name [iotAgentName] --url [url]");

            restClient.AddCommand<IotAgentDeleteRestClientCommand>("delete")
                .WithDescription("Delete a rest-client iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-client delete -s [server-url] --name [iotAgentName]");
        });

    private static void ConfigureIotAgentRestServerCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-server", restServer =>
        {
            restServer.SetDescription("Operations related to Rest Server Iot Agents");

            restServer.AddCommand<IotAgentCreateRestServerCommand>("create")
                .WithDescription("Create a rest-server iot agent (if not exists).")
                .WithExample("iot-gateway iot-agent rest-server create -s [server-url] --name [iotAgentName] --url [url]");

            restServer.AddCommand<IotAgentGetRestServerCommand>("get")
                .WithDescription("Get a single rest-server iot agent.")
                .WithExample("iot-gateway iot-agent rest-server get -s [server-url] --name [iotAgentName]");

            restServer.AddCommand<IotAgentGetAllRestServersCommand>("all")
                .WithDescription("Get all rest-server iot agents.")
                .WithExample("iot-gateway iot-agent rest-server all -s [server-url]");

            restServer.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a rest-server iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-server enable -s [server-url] --name [iotAgentName]");

            restServer.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a rest-server iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-server disable -s [server-url] --name [iotAgentName]");

            restServer.AddCommand<IotAgentUpdateRestServerCommand>("update")
                .WithDescription("Update a rest-server iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-server update -s [server-url] --name [iotAgentName] --url [url]");

            restServer.AddCommand<IotAgentDeleteRestServerCommand>("delete")
                .WithDescription("Delete a rest-server iot agent (if exists).")
                .WithExample("iot-gateway iot-agent rest-server delete -s [server-url] --name [iotAgentName]");
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureIotItemCommands()
        => node =>
        {
            node.SetDescription("Commands for iot items");

            ConfigureIotItemMqttClientCommands(node);
            ConfigureIotItemRestClientCommands(node);
            ConfigureIotItemRestServerCommands(node);
        };

    private static void ConfigureIotItemMqttClientCommands(
    IConfigurator<CommandSettings> node)
    => node.AddBranch("mqtt-client", mqttClient =>
    {
        mqttClient.SetDescription("Operations related to MQTT Client Iot Agent Iot Items");

        mqttClient.AddCommand<MqttClientIotItemCreateCommand>("create")
            .WithDescription("Create one or more iot items on a mqtt-client iot agent.")
            .WithExample("iot-gateway iot-item mqtt-client create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]");

        mqttClient.AddCommand<IotItemGetCommand>("get")
            .WithDescription("Get a single mqtt-client iot agent iot item.")
            .WithExample("iot-gateway iot-item mqtt-client get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

        mqttClient.AddCommand<IotAgentGetAllIotItemsCommand>("all")
            .WithDescription("Get all mqtt-client iot agent iot items.")
            .WithExample("iot-gateway iot-item mqtt-client all -s [server-url]");

        mqttClient.AddCommand<IotItemEnableCommand>("enable")
            .WithDescription("Enable a single mqtt-client iot agent iot item.")
            .WithExample("iot-gateway iot-item mqtt-client enable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

        mqttClient.AddCommand<IotItemDisableCommand>("disable")
            .WithDescription("Disable a single mqtt-client iot agent iot item.")
            .WithExample("iot-gateway iot-item mqtt-client disable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

        mqttClient.AddCommand<MqttClientIotItemUpdateCommand>("update")
            .WithDescription("Update a mqtt-client iot agent iot item (if exists).")
            .WithExample("iot-gateway iot-item mqtt-client update -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

        mqttClient.AddCommand<IotItemDeleteCommand>("delete")
            .WithDescription("Delete a mqtt-client iot agent iot item (if exists).")
            .WithExample("iot-gateway iot-item mqtt-client delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");
    });

    private static void ConfigureIotItemRestClientCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-client", restClient =>
        {
            restClient.SetDescription("Operations related to Rest Client Iot Agent Iot Items");

            restClient.AddCommand<RestClientIotItemCreateCommand>("create")
                .WithDescription("Create an iot item on a rest-client iot agent.")
                .WithExample("iot-gateway iot-item rest-client create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]");

            restClient.AddCommand<IotItemGetCommand>("get")
                .WithDescription("Get a single rest-client iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-client get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restClient.AddCommand<IotAgentGetAllIotItemsCommand>("all")
                .WithDescription("Get all rest-client iot agent iot items.")
                .WithExample("iot-gateway iot-item rest-client all -s [server-url]");

            restClient.AddCommand<IotItemEnableCommand>("enable")
                .WithDescription("Enable a single rest-client iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-client enable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restClient.AddCommand<IotItemDisableCommand>("disable")
                .WithDescription("Disable a single rest-client iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-client disable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restClient.AddCommand<RestClientIotItemUpdateCommand>("update")
                .WithDescription("Update a rest-client iot agent iot item (if exists).")
                .WithExample("iot-gateway iot-item rest-client update -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restClient.AddCommand<IotItemDeleteCommand>("delete")
                .WithDescription("Delete a rest-client iot agent iot item (if exists).")
                .WithExample("iot-gateway iot-item rest-client delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");
        });

    private static void ConfigureIotItemRestServerCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-server", restServer =>
        {
            restServer.SetDescription("Operations related to Rest Server Iot Agent Iot Items");

            restServer.AddCommand<RestServerIotItemCreateCommand>("create")
                .WithDescription("Create one or more iot items on a rest-server iot agent.")
                .WithExample("iot-gateway iot-item rest-server create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]");

            restServer.AddCommand<IotItemGetCommand>("get")
                .WithDescription("Get a single rest-server iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-server get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restServer.AddCommand<IotAgentGetAllIotItemsCommand>("all")
                .WithDescription("Get all rest-server iot agent iot items.")
                .WithExample("iot-gateway iot-item rest-server all -s [server-url]");

            restServer.AddCommand<IotItemEnableCommand>("enable")
                .WithDescription("Enable a single rest-server iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-server enable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restServer.AddCommand<IotItemDisableCommand>("disable")
                .WithDescription("Disable a single rest-server iot agent iot item.")
                .WithExample("iot-gateway iot-item rest-server disable -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restServer.AddCommand<RestServerIotItemUpdateCommand>("update")
                .WithDescription("Update a rest-server iot agent iot item (if exists).")
                .WithExample("iot-gateway iot-item rest-server update -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");

            restServer.AddCommand<IotItemDeleteCommand>("delete")
                .WithDescription("Delete a rest-server iot agent iot item (if exists).")
                .WithExample("iot-gateway iot-item rest-server delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]");
        });
}