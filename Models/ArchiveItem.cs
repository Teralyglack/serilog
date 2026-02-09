// Models/ArchiveItem.cs
namespace ArchiveSystem.Models;

public class ArchiveItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public override string ToString() => $"{Id}: {Title}";
}