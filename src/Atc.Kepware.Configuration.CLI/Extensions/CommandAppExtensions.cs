namespace Atc.Kepware.Configuration.CLI.Extensions;

public static class CommandAppExtensions
{
    public static void ConfigureCommands(
        this CommandApp<RootCommand> app)
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
        });

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
                .WithExample("connectivity devices get all -s [server-url] --channel-name [channelName]");

            get.AddCommand<DeviceGetEuroMap63Command>("euromap63")
                .WithDescription("Get a EuroMap63 device.")
                .WithExample("connectivity devices get euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]");

            get.AddCommand<DeviceGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Get a OPC UA Client device.")
                .WithExample("connectivity devices get opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]");
        });

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