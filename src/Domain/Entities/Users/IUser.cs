using Itmo.ObjectOrientedProgramming.Lab3Lab3.Domain.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Users;

public interface IUser : IEndPointMessage
{
    string Name { get; }
    string Surname { get; }
    void ReadMessage(int id);
}