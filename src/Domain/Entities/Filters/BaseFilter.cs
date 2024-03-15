using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Filters;

public abstract class BaseFilter
{
    public abstract bool Check(IMessage message);
}