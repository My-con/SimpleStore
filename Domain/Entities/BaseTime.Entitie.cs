using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public abstract class BaseTimeEntitie
{
    [Required]
    [DataType(DataType.DateTime)]
    public DateTimeOffset DateCreated { get; } = DateTime.UtcNow;
    [DataType(DataType.DateTime)]
    [AllowNull]
    public DateTimeOffset? DateUpdated { get; set; }
    [DataType(DataType.DateTime)]
    [AllowNull]
    public DateTimeOffset? DateDeleted { get; set; }
}