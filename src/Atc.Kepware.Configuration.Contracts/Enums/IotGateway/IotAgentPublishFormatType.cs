// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Narrow format produces output based on tags that have changed value or quality.
/// Wide format produces output that includes all enabled tags in the agent with every scan
/// regardless of value or quality changes.
/// </summary>
public enum IotAgentPublishFormatType
{
    Narrow = 0,
    Wide = 1,
}