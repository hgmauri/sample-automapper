﻿
using Sample.Automapper.WebApi.Core.Abstractions;

namespace Sample.Automapper.WebApi.Core.ViewModels
{
    public class ClientViewModel
    {
        public virtual string? Name { get; set; }
        public virtual string? Email { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
    }
}
