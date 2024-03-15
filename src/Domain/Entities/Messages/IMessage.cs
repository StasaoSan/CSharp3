using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

public interface IMessage
{
    int Id { get; }
    string Title { get; }
    string Body { get; }
    MessageImportant Importance { get; }
}