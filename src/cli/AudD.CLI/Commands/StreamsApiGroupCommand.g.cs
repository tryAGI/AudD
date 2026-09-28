#nullable enable

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class StreamsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"streams", @"Streams endpoint commands.");
                         command.Subcommands.Add(StreamsAddStreamCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsDeleteStreamCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsGetCallbackUrlCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsGetStreamsCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsLongPollCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsSetCallbackUrlCommandApiCommand.Create());
                         command.Subcommands.Add(StreamsSetStreamUrlCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}