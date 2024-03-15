using System;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class TwiceReadIsError
{
    public static TheoryData<Message> MessageData()
    {
        return new TheoryData<Message>
        {
            {
                new MessageBuilder()
                    .WithID(1)
                    .WithImportance(MessageImportant.Medium)
                    .WithMessageBody("Test Body")
                    .WithMessageTitile("Test Title")
                    .Build()
            },
            {
                new MessageBuilder()
                    .WithID(2)
                    .WithImportance(MessageImportant.High)
                    .WithMessageBody("Another Test Body")
                    .WithMessageTitile("Another Test Title")
                    .Build()
            },
        };
    }

    [Theory]
    [MemberData(nameof(MessageData))]
    public void TwiceReadIsErrorTest(Message message)
    {
        Logger loggerMock = Substitute.For<Logger>();
        var user = new User("John", "Doe", loggerMock);
        user.ReceiveMessage(message);
        user.ReadMessage(message.Id);
        AggregateException ex = Assert.Throws<AggregateException>(() => user.ReadMessage(message.Id));
        Assert.Equal("This message already read", ex.Message);
    }
}