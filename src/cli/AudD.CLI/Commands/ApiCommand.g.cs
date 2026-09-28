#nullable enable

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(EnterpriseApiGroupCommand.Create());
                         command.Subcommands.Add(RecognitionApiGroupCommand.Create());
                         command.Subcommands.Add(StreamsApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}