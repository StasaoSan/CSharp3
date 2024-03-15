using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class GetLogWhenDestinationAdress
{
    public static IEnumerable<object[]> LoggingData =>
        new List<object[]>
        {
            new object[] { Substitute.For<IMessage>() },
        };

    [Theory]
    [MemberData(nameof(LoggingData))]
    public void GetLogWhenDestinationAdressTest(IMessage messageMock)
    {
        messageMock.Title.Returns("Sample Title");
        messageMock.Body.Returns("Sample Body");

        IHandler handlerMock = Substitute.For<IHandler>();

        var logger = new Logger();
        logger.AddHandler(handlerMock);

        var display = new Display(new ConsoleDisplayDriver(ConsoleColor.Red));
        var destinationDisplay = new DestinationDisplay(display);
        var destinationLogger = new DestinationLogger(destinationDisplay, logger);

        destinationLogger.SendMessage(messageMock);
        logger.FlushLogs();
        handlerMock.Received(1).Log(Arg.Any<string>());

        logger.ClearHandlers();
    }
}