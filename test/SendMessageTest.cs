using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Lab3.Domain.Entities.Messengers;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SendMessageTest
{
    private static int messageID = 1;
    public static IEnumerable<object[]> MessageData =>
        new List<object[]>
        {
            new object[]
            {
                new MessageBuilder()
                .WithMessageBody("MESSAGE BODY")
                .WithMessageTitile("MESSAGE TITLE")
                .WithID(messageID)
                .WithImportance(MessageImportant.High)
                .Build(),
            },
        };

    [Theory]
    [MemberData(nameof(MessageData))]
    public void SendMessage(Message message)
    {
        IMessanger messengerMock = Substitute.For<IMessanger>();
        var destination = new DestinationMessenger(messengerMock);

        destination.SendMessage(message);
        messengerMock.Received(1).ReceiveMessage(Arg.Is<IMessage>(msg => msg.Title == message.Title && msg.Body == message.Body));
    }
}
