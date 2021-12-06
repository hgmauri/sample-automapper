
using Sample.Automapper.Application.ViewModels;

namespace Sample.Automapper.Application.Entities
{
    public class Client
    {
        public virtual Guid Id { get; } = Guid.NewGuid();
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
    }
}
