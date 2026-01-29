using var cts = new CancellationTokenSource();
var cancellationToken = cts.Token;

Console.CancelKeyPress += (_, e) =>
{
    Console.WriteLine("\nCancellation requested...");
    //// ReSharper disable once AccessToDisposedClosure
    cts.Cancel();
    e.Cancel = true;
};

var services = new ServiceCollection();

services.AddLogging(builder =>
{
    builder.AddConsole();
    builder.SetMinimumLevel(LogLevel.Debug);
});

// Configure Kepware client using ServiceCollection extensions
services.AddKepwareConfiguration(options =>
{
    options.BaseUri = new Uri("https://localhost:57412/config/v1/");
    options.UserName = "Administrator";
    options.Password = string.Empty;
    options.DisableCertificateValidationCheck = true;
});

var serviceProvider = services.BuildServiceProvider();

// Resolve the client from DI
var client = serviceProvider.GetRequiredService<IKepwareConfigurationClient>();

try
{
    // Get all channels
    Console.WriteLine("Fetching channels...");

    var channelsResult = await client.GetChannels(cancellationToken);

    if (channelsResult is not { CommunicationSucceeded: true, HasData: true })
    {
        Console.WriteLine($"Failed to get channels: {channelsResult.StatusCode}");
        return;
    }

    Console.WriteLine($"Found {channelsResult.Data!.Count} channel(s):");

    foreach (var channel in channelsResult.Data)
    {
        cancellationToken.ThrowIfCancellationRequested();

        Console.WriteLine($"  - {channel.Name} (Driver: {channel.DeviceDriver})");

        var devicesResult = await client.GetDevicesByChannelName(channel.Name, cancellationToken);

        if (devicesResult is { CommunicationSucceeded: true, HasData: true })
        {
            Console.WriteLine($"    Devices ({devicesResult.Data!.Count}):");

            foreach (var device in devicesResult.Data)
            {
                cancellationToken.ThrowIfCancellationRequested();

                Console.WriteLine($"      - {device.Name}");

                // Get tags for this device (max depth 3)
                var tagsResult = await client.GetTags(channel.Name, device.Name, maxDepth: 3, cancellationToken);

                if (tagsResult is { CommunicationSucceeded: true, HasData: true })
                {
                    var tagCount = tagsResult.Data!.Tags.Count;
                    var groupCount = tagsResult.Data.TagGroups.Count;
                    Console.WriteLine($"        Tags: {tagCount}, Tag Groups: {groupCount}");
                }
            }
        }
    }
}
catch (OperationCanceledException)
{
    Console.WriteLine("Operation was cancelled.");
}