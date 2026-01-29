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
        get.AddCommand<ChannelGetAromatEthernetCommand>("aromatethernet")
            .WithDescription("Get an Aromat Ethernet channel.")
            .WithExample("connectivity channels get aromatethernet -s [server-url] --name [channelName]");

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

        get.AddCommand<ChannelGetMitsubishiFxNetCommand>("mitsubishifxnet")
            .WithDescription("Get a Mitsubishi FX Net channel.")
            .WithExample("connectivity channels get mitsubishifxnet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetGeEthernetCommand>("geethernet")
            .WithDescription("Get a GE Ethernet channel.")
            .WithExample("connectivity channels get geethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetGeEthernetGlobalDataCommand>("geethernetglobaldata")
            .WithDescription("Get a GE Ethernet Global Data channel.")
            .WithExample("connectivity channels get geethernetglobaldata -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetOmronNjEthernetCommand>("omronnjethernet")
            .WithDescription("Get an Omron NJ Ethernet channel.")
            .WithExample("connectivity channels get omronnjethernet -s [server-url] --name [channelName]");

        ConfigureChannelGetIecCommands(get);
    }

    private static void ConfigureChannelGetIecCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetIec608705104ClientCommand>("iec608705104client")
            .WithDescription("Get an IEC 60870-5-104 Client channel.")
            .WithExample("connectivity channels get iec608705104client -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetIec61850MmsClientCommand>("iec61850mmsclient")
            .WithDescription("Get an IEC 61850 MMS Client channel.")
            .WithExample("connectivity channels get iec61850mmsclient -s [server-url] --name [channelName]");

        ConfigureChannelGetYokogawaCommands(get);
    }

    private static void ConfigureChannelGetYokogawaCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetYokogawaCxEthernetCommand>("yokogawacxethernet")
            .WithDescription("Get a Yokogawa CX Ethernet channel.")
            .WithExample("connectivity channels get yokogawacxethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaDarwinEthernetCommand>("yokogawadarwinethernet")
            .WithDescription("Get a Yokogawa Darwin Ethernet channel.")
            .WithExample("connectivity channels get yokogawadarwinethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaDxEthernetCommand>("yokogawadxethernet")
            .WithDescription("Get a Yokogawa DX Ethernet channel.")
            .WithExample("connectivity channels get yokogawadxethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaDxpEthernetCommand>("yokogawadxpethernet")
            .WithDescription("Get a Yokogawa DXP Ethernet channel.")
            .WithExample("connectivity channels get yokogawadxpethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaMwEthernetCommand>("yokogawamwethernet")
            .WithDescription("Get a Yokogawa MW Ethernet channel.")
            .WithExample("connectivity channels get yokogawamwethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaGxEthernetCommand>("yokogawagxethernet")
            .WithDescription("Get a Yokogawa GX Ethernet channel.")
            .WithExample("connectivity channels get yokogawagxethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYokogawaMxEthernetCommand>("yokogawamxethernet")
            .WithDescription("Get a Yokogawa MX Ethernet channel.")
            .WithExample("connectivity channels get yokogawamxethernet -s [server-url] --name [channelName]");

        ConfigureChannelGetAutomationDirectCommands(get);
    }

    private static void ConfigureChannelGetAutomationDirectCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetAutomationDirectProductivitySeriesEthernetCommand>("automationdirectproductivityseriesethernet")
            .WithDescription("Get an AutomationDirect Productivity Series Ethernet channel.")
            .WithExample("connectivity channels get automationdirectproductivityseriesethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAutomationDirectEbcCommand>("automationdirectebc")
            .WithDescription("Get an AutomationDirect EBC channel.")
            .WithExample("connectivity channels get automationdirectebc -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAutomationDirectEcomCommand>("automationdirectecom")
            .WithDescription("Get an AutomationDirect ECOM channel.")
            .WithExample("connectivity channels get automationdirectecom -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetAlstomRedundantEthernetCommand>("alstomredundantethernet")
            .WithDescription("Get an Alstom Redundant Ethernet channel.")
            .WithExample("connectivity channels get alstomredundantethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetBeckhoffTwinCatCommand>("beckhofftwincat")
            .WithDescription("Get a Beckhoff TwinCAT channel.")
            .WithExample("connectivity channels get beckhofftwincat -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetBristolBsapIpCommand>("bristolbsapip")
            .WithDescription("Get a Bristol BSAP IP channel.")
            .WithExample("connectivity channels get bristolbsapip -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetBuswareEthernetCommand>("buswareethernet")
            .WithDescription("Get a Busware Ethernet channel.")
            .WithExample("connectivity channels get buswareethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetHoneywellHc900EthernetCommand>("honeywellhc900ethernet")
            .WithDescription("Get a Honeywell HC900 Ethernet channel.")
            .WithExample("connectivity channels get honeywellhc900ethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetFanucFocasEthernetCommand>("fanucfocasethernet")
            .WithDescription("Get a Fanuc Focas Ethernet channel.")
            .WithExample("connectivity channels get fanucfocasethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetHoneywellUdcEthernetCommand>("honeywelludcethernet")
            .WithDescription("Get a Honeywell UDC Ethernet channel.")
            .WithExample("connectivity channels get honeywelludcethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetCutlerHammerElcEthernetCommand>("cutlerhammerelcethernet")
            .WithDescription("Get a Cutler-Hammer ELC Ethernet channel.")
            .WithExample("connectivity channels get cutlerhammerelcethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetCodesysCommand>("codesys")
            .WithDescription("Get a CODESYS channel.")
            .WithExample("connectivity channels get codesys -s [server-url] --name [channelName]");

        ConfigureChannelGetKToYCommands(get);
    }

    private static void ConfigureChannelGetKToYCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetKeyenceKvEthernetCommand>("keyencekvethernet")
            .WithDescription("Get a Keyence KV Ethernet channel.")
            .WithExample("connectivity channels get keyencekvethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetKraussMaffeiMc4EthernetCommand>("kraussmaffeimc4ethernet")
            .WithDescription("Get a KraussMaffei MC4 Ethernet channel.")
            .WithExample("connectivity channels get kraussmaffeimc4ethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetMtConnectClientCommand>("mtconnectclient")
            .WithDescription("Get an MTConnect Client channel.")
            .WithExample("connectivity channels get mtconnectclient -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetOpcXmlDaClientCommand>("opcxmldaclient")
            .WithDescription("Get an OPC XML-DA Client channel.")
            .WithExample("connectivity channels get opcxmldaclient -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetOpto22EthernetCommand>("opto22ethernet")
            .WithDescription("Get an Opto 22 Ethernet channel.")
            .WithExample("connectivity channels get opto22ethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetSattBusEthernetCommand>("sattbusethernet")
            .WithDescription("Get a SattBus Ethernet channel.")
            .WithExample("connectivity channels get sattbusethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetScanivalveEthernetCommand>("scanivalveethernet")
            .WithDescription("Get a Scanivalve Ethernet channel.")
            .WithExample("connectivity channels get scanivalveethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetSimaticTi505EthernetCommand>("simaticti505ethernet")
            .WithDescription("Get a Simatic/TI 505 Ethernet channel.")
            .WithExample("connectivity channels get simaticti505ethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetSixnetEthertrakCommand>("sixnetethertrak")
            .WithDescription("Get a SIXNET EtherTRAK channel.")
            .WithExample("connectivity channels get sixnetethertrak -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetSnmpCommand>("snmp")
            .WithDescription("Get an SNMP channel.")
            .WithExample("connectivity channels get snmp -s [server-url] --name [channelName]");

        ConfigureChannelGetTToYCommands(get);
    }

    private static void ConfigureChannelGetTToYCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<ChannelGetThermoWestronicsEthernetCommand>("thermowestronicsethernet")
            .WithDescription("Get a Thermo Westronics Ethernet channel.")
            .WithExample("connectivity channels get thermowestronicsethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetTorqueToolEthernetCommand>("torquetoolethernet")
            .WithDescription("Get a Torque Tool Ethernet channel.")
            .WithExample("connectivity channels get torquetoolethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetToshibaEthernetCommand>("toshibaethernet")
            .WithDescription("Get a Toshiba Ethernet channel.")
            .WithExample("connectivity channels get toshibaethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetToyopucEthernetCommand>("toyopucethernet")
            .WithDescription("Get a Toyopuc PC3/PC2 Ethernet channel.")
            .WithExample("connectivity channels get toyopucethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetTriconexEthernetCommand>("triconexethernet")
            .WithDescription("Get a Triconex Ethernet channel.")
            .WithExample("connectivity channels get triconexethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetWagoEthernetCommand>("wagoethernet")
            .WithDescription("Get a Wago Ethernet channel.")
            .WithExample("connectivity channels get wagoethernet -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetWonderwareIntouchClientCommand>("wonderwareintouchclient")
            .WithDescription("Get a Wonderware InTouch Client channel.")
            .WithExample("connectivity channels get wonderwareintouchclient -s [server-url] --name [channelName]");

        get.AddCommand<ChannelGetYaskawaMpSeriesEthernetCommand>("yaskawampseriesethernet")
            .WithDescription("Get a Yaskawa MP Series Ethernet channel.")
            .WithExample("connectivity channels get yaskawampseriesethernet -s [server-url] --name [channelName]");
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
        create.AddCommand<ChannelCreateAromatEthernetCommand>("aromatethernet")
            .WithDescription("Creates an Aromat Ethernet channel (if not exists).")
            .WithExample("connectivity channels create aromatethernet -s [server-url] --name [channelName]");

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

        create.AddCommand<ChannelCreateMitsubishiFxNetCommand>("mitsubishifxnet")
            .WithDescription("Creates a Mitsubishi FX Net channel (if not exists).")
            .WithExample("connectivity channels create mitsubishifxnet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateGeEthernetCommand>("geethernet")
            .WithDescription("Creates a GE Ethernet channel (if not exists).")
            .WithExample("connectivity channels create geethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateGeEthernetGlobalDataCommand>("geethernetglobaldata")
            .WithDescription("Creates a GE Ethernet Global Data channel (if not exists).")
            .WithExample("connectivity channels create geethernetglobaldata -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateOmronNjEthernetCommand>("omronnjethernet")
            .WithDescription("Creates an Omron NJ Ethernet channel (if not exists).")
            .WithExample("connectivity channels create omronnjethernet -s [server-url] --name [channelName]");

        ConfigureChannelCreateIecCommands(create);
    }

    private static void ConfigureChannelCreateIecCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateIec608705104ClientCommand>("iec608705104client")
            .WithDescription("Creates an IEC 60870-5-104 Client channel (if not exists).")
            .WithExample("connectivity channels create iec608705104client -s [server-url] --name [channelName] --destination-host [host]");

        create.AddCommand<ChannelCreateIec61850MmsClientCommand>("iec61850mmsclient")
            .WithDescription("Creates an IEC 61850 MMS Client channel (if not exists).")
            .WithExample("connectivity channels create iec61850mmsclient -s [server-url] --name [channelName]");

        ConfigureChannelCreateYokogawaCommands(create);
    }

    private static void ConfigureChannelCreateYokogawaCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateYokogawaCxEthernetCommand>("yokogawacxethernet")
            .WithDescription("Creates a Yokogawa CX Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawacxethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaDarwinEthernetCommand>("yokogawadarwinethernet")
            .WithDescription("Creates a Yokogawa Darwin Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawadarwinethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaDxEthernetCommand>("yokogawadxethernet")
            .WithDescription("Creates a Yokogawa DX Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawadxethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaDxpEthernetCommand>("yokogawadxpethernet")
            .WithDescription("Creates a Yokogawa DXP Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawadxpethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaMwEthernetCommand>("yokogawamwethernet")
            .WithDescription("Creates a Yokogawa MW Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawamwethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaGxEthernetCommand>("yokogawagxethernet")
            .WithDescription("Creates a Yokogawa GX Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawagxethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYokogawaMxEthernetCommand>("yokogawamxethernet")
            .WithDescription("Creates a Yokogawa MX Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yokogawamxethernet -s [server-url] --name [channelName]");

        ConfigureChannelCreateAutomationDirectCommands(create);
    }

    private static void ConfigureChannelCreateAutomationDirectCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateAutomationDirectProductivitySeriesEthernetCommand>("automationdirectproductivityseriesethernet")
            .WithDescription("Creates an AutomationDirect Productivity Series Ethernet channel (if not exists).")
            .WithExample("connectivity channels create automationdirectproductivityseriesethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateAutomationDirectEbcCommand>("automationdirectebc")
            .WithDescription("Creates an AutomationDirect EBC channel (if not exists).")
            .WithExample("connectivity channels create automationdirectebc -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateAutomationDirectEcomCommand>("automationdirectecom")
            .WithDescription("Creates an AutomationDirect ECOM channel (if not exists).")
            .WithExample("connectivity channels create automationdirectecom -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateBeckhoffTwinCatCommand>("beckhofftwincat")
            .WithDescription("Creates a Beckhoff TwinCAT channel (if not exists).")
            .WithExample("connectivity channels create beckhofftwincat -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateBristolBsapIpCommand>("bristolbsapip")
            .WithDescription("Creates a Bristol BSAP IP channel (if not exists).")
            .WithExample("connectivity channels create bristolbsapip -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateBuswareEthernetCommand>("buswareethernet")
            .WithDescription("Creates a Busware Ethernet channel (if not exists).")
            .WithExample("connectivity channels create buswareethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateHoneywellHc900EthernetCommand>("honeywellhc900ethernet")
            .WithDescription("Creates a Honeywell HC900 Ethernet channel (if not exists).")
            .WithExample("connectivity channels create honeywellhc900ethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateFanucFocasEthernetCommand>("fanucfocasethernet")
            .WithDescription("Creates a Fanuc Focas Ethernet channel (if not exists).")
            .WithExample("connectivity channels create fanucfocasethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateHoneywellUdcEthernetCommand>("honeywelludcethernet")
            .WithDescription("Creates a Honeywell UDC Ethernet channel (if not exists).")
            .WithExample("connectivity channels create honeywelludcethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateCutlerHammerElcEthernetCommand>("cutlerhammerelcethernet")
            .WithDescription("Creates a Cutler-Hammer ELC Ethernet channel (if not exists).")
            .WithExample("connectivity channels create cutlerhammerelcethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateCodesysCommand>("codesys")
            .WithDescription("Creates a CODESYS channel (if not exists).")
            .WithExample("connectivity channels create codesys -s [server-url] --name [channelName]");

        ConfigureChannelCreateKToYCommands(create);
    }

    private static void ConfigureChannelCreateKToYCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateKeyenceKvEthernetCommand>("keyencekvethernet")
            .WithDescription("Creates a Keyence KV Ethernet channel (if not exists).")
            .WithExample("connectivity channels create keyencekvethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateSattBusEthernetCommand>("sattbusethernet")
            .WithDescription("Creates a SattBus Ethernet channel (if not exists).")
            .WithExample("connectivity channels create sattbusethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateScanivalveEthernetCommand>("scanivalveethernet")
            .WithDescription("Creates a Scanivalve Ethernet channel (if not exists).")
            .WithExample("connectivity channels create scanivalveethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateSimaticTi505EthernetCommand>("simaticti505ethernet")
            .WithDescription("Creates a Simatic/TI 505 Ethernet channel (if not exists).")
            .WithExample("connectivity channels create simaticti505ethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateSixnetEthertrakCommand>("sixnetethertrak")
            .WithDescription("Creates a SIXNET EtherTRAK channel (if not exists).")
            .WithExample("connectivity channels create sixnetethertrak -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateSnmpCommand>("snmp")
            .WithDescription("Creates an SNMP channel (if not exists).")
            .WithExample("connectivity channels create snmp -s [server-url] --name [channelName]");

        ConfigureChannelCreateTToYCommands(create);
    }

    private static void ConfigureChannelCreateTToYCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<ChannelCreateThermoWestronicsEthernetCommand>("thermowestronicsethernet")
            .WithDescription("Creates a Thermo Westronics Ethernet channel (if not exists).")
            .WithExample("connectivity channels create thermowestronicsethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateTorqueToolEthernetCommand>("torquetoolethernet")
            .WithDescription("Creates a Torque Tool Ethernet channel (if not exists).")
            .WithExample("connectivity channels create torquetoolethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateToshibaEthernetCommand>("toshibaethernet")
            .WithDescription("Creates a Toshiba Ethernet channel (if not exists).")
            .WithExample("connectivity channels create toshibaethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateToyopucEthernetCommand>("toyopucethernet")
            .WithDescription("Creates a Toyopuc PC3/PC2 Ethernet channel (if not exists).")
            .WithExample("connectivity channels create toyopucethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateTriconexEthernetCommand>("triconexethernet")
            .WithDescription("Creates a Triconex Ethernet channel (if not exists).")
            .WithExample("connectivity channels create triconexethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateWagoEthernetCommand>("wagoethernet")
            .WithDescription("Creates a Wago Ethernet channel (if not exists).")
            .WithExample("connectivity channels create wagoethernet -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateWonderwareIntouchClientCommand>("wonderwareintouchclient")
            .WithDescription("Creates a Wonderware InTouch Client channel (if not exists).")
            .WithExample("connectivity channels create wonderwareintouchclient -s [server-url] --name [channelName]");

        create.AddCommand<ChannelCreateYaskawaMpSeriesEthernetCommand>("yaskawampseriesethernet")
            .WithDescription("Creates a Yaskawa MP Series Ethernet channel (if not exists).")
            .WithExample("connectivity channels create yaskawampseriesethernet -s [server-url] --name [channelName]");
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
        get.AddCommand<DeviceGetAromatEthernetCommand>("aromatethernet")
            .WithDescription("Get an Aromat Ethernet device.")
            .WithExample("connectivity devices get aromatethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

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

        get.AddCommand<DeviceGetMitsubishiFxNetCommand>("mitsubishifxnet")
            .WithDescription("Get a Mitsubishi FX Net device.")
            .WithExample("connectivity devices get mitsubishifxnet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetGeEthernetCommand>("geethernet")
            .WithDescription("Get a GE Ethernet device.")
            .WithExample("connectivity devices get geethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetGeEthernetGlobalDataCommand>("geethernetglobaldata")
            .WithDescription("Get a GE Ethernet Global Data device.")
            .WithExample("connectivity devices get geethernetglobaldata -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetOmronNjEthernetCommand>("omronnjethernet")
            .WithDescription("Get an Omron NJ Ethernet device.")
            .WithExample("connectivity devices get omronnjethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceGetIecCommands(get);
    }

    private static void ConfigureDeviceGetIecCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetIec608705104ClientCommand>("iec608705104client")
            .WithDescription("Get an IEC 60870-5-104 Client device.")
            .WithExample("connectivity devices get iec608705104client -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetIec61850MmsClientCommand>("iec61850mmsclient")
            .WithDescription("Get an IEC 61850 MMS Client device.")
            .WithExample("connectivity devices get iec61850mmsclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceGetYokogawaCommands(get);
    }

    private static void ConfigureDeviceGetYokogawaCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetYokogawaCxEthernetCommand>("yokogawacxethernet")
            .WithDescription("Get a Yokogawa CX Ethernet device.")
            .WithExample("connectivity devices get yokogawacxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaDarwinEthernetCommand>("yokogawadarwinethernet")
            .WithDescription("Get a Yokogawa Darwin Ethernet device.")
            .WithExample("connectivity devices get yokogawadarwinethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaDxEthernetCommand>("yokogawadxethernet")
            .WithDescription("Get a Yokogawa DX Ethernet device.")
            .WithExample("connectivity devices get yokogawadxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaDxpEthernetCommand>("yokogawadxpethernet")
            .WithDescription("Get a Yokogawa DXP Ethernet device.")
            .WithExample("connectivity devices get yokogawadxpethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaMwEthernetCommand>("yokogawamwethernet")
            .WithDescription("Get a Yokogawa MW Ethernet device.")
            .WithExample("connectivity devices get yokogawamwethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaGxEthernetCommand>("yokogawagxethernet")
            .WithDescription("Get a Yokogawa GX Ethernet device.")
            .WithExample("connectivity devices get yokogawagxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYokogawaMxEthernetCommand>("yokogawamxethernet")
            .WithDescription("Get a Yokogawa MX Ethernet device.")
            .WithExample("connectivity devices get yokogawamxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceGetAutomationDirectCommands(get);
    }

    private static void ConfigureDeviceGetAutomationDirectCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetAutomationDirectProductivitySeriesEthernetCommand>("automationdirectproductivityseriesethernet")
            .WithDescription("Get an AutomationDirect Productivity Series Ethernet device.")
            .WithExample("connectivity devices get automationdirectproductivityseriesethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAutomationDirectEbcCommand>("automationdirectebc")
            .WithDescription("Get an AutomationDirect EBC device.")
            .WithExample("connectivity devices get automationdirectebc -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAutomationDirectEcomCommand>("automationdirectecom")
            .WithDescription("Get an AutomationDirect ECOM device.")
            .WithExample("connectivity devices get automationdirectecom -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetBeckhoffTwinCatCommand>("beckhofftwincat")
            .WithDescription("Get a Beckhoff TwinCAT device.")
            .WithExample("connectivity devices get beckhofftwincat -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetAlstomRedundantEthernetCommand>("alstomredundantethernet")
            .WithDescription("Get an Alstom Redundant Ethernet device.")
            .WithExample("connectivity devices get alstomredundantethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetBristolBsapIpCommand>("bristolbsapip")
            .WithDescription("Get a Bristol BSAP IP device.")
            .WithExample("connectivity devices get bristolbsapip -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetBuswareEthernetCommand>("buswareethernet")
            .WithDescription("Get a Busware Ethernet device.")
            .WithExample("connectivity devices get buswareethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetHoneywellHc900EthernetCommand>("honeywellhc900ethernet")
            .WithDescription("Get a Honeywell HC900 Ethernet device.")
            .WithExample("connectivity devices get honeywellhc900ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetFanucFocasEthernetCommand>("fanucfocasethernet")
            .WithDescription("Get a Fanuc Focas Ethernet device.")
            .WithExample("connectivity devices get fanucfocasethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetCutlerHammerElcEthernetCommand>("cutlerhammerelcethernet")
            .WithDescription("Get a Cutler-Hammer ELC Ethernet device.")
            .WithExample("connectivity devices get cutlerhammerelcethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetCodesysCommand>("codesys")
            .WithDescription("Get a CODESYS device.")
            .WithExample("connectivity devices get codesys -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetOpcXmlDaClientCommand>("opcxmldaclient")
            .WithDescription("Get an OPC XML-DA Client device.")
            .WithExample("connectivity devices get opcxmldaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceGetKToYCommands(get);
    }

    private static void ConfigureDeviceGetKToYCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetKeyenceKvEthernetCommand>("keyencekvethernet")
            .WithDescription("Get a Keyence KV Ethernet device.")
            .WithExample("connectivity devices get keyencekvethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetKraussMaffeiMc4EthernetCommand>("kraussmaffeimc4ethernet")
            .WithDescription("Get a KraussMaffei MC4 Ethernet device.")
            .WithExample("connectivity devices get kraussmaffeimc4ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetMtConnectClientCommand>("mtconnectclient")
            .WithDescription("Get an MTConnect Client device.")
            .WithExample("connectivity devices get mtconnectclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetOpto22EthernetCommand>("opto22ethernet")
            .WithDescription("Get an Opto 22 Ethernet device.")
            .WithExample("connectivity devices get opto22ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetSattBusEthernetCommand>("sattbusethernet")
            .WithDescription("Get a SattBus Ethernet device.")
            .WithExample("connectivity devices get sattbusethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetScanivalveEthernetCommand>("scanivalveethernet")
            .WithDescription("Get a Scanivalve Ethernet device.")
            .WithExample("connectivity devices get scanivalveethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetSimaticTi505EthernetCommand>("simaticti505ethernet")
            .WithDescription("Get a Simatic/TI 505 Ethernet device.")
            .WithExample("connectivity devices get simaticti505ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetSixnetEthertrakCommand>("sixnetethertrak")
            .WithDescription("Get a SIXNET EtherTRAK device.")
            .WithExample("connectivity devices get sixnetethertrak -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetSnmpCommand>("snmp")
            .WithDescription("Get an SNMP device.")
            .WithExample("connectivity devices get snmp -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceGetTToYCommands(get);
    }

    private static void ConfigureDeviceGetTToYCommands(
        IConfigurator<CommandSettings> get)
    {
        get.AddCommand<DeviceGetThermoWestronicsEthernetCommand>("thermowestronicsethernet")
            .WithDescription("Get a Thermo Westronics Ethernet device.")
            .WithExample("connectivity devices get thermowestronicsethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetTorqueToolEthernetCommand>("torquetoolethernet")
            .WithDescription("Get a Torque Tool Ethernet device.")
            .WithExample("connectivity devices get torquetoolethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetToshibaEthernetCommand>("toshibaethernet")
            .WithDescription("Get a Toshiba Ethernet device.")
            .WithExample("connectivity devices get toshibaethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetToyopucEthernetCommand>("toyopucethernet")
            .WithDescription("Get a Toyopuc PC3/PC2 Ethernet device.")
            .WithExample("connectivity devices get toyopucethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetTriconexEthernetCommand>("triconexethernet")
            .WithDescription("Get a Triconex Ethernet device.")
            .WithExample("connectivity devices get triconexethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetWagoEthernetCommand>("wagoethernet")
            .WithDescription("Get a Wago Ethernet device.")
            .WithExample("connectivity devices get wagoethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetWonderwareIntouchClientCommand>("wonderwareintouchclient")
            .WithDescription("Get a Wonderware InTouch Client device.")
            .WithExample("connectivity devices get wonderwareintouchclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        get.AddCommand<DeviceGetYaskawaMpSeriesEthernetCommand>("yaskawampseriesethernet")
            .WithDescription("Get a Yaskawa MP Series Ethernet device.")
            .WithExample("connectivity devices get yaskawampseriesethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");
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
        create.AddCommand<DeviceCreateAromatEthernetCommand>("aromatethernet")
            .WithDescription("Creates an Aromat Ethernet device (if not exists).")
            .WithExample("connectivity devices create aromatethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

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

        create.AddCommand<DeviceCreateMitsubishiFxNetCommand>("mitsubishifxnet")
            .WithDescription("Creates a Mitsubishi FX Net device (if not exists).")
            .WithExample("connectivity devices create mitsubishifxnet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateGeEthernetCommand>("geethernet")
            .WithDescription("Creates a GE Ethernet device (if not exists).")
            .WithExample("connectivity devices create geethernet -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateGeEthernetGlobalDataCommand>("geethernetglobaldata")
            .WithDescription("Creates a GE Ethernet Global Data device (if not exists).")
            .WithExample("connectivity devices create geethernetglobaldata -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateOmronNjEthernetCommand>("omronnjethernet")
            .WithDescription("Creates an Omron NJ Ethernet device (if not exists).")
            .WithExample("connectivity devices create omronnjethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        ConfigureDeviceCreateIecCommands(create);
    }

    private static void ConfigureDeviceCreateIecCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateIec608705104ClientCommand>("iec608705104client")
            .WithDescription("Creates an IEC 60870-5-104 Client device (if not exists).")
            .WithExample("connectivity devices create iec608705104client -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateIec61850MmsClientCommand>("iec61850mmsclient")
            .WithDescription("Creates an IEC 61850 MMS Client device (if not exists).")
            .WithExample("connectivity devices create iec61850mmsclient -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        ConfigureDeviceCreateYokogawaCommands(create);
    }

    private static void ConfigureDeviceCreateYokogawaCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateYokogawaCxEthernetCommand>("yokogawacxethernet")
            .WithDescription("Creates a Yokogawa CX Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawacxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaDarwinEthernetCommand>("yokogawadarwinethernet")
            .WithDescription("Creates a Yokogawa Darwin Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawadarwinethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaDxEthernetCommand>("yokogawadxethernet")
            .WithDescription("Creates a Yokogawa DX Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawadxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaDxpEthernetCommand>("yokogawadxpethernet")
            .WithDescription("Creates a Yokogawa DXP Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawadxpethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaMwEthernetCommand>("yokogawamwethernet")
            .WithDescription("Creates a Yokogawa MW Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawamwethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaGxEthernetCommand>("yokogawagxethernet")
            .WithDescription("Creates a Yokogawa GX Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawagxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateYokogawaMxEthernetCommand>("yokogawamxethernet")
            .WithDescription("Creates a Yokogawa MX Ethernet device (if not exists).")
            .WithExample("connectivity devices create yokogawamxethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        ConfigureDeviceCreateAutomationDirectCommands(create);
    }

    private static void ConfigureDeviceCreateAutomationDirectCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateAutomationDirectProductivitySeriesEthernetCommand>("automationdirectproductivityseriesethernet")
            .WithDescription("Creates an AutomationDirect Productivity Series Ethernet device (if not exists).")
            .WithExample("connectivity devices create automationdirectproductivityseriesethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateAutomationDirectEbcCommand>("automationdirectebc")
            .WithDescription("Creates an AutomationDirect EBC device (if not exists).")
            .WithExample("connectivity devices create automationdirectebc -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateAutomationDirectEcomCommand>("automationdirectecom")
            .WithDescription("Creates an AutomationDirect ECOM device (if not exists).")
            .WithExample("connectivity devices create automationdirectecom -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateBeckhoffTwinCatCommand>("beckhofftwincat")
            .WithDescription("Creates a Beckhoff TwinCAT device (if not exists).")
            .WithExample("connectivity devices create beckhofftwincat -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateAlstomRedundantEthernetCommand>("alstomredundantethernet")
            .WithDescription("Creates an Alstom Redundant Ethernet device (if not exists).")
            .WithExample("connectivity devices create alstomredundantethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --primary-normal-ip [ip]");

        create.AddCommand<DeviceCreateBristolBsapIpCommand>("bristolbsapip")
            .WithDescription("Creates a Bristol BSAP IP device (if not exists).")
            .WithExample("connectivity devices create bristolbsapip -s [server-url] --channel-name [channelName] --device-name [deviceName] --rtu-ip-address [ip]");

        create.AddCommand<DeviceCreateBuswareEthernetCommand>("buswareethernet")
            .WithDescription("Creates a Busware Ethernet device (if not exists).")
            .WithExample("connectivity devices create buswareethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateHoneywellHc900EthernetCommand>("honeywellhc900ethernet")
            .WithDescription("Creates a Honeywell HC900 Ethernet device (if not exists).")
            .WithExample("connectivity devices create honeywellhc900ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateFanucFocasEthernetCommand>("fanucfocasethernet")
            .WithDescription("Creates a Fanuc Focas Ethernet device (if not exists).")
            .WithExample("connectivity devices create fanucfocasethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateCodesysCommand>("codesys")
            .WithDescription("Creates a CODESYS device (if not exists).")
            .WithExample("connectivity devices create codesys -s [server-url] --channel-name [channelName] --device-name [deviceName] --ip-address [ipAddress]");

        create.AddCommand<DeviceCreateCutlerHammerElcEthernetCommand>("cutlerhammerelcethernet")
            .WithDescription("Creates a Cutler-Hammer ELC Ethernet device (if not exists).")
            .WithExample("connectivity devices create cutlerhammerelcethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateHoneywellUdcEthernetCommand>("honeywelludcethernet")
            .WithDescription("Creates a Honeywell UDC Ethernet device (if not exists).")
            .WithExample("connectivity devices create honeywelludcethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateOpcXmlDaClientCommand>("opcxmldaclient")
            .WithDescription("Creates an OPC XML-DA Client device (if not exists).")
            .WithExample("connectivity devices create opcxmldaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        ConfigureDeviceCreateKToYCommands(create);
    }

    private static void ConfigureDeviceCreateKToYCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateKeyenceKvEthernetCommand>("keyencekvethernet")
            .WithDescription("Creates a Keyence KV Ethernet device (if not exists).")
            .WithExample("connectivity devices create keyencekvethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateKraussMaffeiMc4EthernetCommand>("kraussmaffeimc4ethernet")
            .WithDescription("Creates a KraussMaffei MC4 Ethernet device (if not exists).")
            .WithExample("connectivity devices create kraussmaffeimc4ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateMtConnectClientCommand>("mtconnectclient")
            .WithDescription("Creates an MTConnect Client device (if not exists).")
            .WithExample("connectivity devices create mtconnectclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateOpto22EthernetCommand>("opto22ethernet")
            .WithDescription("Creates an Opto 22 Ethernet device (if not exists).")
            .WithExample("connectivity devices create opto22ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateSattBusEthernetCommand>("sattbusethernet")
            .WithDescription("Creates a SattBus Ethernet device (if not exists).")
            .WithExample("connectivity devices create sattbusethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateScanivalveEthernetCommand>("scanivalveethernet")
            .WithDescription("Creates a Scanivalve Ethernet device (if not exists).")
            .WithExample("connectivity devices create scanivalveethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateSimaticTi505EthernetCommand>("simaticti505ethernet")
            .WithDescription("Creates a Simatic/TI 505 Ethernet device (if not exists).")
            .WithExample("connectivity devices create simaticti505ethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateSixnetEthertrakCommand>("sixnetethertrak")
            .WithDescription("Creates a SIXNET EtherTRAK device (if not exists).")
            .WithExample("connectivity devices create sixnetethertrak -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateSnmpCommand>("snmp")
            .WithDescription("Creates an SNMP device (if not exists).")
            .WithExample("connectivity devices create snmp -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        ConfigureDeviceCreateTToYCommands(create);
    }

    private static void ConfigureDeviceCreateTToYCommands(
        IConfigurator<CommandSettings> create)
    {
        create.AddCommand<DeviceCreateThermoWestronicsEthernetCommand>("thermowestronicsethernet")
            .WithDescription("Creates a Thermo Westronics Ethernet device (if not exists).")
            .WithExample("connectivity devices create thermowestronicsethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateTorqueToolEthernetCommand>("torquetoolethernet")
            .WithDescription("Creates a Torque Tool Ethernet device (if not exists).")
            .WithExample("connectivity devices create torquetoolethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateToshibaEthernetCommand>("toshibaethernet")
            .WithDescription("Creates a Toshiba Ethernet device (if not exists).")
            .WithExample("connectivity devices create toshibaethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateToyopucEthernetCommand>("toyopucethernet")
            .WithDescription("Creates a Toyopuc PC3/PC2 Ethernet device (if not exists).")
            .WithExample("connectivity devices create toyopucethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateTriconexEthernetCommand>("triconexethernet")
            .WithDescription("Creates a Triconex Ethernet device (if not exists).")
            .WithExample("connectivity devices create triconexethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateWagoEthernetCommand>("wagoethernet")
            .WithDescription("Creates a Wago Ethernet device (if not exists).")
            .WithExample("connectivity devices create wagoethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");

        create.AddCommand<DeviceCreateWonderwareIntouchClientCommand>("wonderwareintouchclient")
            .WithDescription("Creates a Wonderware InTouch Client device (if not exists).")
            .WithExample("connectivity devices create wonderwareintouchclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");

        create.AddCommand<DeviceCreateYaskawaMpSeriesEthernetCommand>("yaskawampseriesethernet")
            .WithDescription("Creates a Yaskawa MP Series Ethernet device (if not exists).")
            .WithExample("connectivity devices create yaskawampseriesethernet -s [server-url] --channel-name [channelName] --device-name [deviceName] --device-id [deviceId]");
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