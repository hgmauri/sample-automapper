
namespace Sample.Automapper.Application.Entities;

public class Group
{
    public virtual Guid Id { get; } = Guid.NewGuid();
    public virtual DateTime CreatedAt { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Email { get; set; }
}