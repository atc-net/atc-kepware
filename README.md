[![NuGet Version](https://img.shields.io/nuget/v/atc.kepware.configuration.svg?logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/atc.kepware.configuration)

# Atc.Kepware

Kepware configuration library for executing commands, reads and writes on Kepware servers

## CLI Tool

The `Atc.Kepware.Configuration.CLI` tool is available through a cross platform command line application.

### Requirements

* [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

### Installation

The tool can be installed as a .NET global tool by the following command

```powershell
dotnet tool install --global atc-kepware-configuration
```

or by following the instructions [here](https://www.nuget.org/packages/atc-kepware-configuration/) to install a specific version of the tool.

A successful installation will output something like

```powershell
The tool can be invoked by the following command: atc-kepware-configuration
Tool 'atc-kepware-configuration' (version '1.0.xxx') was successfully installed.`
```

### Update

The tool can be updated by the following command

```powershell
dotnet tool update --global atc-kepware-configuration
```

### Usage

Since the tool is published as a .NET Tool, it can be launched from anywhere using any shell or command-line interface by calling **atc-kepware-configuration**. The help information is displayed when providing the `--help` argument to **atc-kepware-configuration**

#### Option <span style="color:yellow">--help</span>

```powershell
atc-kepware-configuration --help

USAGE:
    atc-kepware-configuration.exe [OPTIONS]

OPTIONS:
    -h, --help       Prints help information
    -v, --verbose    Use verbose for more debug/trace information
        --version    Display version

COMMANDS:
    connectivity
    iot-gateway
```

#### Command <span style="color:yellow">connectivity</span>

```powershell
atc-kepware-configuration connectivity --help

USAGE:
    atc-kepware-configuration.exe connectivity [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe connectivity channels get all -s [server-url]
    atc-kepware-configuration.exe connectivity channels get euromap63 -s [server-url] --name [channelName]
    atc-kepware-configuration.exe connectivity channels get opcuaclient -s [server-url] --name [channelName]
    atc-kepware-configuration.exe connectivity channels create euromap63 -s [server-url] --name [channelName] --description [description]
    atc-kepware-configuration.exe connectivity channels create opcuaclient -s [server-url] --name [channelName] --description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    channels    Commands for channels
    devices     Commands for devices
    tags        Commands for tags
```

#### Command <span style="color:yellow">connectivity channels</span>

```powershell
atc-kepware-configuration connectivity channels --help

USAGE:
    atc-kepware-configuration.exe connectivity channels [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe connectivity channels get all -s [server-url]
    atc-kepware-configuration.exe connectivity channels get euromap63 -s [server-url] --name [channelName]
    atc-kepware-configuration.exe connectivity channels get opcuaclient -s [server-url] --name [channelName]
    atc-kepware-configuration.exe connectivity channels create euromap63 -s [server-url] --name [channelName] --description [description]
    atc-kepware-configuration.exe connectivity channels create opcuaclient -s [server-url] --name [channelName] --description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Operations related to retrieving channels
    create    Operations related to creating channels
    delete    Delete channel
```

#### Command <span style="color:yellow">connectivity devices</span>

```powershell
atc-kepware-configuration connectivity devices --help

USAGE:
    atc-kepware-configuration.exe connectivity devices [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe connectivity devices get all -s [server-url] --channel-name [channelName]
    atc-kepware-configuration.exe connectivity devices get euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]
    atc-kepware-configuration.exe connectivity devices get opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]
    atc-kepware-configuration.exe connectivity devices create euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]
--description [description] --session-file-path [filePath]
    atc-kepware-configuration.exe connectivity devices create opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]
--description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Operations related to retrieving devices
    create    Operations related to creating devices
    delete    Delete device from channel
```

#### Command <span style="color:yellow">connectivity tags</span>

```powershell
atc-kepware-configuration connectivity tags --help

USAGE:
    atc-kepware-configuration.exe connectivity tags [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe connectivity tags search -s [server-url] --search MyTag
    atc-kepware-configuration.exe connectivity tags search -s [server-url] --search *Tag
    atc-kepware-configuration.exe connectivity tags search -s [server-url] --search My*
    atc-kepware-configuration.exe connectivity tags search -s [server-url] --search *yt*
    atc-kepware-configuration.exe connectivity tags create tag -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagName]
--address [tagAddress] --scan-rate [scanRate] --data-type [dataType] --client-access [clientAccess] --description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Get tags for channel and device
    create    Operations related to creating tags and tag groups
    delete    Operations related to deleting tags and tag groups
    search    Search tags
```

#### Command <span style="color:yellow">iot-gateway</span>

```powershell
atc-kepware-configuration iot-gateway --help

USAGE:
    atc-kepware-configuration.exe iot-gateway [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client get -s [server-url] --name [iotAgentName]
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client all -s [server-url]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client get -s [server-url] --name [iotAgentName]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    iot-agent   Commands for iot agents
    iot-item    Commands for iot items
```

#### Command <span style="color:yellow">iot-gateway iot-agent</span>

```powershell
atc-kepware-configuration iot-gateway iot-agent --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-agent [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client get -s [server-url] --name [iotAgentName]
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client all -s [server-url]
    atc-kepware-configuration.exe iot-gateway iot-agent mqtt-client delete -s [server-url] --name [iotAgentName]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    mqtt-client    Operations related to MQTT Client Iot Agents
    rest-client    Operations related to Rest Client Iot Agents
    rest-server    Operations related to Rest Server Iot Agents
```

#### Command <span style="color:yellow">iot-gateway iot-agent rest-client</span>

```powershell
atc-kepware-configuration iot-gateway iot-agent rest-client --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client get -s [server-url] --name [iotAgentName]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client all -s [server-url]
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client delete -s [server-url] --name [iotAgentName]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    create    Create a rest-client iot agent (if not exists)
    get       Get a single rest-client iot agent
    all       Get all rest-client iot agents
    delete    Delete a rest-client iot agent (if exists)
```

#### Command <span style="color:yellow">iot-gateway iot-agent rest-client create</span>

```powershell
atc-kepware-configuration iot-gateway iot-agent rest-client create --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-agent rest-client create [OPTIONS] <COMMAND>

EXAMPLES:
     atc-kepware-configuration.exe iot-gateway iot-agent rest-client create -s [server-url] --name [iotAgentName] --url [url] --publish-message-format [Standard|Advanced]

OPTIONS:
    -h, --help                                               Prints help information
    -v, --verbose                                            Use verbose for more debug/trace information
    -s, --server-url <SERVER-URL>                            Server Url for Kepserver configuration endpoint
    -u, --username [USERNAME]                                UserName for Kepware server configuration endpoint
    -p, --password [PASSWORD]                                Password for Kepware server configuration endpoint
    -n, --name <NAME>                                        Iot Agent Name
        --description [DESCRIPTION]                          Iot Agent Description
        --ignore-quality-changes                             Indicates whether changes in quality should be ignored and not passed on
        --url <URL>                                          The URl of the endpoint to send data to
        --publish-http-method <PUBLISH-HTTP-METHOD>          Sets the HttpMethod for Publishing. Valid values are: Post (default), Put
        --rate <RATE>                                        Specifies the frequency, in milliseconds, at which the agent pushes data to the endpoint
        --publish-format <PUBLISH-FORMAT>                    Sets the format type for Publishing. Valid values are: Narrow (default), Wide
        --max-events-per-publish                             The number of tag events the gateway packages in a single transmission when using narrow format
        --transaction-timeout <TRANSACTION-TIMEOUT>          Defines the maximum amount of time, in seconds, allowed for a transaction to run
        --send-initial-update                                Indicates if an initial update should be sent out on each tag when the Iot Agent starts up
        --http-headers <KEY=VALUE>                           The headers to send to url on each connection
        --publish-message-format <PUBLISH-MESSAGE-FORMAT>    Specifies how messages should be formatted. Valid values are: Standard, Advanced (default)
        --publish-media-type [PUBLISH-MEDIA-TYPE]            Sets the media type for Publishing. Only valid when PublishMessageFormat is set to (Advanced). Valid values are: Json (default), Xml,
                                                             XhtmlXml, TextPlain, TextHtml

```

```powershell
atc-kepware-configuration iot-gateway iot-item --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-item [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-item mqtt-client create -s [server-url] --iot-agent-name [
iotAgentName] --name [iotItemName] --server-tag [serverTag] --scan-rate [scanRate]
    atc-kepware-configuration.exe iot-gateway iot-item mqtt-client get -s [server-url] --iot-agent-name [iotAgentName]
--name [iotItemName]
    atc-kepware-configuration.exe iot-gateway iot-item mqtt-client all -s [server-url]
    atc-kepware-configuration.exe iot-gateway iot-item rest-client create -s [server-url] --iot-agent-name [
iotAgentName] --name [iotItemName] --server-tag [serverTag] --scan-rate [scanRate]
    atc-kepware-configuration.exe iot-gateway iot-item rest-client get -s [server-url] --iot-agent-name [iotAgentName]
--name [iotItemName]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    mqtt-client    Operations related to MQTT Client Iot Agent Iot Items
    rest-client    Operations related to Rest Client Iot Agent Iot Items
    rest-server    Operations related to Rest Server Iot Agent Iot Items
```

```powershell
atc-kepware-configuration iot-gateway iot-item rest-client --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-item rest-client [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-item rest-client create -s [server-url] --iot-agent-name [
iotAgentName] --name [iotItemName] --server-tag [serverTag] --scan-rate [scanRate]
    atc-kepware-configuration.exe iot-gateway iot-item rest-client get -s [server-url] --iot-agent-name [iotAgentName]
--name [iotItemName]
    atc-kepware-configuration.exe iot-gateway iot-item rest-client all -s [server-url]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    create    Create an iot item on a rest-client iot agent
    get       Get a single rest-client iot agent iot item
    all       Get all rest-client iot agent iot items
```

```powershell
atc-kepware-configuration iot-gateway iot-item rest-client create --help

USAGE:
    atc-kepware-configuration.exe iot-gateway iot-item rest-client create [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe iot-gateway iot-item rest-client create -s [server-url] --iot-agent-name [iotAgentName] --server-tag [serverTag]
--scan-rate [scanRate]

OPTIONS:
    -h, --help    Prints help information
        --iot-agent-name <IOT-AGENT-NAME>          Iot Agent Name
        --server-tag <SERVER-TAG>                  The server tag the Iot Item is pointing to
        --scan-rate <SCAN-RATE>                    Specifies the frequency, in milliseconds, at which the iot item should be scanned (default: 10000)
        --send-every-scan                          Specifies if the tag should be published on every scan or only on data changes (default: false)
        --dead-band-percent [DEAD-BAND-PERCENT]    Specifies the DeadBand (%) when SendEveryScan is false (default: 0)
        --enabled                                  Indicates whether the Iot Item is enabled (default: true)

COMMANDS:
    create    Create an iot item on a rest-client iot agent
```

## How to contribute

[Contribution Guidelines](https://atc-net.github.io/introduction/about-atc#how-to-contribute)

[Coding Guidelines](https://atc-net.github.io/introduction/about-atc#coding-guidelines)
