global using System.ComponentModel.DataAnnotations;
global using System.Diagnostics.CodeAnalysis;
global using System.Net;
global using System.Net.Http.Headers;
global using System.Net.Mime;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;

global using Atc.Data.Models;
global using Atc.Helpers;
global using Atc.Kepware.Configuration.Contracts;
global using Atc.Kepware.Configuration.Contracts.Drivers.EuroMap63;
global using Atc.Kepware.Configuration.Contracts.Drivers.OpcUaClient;
global using Atc.Kepware.Configuration.Contracts.Interfaces;
global using Atc.Kepware.Configuration.Contracts.Interfaces.EuroMap63;
global using Atc.Kepware.Configuration.Contracts.Interfaces.OpcUaClient;
global using Atc.Serialization;

global using Mapster;

global using Microsoft.Extensions.Logging;