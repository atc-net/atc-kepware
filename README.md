[![NuGet Version](https://img.shields.io/nuget/v/atc.kepware.configuration.svg?logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/atc.kepware.configuration)

# Introduction

Atc.Kepware is a .NET library and CLI tool for configuring Kepware servers via REST API. It provides a streamlined interface for managing connectivity resources (channels, devices, tags) and IoT Gateway features (agents, items).

## Table of Contents

- [Introduction](#introduction)
  - [Table of Contents](#table-of-contents)
  - [Features](#features)
  - [Getting Started](#getting-started)
    - [Installation](#installation)
    - [Basic Usage](#basic-usage)
    - [Configuring with ServiceCollection Extensions](#configuring-with-servicecollection-extensions)
      - [Setup with Explicit Parameters](#setup-with-explicit-parameters)
      - [Setup with Pre-Configured Options](#setup-with-pre-configured-options)
      - [Setup with Configuration Delegate](#setup-with-configuration-delegate)
  - [Connectivity Operations](#connectivity-operations)
    - [Channels](#channels)
    - [Devices](#devices)
    - [Tags](#tags)
  - [IoT Gateway Operations](#iot-gateway-operations)
    - [IoT Agents](#iot-agents)
    - [IoT Items](#iot-items)
  - [Supported Drivers](#supported-drivers)
- [CLI Tool](#cli-tool)
  - [Installation](#installation-1)
  - [Commands](#commands)
    - [Connectivity Commands](#connectivity-commands)
    - [IoT Gateway Commands](#iot-gateway-commands)
- [Sample](#sample)
- [Requirements](#requirements)
- [How to contribute](#how-to-contribute)

## Features

The library provides comprehensive Kepware server management capabilities:

- ✅ **Channel Management**: Create, retrieve, and delete channels for 70+ [supported drivers](#supported-drivers)
- ✅ **Device Management**: Configure devices under channels with driver-specific settings
- ✅ **Tag Management**: Create tags and tag groups with hierarchical structures, search for tags with wildcards
- ✅ **IoT Gateway**: Manage MQTT and REST client/server agents and their associated items
- ✅ **Cross-Platform CLI**: Global .NET tool for command-line configuration management

## Getting Started

### Installation

Install the NuGet package:

```bash
dotnet add package Atc.Kepware.Configuration
```

### Basic Usage

Here's a minimal example to connect to a Kepware server and retrieve channels:

```csharp
using Atc.Kepware.Configuration.Services;
using Microsoft.Extensions.Logging;

// Create logger
using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

// Create client with connection information
using var client = new KepwareConfigurationClient(
    loggerFactory,
    baseUri: new Uri("https://localhost:57412/config/v1/"),
    userName: "Administrator",
    password: "",
    disableCertificateValidationCheck: true);

// Get all channels
var result = await client.GetChannels(CancellationToken.None);

if (result is { CommunicationSucceeded: true, HasData: true })
{
    foreach (var channel in result.Data!)
    {
        Console.WriteLine($"Channel: {channel.Name} (Driver: {channel.DeviceDriver})");
    }
}
```

### Configuring with ServiceCollection Extensions

To seamlessly integrate the Kepware Configuration Client into your application, you can utilize the provided `ServiceCollection` extension methods. These methods simplify the setup process and ensure that the client is correctly configured and ready to use within your application's service architecture.

The extension methods allow you to configure the client using different approaches — explicit parameters, a pre-configured `KepwareConfigurationOptions` instance, or an `Action<KepwareConfigurationOptions>` delegate for dynamic configuration.

#### Setup with Explicit Parameters

If you prefer to configure the client with explicit values for the server's URI, credentials, and certificate validation, you can use the following approach:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKepwareConfiguration(
    new Uri(builder.Configuration["Kepware:BaseUri"]!),
    builder.Configuration["Kepware:UserName"],
    builder.Configuration["Kepware:Password"],
    disableCertificateValidationCheck: true);
```

#### Setup with Pre-Configured Options

When you already have a pre-configured `KepwareConfigurationOptions` instance, you can directly pass it to the configuration method:

```csharp
var builder = WebApplication.CreateBuilder(args);

var kepwareOptions = new KepwareConfigurationOptions
{
    BaseUri = new Uri(builder.Configuration["Kepware:BaseUri"]!),
    UserName = builder.Configuration["Kepware:UserName"],
    Password = builder.Configuration["Kepware:Password"],
    DisableCertificateValidationCheck = true,
};

builder.Services.AddKepwareConfiguration(kepwareOptions);
```

#### Setup with Configuration Delegate

For more flexibility, you can configure the client using an `Action<KepwareConfigurationOptions>` delegate. This is particularly useful when you need to dynamically adjust settings during application startup:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKepwareConfiguration(options =>
{
    options.BaseUri = new Uri(builder.Configuration["Kepware:BaseUri"]!);
    options.UserName = builder.Configuration["Kepware:UserName"];
    options.Password = builder.Configuration["Kepware:Password"];
    options.DisableCertificateValidationCheck = true;
});
```

After configuration, inject `IKepwareConfigurationClient` into your services:

```csharp
public class MyService
{
    private readonly IKepwareConfigurationClient client;

    public MyService(IKepwareConfigurationClient client)
    {
        this.client = client;
    }

    public async Task<IList<ChannelBase>?> GetChannelsAsync(CancellationToken cancellationToken)
    {
        var result = await client.GetChannels(cancellationToken);
        return result.Data;
    }
}
```

## Connectivity Operations

### Channels

```csharp
// Check if channel exists
var exists = await client.IsChannelDefined("MyChannel", cancellationToken);

// Get all channels
var channels = await client.GetChannels(cancellationToken);

// Get specific channel by driver type
var simulatorChannel = await client.GetSimulatorChannel("MySimulator", cancellationToken);
var opcUaChannel = await client.GetOpcUaClientChannel("MyOpcUa", cancellationToken);
var euroMapChannel = await client.GetEuroMap63Channel("MyEuroMap", cancellationToken);

// Create a Simulator channel
var request = new SimulatorChannelRequest("MySimulator")
{
    Description = "Test simulator channel"
};
await client.CreateSimulatorChannel(request, cancellationToken);

// Delete a channel
await client.DeleteChannel("MyChannel", cancellationToken);
```

### Devices

```csharp
// Get all devices for a channel
var devices = await client.GetDevicesByChannelName("MyChannel", cancellationToken);

// Get specific device by driver type
var device = await client.GetSimulatorDevice("MyChannel", "MyDevice", cancellationToken);

// Create a Simulator device
var deviceRequest = new SimulatorDeviceRequest("MyDevice");
await client.CreateSimulatorDevice(deviceRequest, "MyChannel", cancellationToken);

// Delete a device
await client.DeleteDevice("MyChannel", "MyDevice", cancellationToken);
```

### Tags

```csharp
// Get all tags for a device (with max depth for nested groups)
var tags = await client.GetTags("MyChannel", "MyDevice", maxDepth: 5, cancellationToken);

// Search for tags with wildcards
var searchResults = await client.SearchTags(
    channelName: "MyChannel",
    deviceName: "MyDevice",
    query: "*Temperature*",
    cancellationToken);

// Create a tag
var tagRequest = new TagRequest("MyTag")
{
    Address = "R0001",
    DataType = TagDataType.Word,
    ScanRate = 1000,
    Description = "My test tag"
};
await client.CreateTag(
    tagRequest,
    channelName: "MyChannel",
    deviceName: "MyDevice",
    tagGroupStructure: Array.Empty<string>(),
    ensureTagGroupStructure: false,
    cancellationToken);

// Create a tag group
var groupRequest = new TagGroupRequest("MyTagGroup")
{
    Description = "Group for related tags"
};
await client.CreateTagGroup(
    groupRequest,
    channelName: "MyChannel",
    deviceName: "MyDevice",
    tagGroupStructure: Array.Empty<string>(),
    ensureTagGroupStructure: false,
    cancellationToken);

// Delete a tag
await client.DeleteTag("MyChannel", "MyDevice", "MyTag", Array.Empty<string>(), cancellationToken);
```

## IoT Gateway Operations

### IoT Agents

```csharp
// Get all REST client agents
var agents = await client.GetIotAgentRestClients(cancellationToken);

// Get a specific agent
var agent = await client.GetIotAgentRestClient("MyAgent", cancellationToken);

// Create a REST client agent
var agentRequest = new IotAgentRestClientRequest("MyAgent", new Uri("https://my-endpoint.com/data"))
{
    Description = "My REST client agent",
    PublishMessageFormat = IotAgentPublishMessageFormat.Advanced
};
await client.CreateIotAgentRestClient(agentRequest, cancellationToken);

// Enable/disable agent
await client.EnableIotAgentRestClient("MyAgent", cancellationToken);
await client.DisableIotAgentRestClient("MyAgent", cancellationToken);

// Delete agent
await client.DeleteIotAgentRestClient("MyAgent", cancellationToken);
```

### IoT Items

```csharp
// Get all items for an agent
var items = await client.GetIotAgentRestClientIotItems("MyAgent", cancellationToken);

// Create an IoT item
var itemRequest = new IotItemRequest("MyChannel.MyDevice.MyTag")
{
    ScanRate = 5000,
    SendEveryUpdate = true
};
await client.CreateIotAgentRestClientIotItem(itemRequest, "MyAgent", cancellationToken);

// Enable/disable item
await client.EnableIotAgentRestClientIotItem("MyAgent", "MyChannel.MyDevice.MyTag", cancellationToken);
await client.DisableIotAgentRestClientIotItem("MyAgent", "MyChannel.MyDevice.MyTag", cancellationToken);

// Delete item
await client.DeleteIotAgentRestClientIotItem("MyAgent", "MyChannel.MyDevice.MyTag", cancellationToken);
```

## Supported Drivers

The library supports a comprehensive range of Kepware drivers organized by manufacturer and protocol:

### Allen-Bradley / Rockwell Automation
| Driver | Description |
|--------|-------------|
| ControlLogix Ethernet | ControlLogix, CompactLogix, FlexLogix over Ethernet/IP |
| ControlLogix Server Ethernet | Server-side ControlLogix communication |
| Allen-Bradley Ethernet | PLC-5, SLC 500 over Ethernet |
| Micro800 Ethernet | Micro800 series controllers |
| Server Ethernet | Allen-Bradley server communication |
| Bulletin 900 | Bulletin 900 devices |
| Bulletin 1609 | Bulletin 1609 devices |

### Siemens
| Driver | Description |
|--------|-------------|
| S7+ Ethernet | S7-1200/S7-1500 native protocol |
| TCP/IP Ethernet | S7-200/300/400 over TCP/IP |
| TCP/IP Server Ethernet | Server-side Siemens communication |
| Simatic TI505 Ethernet | TI505 series controllers |

### Mitsubishi
| Driver | Description |
|--------|-------------|
| CNC Ethernet | Mitsubishi CNC controllers |
| Ethernet | MELSEC-Q/L/QnA series |
| FX Net | FX series over Ethernet |

### Omron
| Driver | Description |
|--------|-------------|
| FINS Ethernet | CS/CJ/CP series over FINS |
| NJ Ethernet | NJ/NX series controllers |

### Yokogawa
| Driver | Description |
|--------|-------------|
| Cx Ethernet | Cx series |
| Darwin Ethernet | Darwin series recorders |
| Dx Ethernet | Dx series |
| Dxp Ethernet | Dxp series |
| Gx Ethernet | Gx series |
| Mw Ethernet | Mw series |
| Mx Ethernet | Mx series |

### Honeywell
| Driver | Description |
|--------|-------------|
| HC900 Ethernet | HC900 hybrid controller |
| UDC Ethernet | Universal Digital Controller |

### GE
| Driver | Description |
|--------|-------------|
| GE Ethernet | GE PLCs over Ethernet |
| GE Ethernet Global Data | Global Data communication |

### Industrial Protocols
| Driver | Description |
|--------|-------------|
| BACnet IP | Building automation protocol |
| DNP3 Client Ethernet | Distributed Network Protocol |
| IEC 60870-5-104 Client | Power system SCADA protocol |
| IEC 61850 MMS Client | Substation automation |
| Modbus TCP/IP Ethernet | Modbus over TCP/IP |
| SNMP | Simple Network Management Protocol |

### OPC Standards
| Driver | Description |
|--------|-------------|
| OPC DA Client | Classic OPC Data Access |
| OPC UA Client | OPC Unified Architecture |
| OPC XML-DA Client | OPC XML Data Access |

### Industrial IoT / Machine Tool
| Driver | Description |
|--------|-------------|
| MQTT Client | MQTT connectivity driver |
| MTConnect Client | MTConnect machine tool standard |
| EuroMap 63 | Injection molding machine interface |
| KraussMaffei MC4 Ethernet | KraussMaffei injection molding |

### Automation Controllers
| Driver | Description |
|--------|-------------|
| Automation Direct EBC | EBC series |
| Automation Direct ECOM | ECOM series |
| Automation Direct Productivity Series | Productivity series PLCs |
| Beckhoff TwinCAT | TwinCAT ADS protocol |
| Codesys | Codesys runtime |
| Cutler-Hammer ELC Ethernet | ELC series |
| Keyence KV Ethernet | KV series PLCs |
| Opto 22 Ethernet | Opto 22 controllers |
| Toyopuc Ethernet | Toyopuc PLCs |
| Triconex Ethernet | Triconex safety systems |
| Wago Ethernet | Wago controllers |
| Yaskawa MP Series Ethernet | MP series motion controllers |

### Flow Computers / Metering
| Driver | Description |
|--------|-------------|
| ABB Totalflow | ABB Totalflow flow computers |
| Fisher ROC Ethernet | Fisher ROC flow computers over Ethernet |
| Fisher ROC Plus Ethernet | Fisher ROC Plus flow computers over Ethernet |
| Omni Flow Computer | Omni Flow Computer metering |

### CNC / Motion
| Driver | Description |
|--------|-------------|
| FANUC Focas Ethernet | FANUC CNC over Ethernet |
| FANUC Focas HSSB | FANUC CNC over HSSB |
| Toshiba Ethernet | Toshiba controllers |

### Other Drivers
| Driver | Description |
|--------|-------------|
| Alstom Redundant Ethernet | Alstom redundant systems |
| Aromat Ethernet | Aromat/Panasonic PLCs |
| Bristol BSAP IP | Bristol Babcock SCADA |
| Busware Ethernet | Busware devices |
| Custom Interface | Custom driver interface |
| DDE Client | Dynamic Data Exchange |
| Memory Based | In-memory simulation |
| Ping | Network diagnostics |
| SattBus Ethernet | SattBus protocol |
| Scanivalve Ethernet | Scanivalve pressure scanners |
| Simulator | Tag simulation/testing |
| Sixnet Ethertrak | Sixnet I/O |
| System Monitor | System performance monitoring |
| Thermo Westronics Ethernet | Thermo recorders |
| Torque Tool Ethernet | Torque tool integration |
| Wonderware InTouch Client | InTouch connectivity |

# CLI Tool

The `atc-kepware-configuration` CLI tool provides command-line access to all Kepware configuration operations.

## Installation

Install as a .NET global tool:

```bash
dotnet tool install --global atc-kepware-configuration
```

Update to the latest version:

```bash
dotnet tool update --global atc-kepware-configuration
```

## Commands

The CLI is organized into two main command groups. The connectivity group includes subcommands for channels, devices, tags, and meters:

### Connectivity Commands

Manage channels, devices, tags, and meters:

```bash
# List all channels
atc-kepware-configuration connectivity channels get all -s https://localhost:57412/config/v1/

# Get a specific Simulator channel
atc-kepware-configuration connectivity channels get simulator -s <server-url> --name MyChannel

# Create an OPC UA Client channel
atc-kepware-configuration connectivity channels create opcuaclient -s <server-url> --name MyOpcUa --description "OPC UA Channel"

# List devices for a channel
atc-kepware-configuration connectivity devices get all -s <server-url> --channel-name MyChannel

# Get tags for a device
atc-kepware-configuration connectivity tags get -s <server-url> --channel-name MyChannel --device-name MyDevice

# Search for tags
atc-kepware-configuration connectivity tags search -s <server-url> --search "*Temperature*"

# Create a tag
atc-kepware-configuration connectivity tags create tag -s <server-url> \
    --channel-name MyChannel \
    --device-name MyDevice \
    --name MyTag \
    --address R0001 \
    --data-type Word \
    --scan-rate 1000

# Get meters for a flow computer meter group
atc-kepware-configuration connectivity meters get abbtotalflow -s <server-url> \
    --channel-name MyChannel \
    --device-name MyDevice \
    --meter-group-name MyMeterGroup

# Create a meter
atc-kepware-configuration connectivity meters create fisherrocethernet -s <server-url> \
    --channel-name MyChannel \
    --device-name MyDevice \
    --meter-group-name MyMeterGroup \
    --name MyMeter
```

### IoT Gateway Commands

Manage IoT agents and items:

```bash
# List all REST client agents
atc-kepware-configuration iot-gateway iot-agent rest-client all -s <server-url>

# Create a REST client agent
atc-kepware-configuration iot-gateway iot-agent rest-client create -s <server-url> \
    --name MyAgent \
    --url https://my-endpoint.com/data \
    --publish-message-format Advanced

# Enable/disable an agent
atc-kepware-configuration iot-gateway iot-agent rest-client enable -s <server-url> --name MyAgent
atc-kepware-configuration iot-gateway iot-agent rest-client disable -s <server-url> --name MyAgent

# Create an IoT item
atc-kepware-configuration iot-gateway iot-item rest-client create -s <server-url> \
    --iot-agent-name MyAgent \
    --server-tag MyChannel.MyDevice.MyTag \
    --scan-rate 5000

# List all items for an agent
atc-kepware-configuration iot-gateway iot-item rest-client all -s <server-url> --iot-agent-name MyAgent
```

Use `--help` on any command for detailed options:

```bash
atc-kepware-configuration --help
atc-kepware-configuration connectivity --help
atc-kepware-configuration connectivity channels create opcuaclient --help
```

# Sample

See the [sample project](./sample/Atc.Kepware.Sample/) for a complete example demonstrating how to use the library to connect to a Kepware server and retrieve configuration data.

# Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)

# How to contribute

[Contribution Guidelines](https://atc-net.github.io/introduction/about-atc#how-to-contribute)

[Coding Guidelines](https://atc-net.github.io/introduction/about-atc#coding-guidelines)
