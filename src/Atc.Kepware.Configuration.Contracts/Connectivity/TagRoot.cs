namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public sealed class TagRoot
{
    public TagRoot(
        string deviceName)
    {
        DeviceName = deviceName;
    }

    public string DeviceName { get; }

    public IList<Tag> Tags { get; set; } = [];

    public IList<TagGroup> TagGroups { get; set; } = [];
}