namespace Atc.Kepware.Configuration.Tests.Extensions;

/// <summary>
/// Tests for <see cref="ServiceCollectionExtensions"/>.
/// </summary>
public sealed class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddKepwareConfiguration_WithExplicitParameters_ShouldRegisterClient()
    {
        // Arrange
        var services = new ServiceCollection();
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        services.AddKepwareConfiguration(baseUri, "Admin", "Password");
        using var serviceProvider = services.BuildServiceProvider();

        // Assert
        var client = serviceProvider.GetService<IKepwareConfigurationClient>();
        client.Should().NotBeNull();
        client.Should().BeOfType<KepwareConfigurationClient>();
    }

    [Fact]
    public void AddKepwareConfiguration_WithExplicitParameters_ShouldConfigureConnection()
    {
        // Arrange
        var services = new ServiceCollection();
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        services.AddKepwareConfiguration(baseUri, "Admin", "Password");
        using var serviceProvider = services.BuildServiceProvider();
        var client = serviceProvider.GetRequiredService<IKepwareConfigurationClient>();

        // Assert
        client.IsConnectionInformationConfigured().Should().BeTrue();
    }

    [Fact]
    public void AddKepwareConfiguration_WithOptionsObject_ShouldRegisterClient()
    {
        // Arrange
        var services = new ServiceCollection();
        var options = new KepwareConfigurationOptions
        {
            BaseUri = new Uri("https://localhost:57412/config/v1/"),
            UserName = "Admin",
            Password = "Password",
            DisableCertificateValidationCheck = true,
        };

        // Act
        services.AddKepwareConfiguration(options);
        using var serviceProvider = services.BuildServiceProvider();

        // Assert
        var client = serviceProvider.GetService<IKepwareConfigurationClient>();
        client.Should().NotBeNull();
    }

    [Fact]
    public void AddKepwareConfiguration_WithConfigureAction_ShouldRegisterClient()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddKepwareConfiguration(options =>
        {
            options.BaseUri = new Uri("https://localhost:57412/config/v1/");
            options.UserName = "Admin";
            options.Password = "Password";
        });
        using var serviceProvider = services.BuildServiceProvider();

        // Assert
        var client = serviceProvider.GetService<IKepwareConfigurationClient>();
        client.Should().NotBeNull();
    }

    [Fact]
    public void AddKepwareConfiguration_WithoutBaseUri_ShouldThrowOnResolve()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddKepwareConfiguration(options =>
        {
            // BaseUri not set
            options.UserName = "Admin";
            options.Password = "Password";
        });
        using var serviceProvider = services.BuildServiceProvider();

        // Act
        var act = () => serviceProvider.GetRequiredService<IKepwareConfigurationClient>();

        // Assert
        act.Should().Throw<InvalidOperationException>()
            .WithMessage("*BaseUri*");
    }

    [Fact]
    public void AddKepwareConfiguration_WithNullServices_ShouldThrow()
    {
        // Arrange
        IServiceCollection services = null!;
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        var act = () => services.AddKepwareConfiguration(baseUri, "Admin", "Password");

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName("services");
    }

    [Fact]
    public void AddKepwareConfiguration_WithNullBaseUri_ShouldThrow()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        var act = () => services.AddKepwareConfiguration(null!, "Admin", "Password");

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName("baseUri");
    }

    [Fact]
    public void AddKepwareConfiguration_WithNullOptions_ShouldThrow()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        var act = () => services.AddKepwareConfiguration((KepwareConfigurationOptions)null!);

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName("options");
    }

    [Fact]
    public void AddKepwareConfiguration_WithNullConfigureAction_ShouldThrow()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        var act = () => services.AddKepwareConfiguration((Action<KepwareConfigurationOptions>)null!);

        // Assert
        act.Should().Throw<ArgumentNullException>()
            .WithParameterName("configureOptions");
    }

    [Fact]
    public void AddKepwareConfiguration_ShouldRegisterAsSingleton()
    {
        // Arrange
        var services = new ServiceCollection();
        var baseUri = new Uri("https://localhost:57412/config/v1/");
        services.AddKepwareConfiguration(baseUri, "Admin", "Password");

        // Act
        using var serviceProvider = services.BuildServiceProvider();
        var client1 = serviceProvider.GetRequiredService<IKepwareConfigurationClient>();
        var client2 = serviceProvider.GetRequiredService<IKepwareConfigurationClient>();

        // Assert
        client1.Should().BeSameAs(client2);
    }

    [Fact]
    public void AddKepwareConfiguration_ShouldReturnServiceCollectionForChaining()
    {
        // Arrange
        var services = new ServiceCollection();
        var baseUri = new Uri("https://localhost:57412/config/v1/");

        // Act
        var result = services.AddKepwareConfiguration(baseUri, "Admin", "Password");

        // Assert
        result.Should().BeSameAs(services);
    }
}