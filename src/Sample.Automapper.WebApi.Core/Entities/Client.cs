
using Sample.Automapper.WebApi.Core.Abstractions;

namespace Sample.Automapper.WebApi.Core.Entities
{
    public class Client
    {
        public virtual Guid Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
    }
}
