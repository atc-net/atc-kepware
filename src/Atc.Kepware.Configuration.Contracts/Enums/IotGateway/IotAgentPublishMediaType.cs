// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the content-type header of the REST client to be specific for the output of the template.
/// </summary>
/// <remarks>
/// This setting is only valid for <see cref="IotAgentPublishMessageFormatType.Advanced"/>.
/// This setting is not available under the MQTT Advanced template as it does not apply.
/// </remarks>
public enum IotAgentPublishMediaType
{
    [Description("application/json")]
    Json = 0,

    [Description("application/xml")]
    Xml = 1,

    [Description("application/xhtml+xml")]
    XhtmlXml = 2,

    [Description("text/plain")]
    TextPlain = 3,

    [Description("text/html")]
    TextHtml = 4,
}