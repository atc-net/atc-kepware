namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// IKepwareConfigurationClient - Handles connection information.
/// </summary>
public partial interface IKepwareConfigurationClient
{
    bool IsConnectionInformationConfigured();

    void SetConnectionInformation(
        Uri baseUri,
        string? userName,
        string? password,
        bool disableCertificateValidationCheck = true);
}