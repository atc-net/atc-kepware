namespace Atc.Kepware.Configuration.Contracts;

public sealed class TagRoot
{
    public TagRoot(
        string deviceName)
    {
        DeviceName = deviceName;
    }

    public string DeviceName { get; }

    public IList<Tag> Tags { get; init; } = new List<Tag>();

    public IList<TagGroup> TagGroups { get; init; } = new List<TagGroup>();
}