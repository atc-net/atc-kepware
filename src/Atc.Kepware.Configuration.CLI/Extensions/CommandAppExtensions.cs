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
                .WithExample(new[] { "connectivity channels get all" });

            get.AddCommand<ChannelGetEuroMap63Command>("euromap63")
                .WithDescription("Get a EuroMap63 channel.")
                .WithExample(new[] { "connectivity channels get euromap63 -s [server-url] --name [channelName]" });

            get.AddCommand<ChannelGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Get a OPC UA Client channel.")
                .WithExample(new[] { "connectivity channels get opcuaclient -s [server-url] --name [channelName]" });
        });

    private static void ConfigureChannelCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating channels.");
            create.AddCommand<ChannelCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 channel (if not exists).")
                .WithExample(new[] { "connectivity channels create euromap63 -s [server-url] --name [channelName] --description [description]" });

            create.AddCommand<ChannelCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client channel (if not exists).")
                .WithExample(new[] { "connectivity channels create opcuaclient -s [server-url] --name [channelName] --description [description]" });
        });

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
                .WithExample(new[] { "connectivity devices get all -s [server-url] --channel-name [channelName]" });

            get.AddCommand<DeviceGetEuroMap63Command>("euromap63")
                .WithDescription("Get a EuroMap63 device.")
                .WithExample(new[] { "connectivity devices get euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]" });

            get.AddCommand<DeviceGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Get a OPC UA Client device.")
                .WithExample(new[] { "connectivity devices get opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]" });
        });

    private static void ConfigureDeviceCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating devices.");

            create.AddCommand<DeviceCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 device (if not exists).")
                .WithExample(new[] { "connectivity devices create euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName] --description [description] --session-file-path [filePath]" });

            create.AddCommand<DeviceCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client device (if not exists).")
                .WithExample(new[] { "connectivity devices create opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName] --description [description] " });
        });

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
                .WithExample(new[] { "connectivity tags search -s [server-url] --search MyTag" })
                .WithExample(new[] { "connectivity tags search -s [server-url] --search *Tag" })
                .WithExample(new[] { "connectivity tags search -s [server-url] --search My*" })
                .WithExample(new[] { "connectivity tags search -s [server-url] --search *yt*" });
        };

    private static void ConfigureTagCreateCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating tags and tag groups.");

            create.AddCommand<TagsCreateTagCommand>("tag")
                .WithDescription("Creates a tag (if not exists).")
                .WithExample(new[] { "connectivity tags create tag -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagName] --address [tagAddress] --scan-rate [scanRate] --data-type [dataType] --client-access [clientAccess] --description [description]" });

            create.AddCommand<TagsCreateTagGroupCommand>("taggroup")
                .WithDescription("Creates a tag group (if not exists).")
                .WithExample(new[] { "connectivity tags create taggroup -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagGroupName] --description [description]" });
        });

    private static void ConfigureTagDeleteCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("delete", create =>
        {
            create.SetDescription("Operations related to deleting tags and tag groups.");

            create.AddCommand<TagsDeleteTagCommand>("tag")
                .WithDescription("Delete a tag (if exists).")
                .WithExample(new[] { "connectivity tags delete tag -s [server-url] --name [tagName]" });

            create.AddCommand<TagsDeleteTagGroupCommand>("taggroup")
                .WithDescription("Deletes a tag group (if exists).")
                .WithExample(new[] { "connectivity tags delete taggroup -s [server-url] --name [tagGroupName]" });
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
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]" });

            mqttClient.AddCommand<IotAgentGetMqttClientCommand>("get")
                .WithDescription("Get a single mqtt-client iot agent.")
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client get -s [server-url] --name [iotAgentName]" });

            mqttClient.AddCommand<IotAgentGetAllMqttClientsCommand>("all")
                .WithDescription("Get all mqtt-client iot agents.")
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client all -s [server-url]" });

            mqttClient.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a mqtt-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client enable -s [server-url] --name [iotAgentName]" });

            mqttClient.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a mqtt-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client disable -s [server-url] --name [iotAgentName]" });

            mqttClient.AddCommand<IotAgentDeleteMqttClientCommand>("delete")
                .WithDescription("Delete a mqtt-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent mqtt-client delete -s [server-url] --name [iotAgentName]" });
        });

    private static void ConfigureIotAgentRestClientCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-client", restClient =>
        {
            restClient.SetDescription("Operations related to Rest Client Iot Agents");

            restClient.AddCommand<IotAgentCreateRestClientCommand>("create")
                .WithDescription("Create a rest-client iot agent (if not exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]" });

            restClient.AddCommand<IotAgentGetRestClientCommand>("get")
                .WithDescription("Get a single rest-client iot agent.")
                .WithExample(new[] { "iot-gateway iot-agent rest-client get -s [server-url] --name [iotAgentName]" });

            restClient.AddCommand<IotAgentGetAllRestClientsCommand>("all")
                .WithDescription("Get all rest-client iot agents.")
                .WithExample(new[] { "iot-gateway iot-agent rest-client all -s [server-url]" });

            restClient.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a rest-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-client enable -s [server-url] --name [iotAgentName]" });

            restClient.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a rest-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-client disable -s [server-url] --name [iotAgentName]" });

            restClient.AddCommand<IotAgentDeleteRestClientCommand>("delete")
                .WithDescription("Delete a rest-client iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-client delete -s [server-url] --name [iotAgentName]" });
        });

    private static void ConfigureIotAgentRestServerCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-server", restServer =>
        {
            restServer.SetDescription("Operations related to Rest Server Iot Agents");

            restServer.AddCommand<IotAgentCreateRestServerCommand>("create")
                .WithDescription("Create a rest-server iot agent (if not exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-server create -s [server-url] --name [iotAgentName] --url [url]" });

            restServer.AddCommand<IotAgentGetRestServerCommand>("get")
                .WithDescription("Get a single rest-server iot agent.")
                .WithExample(new[] { "iot-gateway iot-agent rest-server get -s [server-url] --name [iotAgentName]" });

            restServer.AddCommand<IotAgentGetAllRestServersCommand>("all")
                .WithDescription("Get all rest-server iot agents.")
                .WithExample(new[] { "iot-gateway iot-agent rest-server all -s [server-url]" });

            restServer.AddCommand<IotAgentEnableCommand>("enable")
                .WithDescription("Enable a rest-server iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-server enable -s [server-url] --name [iotAgentName]" });

            restServer.AddCommand<IotAgentDisableCommand>("disable")
                .WithDescription("Disable a rest-server iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-server disable -s [server-url] --name [iotAgentName]" });

            restServer.AddCommand<IotAgentDeleteRestServerCommand>("delete")
                .WithDescription("Delete a rest-server iot agent (if exists).")
                .WithExample(new[] { "iot-gateway iot-agent rest-server delete -s [server-url] --name [iotAgentName]" });
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

        mqttClient.AddCommand<IotAgentMqttClientIotItemCreateCommand>("create")
            .WithDescription("Create one or more iot items on a mqtt-client iot agent.")
            .WithExample(new[] { "iot-gateway iot-item mqtt-client create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]" });

        mqttClient.AddCommand<IotAgentIotItemGetCommand>("get")
            .WithDescription("Get a single mqtt-client iot agent iot item.")
            .WithExample(new[] { "iot-gateway iot-item mqtt-client get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });

        mqttClient.AddCommand<IotAgentGetAllIotItemsCommand>("all")
            .WithDescription("Get all mqtt-client iot agent iot items.")
            .WithExample(new[] { "iot-gateway iot-item mqtt-client all -s [server-url]" });

        mqttClient.AddCommand<IotAgentIotItemDeleteCommand>("delete")
            .WithDescription("Delete a mqtt-client iot agent iot item (if exists).")
            .WithExample(new[] { "iot-gateway iot-item mqtt-client delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });
    });

    private static void ConfigureIotItemRestClientCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-client", restClient =>
        {
            restClient.SetDescription("Operations related to Rest Client Iot Agent Iot Items");

            restClient.AddCommand<IotAgentRestClientIotItemCreateCommand>("create")
                .WithDescription("Create an iot item on a rest-client iot agent.")
                .WithExample(new[] { "iot-gateway iot-item rest-client create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]" });

            restClient.AddCommand<IotAgentIotItemGetCommand>("get")
                .WithDescription("Get a single rest-client iot agent iot item.")
                .WithExample(new[] { "iot-gateway iot-item rest-client get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });

            restClient.AddCommand<IotAgentGetAllIotItemsCommand>("all")
                .WithDescription("Get all rest-client iot agent iot items.")
                .WithExample(new[] { "iot-gateway iot-item rest-client all -s [server-url]" });

            restClient.AddCommand<IotAgentIotItemDeleteCommand>("delete")
                .WithDescription("Delete a rest-client iot agent iot item (if exists).")
                .WithExample(new[] { "iot-gateway iot-item rest-client delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });
        });

    private static void ConfigureIotItemRestServerCommands(
        IConfigurator<CommandSettings> node)
        => node.AddBranch("rest-server", restServer =>
        {
            restServer.SetDescription("Operations related to Rest Server Iot Agent Iot Items");

            restServer.AddCommand<IotAgentRestServerIotItemCreateCommand>("create")
                .WithDescription("Create one or more iot items on a rest-server iot agent.")
                .WithExample(new[] { "iot-gateway iot-item rest-server create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag] --scan-rate [scanRate]" });

            restServer.AddCommand<IotAgentIotItemGetCommand>("get")
                .WithDescription("Get a single rest-server iot agent iot item.")
                .WithExample(new[] { "iot-gateway iot-item rest-server get -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });

            restServer.AddCommand<IotAgentGetAllIotItemsCommand>("all")
                .WithDescription("Get all rest-server iot agent iot items.")
                .WithExample(new[] { "iot-gateway iot-item rest-server all -s [server-url]" });

            restServer.AddCommand<IotAgentIotItemDeleteCommand>("delete")
                .WithDescription("Delete a rest-server iot agent iot item (if exists).")
                .WithExample(new[] { "iot-gateway iot-item rest-server delete -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]" });
        });
}