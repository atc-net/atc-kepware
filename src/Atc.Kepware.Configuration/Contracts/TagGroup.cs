namespace Atc.Kepware.Configuration.Contracts;

public class TagGroup
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public IList<Tag> Tags { get; init; } = new List<Tag>();

    public IList<TagGroup> TagGroups { get; init; } = new List<TagGroup>();
}