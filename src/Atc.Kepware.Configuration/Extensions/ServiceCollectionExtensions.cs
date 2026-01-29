// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration;

/// <summary>
/// Extension methods for configuring Kepware Configuration services in an <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds and configures the Kepware Configuration Client to the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <param name="baseUri">The base URI of the Kepware server.</param>
    /// <param name="userName">The username for authentication.</param>
    /// <param name="password">The password for authentication.</param>
    /// <param name="disableCertificateValidationCheck">
    /// Whether to disable SSL/TLS certificate validation. Defaults to <c>true</c>.
    /// </param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddKepwareConfiguration(
        this IServiceCollection services,
        Uri baseUri,
        string? userName,
        string? password,
        bool disableCertificateValidationCheck = true)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(baseUri);

        services.AddOptions<KepwareConfigurationOptions>().Configure(options =>
        {
            options.BaseUri = baseUri;
            options.UserName = userName;
            options.Password = password;
            options.DisableCertificateValidationCheck = disableCertificateValidationCheck;
        });

        return services.AddKepwareServices();
    }

    /// <summary>
    /// Adds and configures the Kepware Configuration Client to the specified <see cref="IServiceCollection"/>
    /// using a pre-configured <see cref="KepwareConfigurationOptions"/> instance.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <param name="options">The pre-configured <see cref="KepwareConfigurationOptions"/>.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddKepwareConfiguration(
        this IServiceCollection services,
        KepwareConfigurationOptions options)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(options);

        services.AddOptions<KepwareConfigurationOptions>().Configure(o =>
        {
            o.BaseUri = options.BaseUri;
            o.UserName = options.UserName;
            o.Password = options.Password;
            o.DisableCertificateValidationCheck = options.DisableCertificateValidationCheck;
        });

        return services.AddKepwareServices();
    }

    /// <summary>
    /// Adds and configures the Kepware Configuration Client to the specified <see cref="IServiceCollection"/>
    /// using an <see cref="Action{KepwareConfigurationOptions}"/> delegate.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <param name="configureOptions">An action to configure the <see cref="KepwareConfigurationOptions"/>.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddKepwareConfiguration(
        this IServiceCollection services,
        Action<KepwareConfigurationOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);

        services.AddOptions<KepwareConfigurationOptions>().Configure(configureOptions);

        return services.AddKepwareServices();
    }

    private static IServiceCollection AddKepwareServices(
        this IServiceCollection services)
    {
        services.AddSingleton<IKepwareConfigurationClient>(sp =>
        {
            var loggerFactory = sp.GetService<ILoggerFactory>() ?? new NullLoggerFactory();
            var options = sp.GetRequiredService<IOptions<KepwareConfigurationOptions>>().Value;

            if (options.BaseUri is null)
            {
                throw new InvalidOperationException(
                    $"{nameof(KepwareConfigurationOptions)}.{nameof(KepwareConfigurationOptions.BaseUri)} must be configured.");
            }

            return new KepwareConfigurationClient(
                loggerFactory,
                options.BaseUri,
                options.UserName,
                options.Password,
                options.DisableCertificateValidationCheck);
        });

        return services;
    }
}