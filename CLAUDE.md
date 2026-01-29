# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Atc.Kepware is a .NET library and CLI tool for configuring Kepware servers via REST API. It supports managing connectivity (channels, devices, tags) and IoT Gateway features (agents, items).

## Build Commands

```bash
# Restore and build
dotnet restore
dotnet build

# Build in release mode
dotnet build -c Release

# Run tests
dotnet test -c Release --no-build

# Run a single test (xUnit v3 with Microsoft.Testing.Platform)
dotnet test --filter-method "TestMethodName"

# Clean build
dotnet clean -c Release && dotnet nuget locals all --clear
```

## Project Structure

The solution contains five projects:

- **Atc.Kepware.Configuration** - Main library with `KepwareConfigurationClient` for REST API interactions
- **Atc.Kepware.Configuration.Contracts** - Shared contracts/DTOs used by both library and consumers
- **Atc.Kepware.Configuration.CLI** - CLI tool published as `atc-kepware-configuration` .NET global tool
- **Atc.Kepware.Configuration.Tests** - Unit tests using xUnit v3, FluentAssertions, AutoFixture, NSubstitute
- **Atc.Kepware.Sample** - Sample console application demonstrating library usage

All projects target .NET 10.

## Architecture

### KepwareConfigurationClient

The main client (`Services/KepwareConfigurationClient.cs`) is a partial class split across multiple files:
- Base HTTP operations (Get, Post, Put, Delete) in main file
- Connectivity operations in `Services/Connectivity/KepwareConfigurationClient*.cs`
- IoT Gateway operations in `Services/IotGateway/KepwareConfigurationClient*.cs`

The interface follows the same pattern with `IKepwareConfigurationClient` split into:
- `IKepwareConfigurationClient.cs` - Connection management
- `IKepwareConfigurationClientConnectivity.cs` - Channel/device/tag operations
- `IKepwareConfigurationClientIotGateway.cs` - IoT agent/item operations

### Dependency Injection

Use `ServiceCollectionExtensions.AddKepwareConfiguration()` for DI registration:

```csharp
services.AddKepwareConfiguration(options =>
{
    options.BaseUri = new Uri("https://localhost:57412/config/v1/");
    options.UserName = "Administrator";
    options.Password = string.Empty;
    options.DisableCertificateValidationCheck = true;
});
```

Configuration classes are in `Options/KepwareConfigurationOptions.cs`.

### Driver-Specific Types

Connectivity supports 70+ Kepware drivers organized by manufacturer (Allen-Bradley, Siemens, Mitsubishi, Omron, etc.) and protocol (Modbus, OPC UA, MQTT, etc.). Each driver has:

- **Channels**: `ChannelBase` → driver-specific types (e.g., `EuroMap63Channel`, `OpcUaClientChannel`, `SimulatorChannel`)
- **Devices**: `DeviceBase` → driver-specific types (e.g., `EuroMap63Device`, `OpcUaClientDevice`, `SimulatorDevice`)

Each driver has corresponding request types (`*ChannelRequest`, `*DeviceRequest`) in both the Contracts and main library. See README.md for the complete list of supported drivers.

### CLI Structure

Commands use Spectre.Console and follow a hierarchy pattern:
- `connectivity channels|devices|tags` - Manage connectivity resources
- `iot-gateway iot-agent|iot-item` - Manage IoT Gateway resources

Command implementations are organized in hierarchical folders:
- `Commands/Connectivity/Channels/Create/` - Channel creation commands
- `Commands/Connectivity/Channels/Retrieve/` - Channel retrieval commands
- `Commands/Connectivity/Channels/Delete/` - Channel deletion commands
- `Commands/Connectivity/Devices/Create/`, `/Retrieve/`, `/Delete/` - Device commands
- `Commands/IotGateway/IotAgent/`, `Commands/IotGateway/IotItem/` - IoT commands

Settings classes are in `Commands/Settings/`. Command registration is centralized in `Extensions/CommandAppExtensions.cs`.

All CLI commands inherit from `AsyncCommand<TSettings>` and must implement `ExecuteAsync` with a `CancellationToken` parameter.

### Contracts vs KepwareContracts

- `Atc.Kepware.Configuration.Contracts/` - Public contracts for library consumers
- `Atc.Kepware.Configuration/KepwareContracts/` - Internal contracts for Kepware REST API serialization

Mapster is used to map between these two contract types.

## Code Style

- Uses ATC coding rules (see `.editorconfig`) with strict analyzer settings
- File-scoped namespaces
- Nullable enabled throughout
- C# 14 / LangVersion 14.0
- Warnings treated as errors in Release builds
- Uses StyleCop, Meziantou, SonarAnalyzer, Atc.Analyzer, and other analyzers
- Single parameters should be on same line if total line length < 80 characters (ATC201)
- Files must not end with trailing newlines (SA1518)

## Versioning

Uses release-please for automatic version management. Version is defined in `Directory.Build.props` with release-please markers.

## Test Framework

Tests use:
- xUnit v3 with Microsoft.Testing.Platform
- FluentAssertions for assertions
- AutoFixture with xUnit3 integration for test data
- NSubstitute for mocking
- Atc.Test and Atc.XUnit utilities

Global usings for test projects are configured in `test/Directory.Build.props`.