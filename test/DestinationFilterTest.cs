using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations.Filters;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Filters;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class DestinationFilterTest
{
    private const int _expectedCountHigh = 1;
    private const int _expectedCountNonHigh = 0;

    public static IEnumerable<object[]> MessageData =>
        new List<object[]>
        {
            new object[] { MessageImportant.Low, _expectedCountNonHigh },
            new object[] { MessageImportant.Medium, _expectedCountNonHigh },
            new object[] { MessageImportant.High, _expectedCountHigh },
        };

    [Theory]
    [MemberData(nameof(MessageData))]
    public void ImportantMessageFilterTest(MessageImportant importance, int expectedSendCount)
    {
        IMessage messageMock = Substitute.For<IMessage>();
        messageMock.Importance.Returns(importance);

        IDestination destinationMock = Substitute.For<IDestination>();
        var filter = new FilterByImportant(MessageImportant.High);
        var filteredDestination = new DestinationProxyFilter(destinationMock, new List<BaseFilter> { filter });

        filteredDestination.SendMessage(messageMock);

        destinationMock.Received(expectedSendCount).SendMessage(Arg.Any<IMessage>());
    }
}