namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.OpcXmlDaClient;

/// <summary>
/// Specifies the item path delimiter used in the tag address format ItemPath + Delimiter + ItemName.
/// </summary>
public enum OpcXmlDaClientItemPathDelimiter
{
    /// <summary>
    /// Backslash delimiter (\).
    /// </summary>
    Backslash = 0,

    /// <summary>
    /// Forward slash delimiter (/).
    /// </summary>
    ForwardSlash = 1,

    /// <summary>
    /// Exclamation mark delimiter (!).
    /// </summary>
    Exclamation = 2,

    /// <summary>
    /// Pipe delimiter (|).
    /// </summary>
    Pipe = 3,

    /// <summary>
    /// Comma delimiter (,).
    /// </summary>
    Comma = 4,

    /// <summary>
    /// Underscore delimiter (_).
    /// </summary>
    Underscore = 5,

    /// <summary>
    /// Hyphen delimiter (-).
    /// </summary>
    Hyphen = 6,
}
