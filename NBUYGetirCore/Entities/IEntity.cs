using NBUYGetirCore.Events;
using System.Collections.Generic;

namespace NBUYGetirCore.Entities
{
    public interface IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }
    }
}