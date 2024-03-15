using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Filters;

public class FilterByImportant : BaseFilter
{
    private readonly MessageImportant _important;

    public FilterByImportant(MessageImportant importance)
    {
        _important = importance;
    }

    public override bool Check(IMessage message)
    {
        return message.Importance == _important;
    }
}