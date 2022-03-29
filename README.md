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
    channels    Commands for channels
    devices     Commands for devices
    tags        Commands for tags
```

#### Command <span style="color:yellow">channels</span>

```powershell
atc-kepware-configuration channels --help


USAGE:
    atc-kepware-configuration.exe channels [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe channels get all -s [server-url] 
    atc-kepware-configuration.exe channels get euromap63 -s [server-url] --name [channelName]
    atc-kepware-configuration.exe channels get opcuaclient -s [server-url] --name [channelName]
    atc-kepware-configuration.exe channels create euromap63 -s [server-url] --name [channelName] --description [description]
    atc-kepware-configuration.exe channels create opcuaclient -s [server-url] --name [channelName] --description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Operations related to retrieving channels
    create    Operations related to creating channels
    delete    Delete channel
```

#### Command <span style="color:yellow">devices</span>

```powershell
atc-kepware-configuration devices --help


USAGE:
    atc-kepware-configuration.exe devices [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe devices get all -s [server-url] --channel-name [channelName]
    atc-kepware-configuration.exe devices get euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]
    atc-kepware-configuration.exe devices get opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]
    atc-kepware-configuration.exe devices create euromap63 -s [server-url] --channel-name [channelName] --device-name [deviceName]
--description [description] --session-file-path [filePath]
    atc-kepware-configuration.exe devices create opcuaclient -s [server-url] --channel-name [channelName] --device-name [deviceName]
--description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Operations related to retrieving devices
    create    Operations related to creating devices
    delete    Delete device from channel
```

#### Command <span style="color:yellow">tags</span>

```powershell
atc-kepware-configuration tags --help


USAGE:
    atc-kepware-configuration.exe tags [OPTIONS] <COMMAND>

EXAMPLES:
    atc-kepware-configuration.exe tags search -s [server-url] --search MyTag
    atc-kepware-configuration.exe tags search -s [server-url] --search *Tag
    atc-kepware-configuration.exe tags search -s [server-url] --search My*
    atc-kepware-configuration.exe tags search -s [server-url] --search *yt*
    atc-kepware-configuration.exe tags create tag -s [server-url] --channel-name [channelName] --device-name [deviceName] --name [tagName]
--address [tagAddress] --scan-rate [scanRate] --data-type [dataType] --client-access [clientAccess] --description [description]

OPTIONS:
    -h, --help    Prints help information

COMMANDS:
    get       Get tags for channel and device
    create    Operations related to creating tags and tag groups
    delete    Operations related to deleting tags and tag groups
    search    Search tags
```

## How to contribute

[Contribution Guidelines](https://atc-net.github.io/introduction/about-atc#how-to-contribute)

[Coding Guidelines](https://atc-net.github.io/introduction/about-atc#coding-guidelines)
