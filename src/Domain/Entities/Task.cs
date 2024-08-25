#nullable disable

using Domain.Common;

namespace Domain.Entities;

public class Task(string title, string description, bool isCompleted) : BaseEntity<int>()
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public bool IsCompleted { get; set; } = isCompleted;
}
