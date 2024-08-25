#nullable disable

namespace Domain.Common;

public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreateAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; private set; } = DateTime.UtcNow;

    public void UpdateTimestamp()
    {
        UpdateAt = DateTime.UtcNow;
    }
}
