namespace Atc.Kepware.Configuration.Services;

public static class KepwareConfigurationValidationHelper
{
    public static string? GetErrorForName(
        string parameterValue)
        => GetErrorForName("name", parameterValue);

    public static string? GetErrorForName(
        string parameterName,
        string parameterValue)
    {
        if (string.IsNullOrEmpty(parameterValue))
        {
            return $"--{parameterName} is not set.";
        }

        if (parameterValue.StartsWith('_'))
        {
            return $"--{parameterName} cannot start with: '_'";
        }

        if (parameterValue.Contains(' ', StringComparison.Ordinal) ||
            parameterValue.Contains('.', StringComparison.Ordinal) ||
            parameterValue.Contains('@', StringComparison.Ordinal) ||
            parameterValue.Contains('\'', StringComparison.Ordinal))
        {
            return $"--{parameterName} cannot contain: ' ', '.', '@', '\''";
        }

        return null;
    }
}