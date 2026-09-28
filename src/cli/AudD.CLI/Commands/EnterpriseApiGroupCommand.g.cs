#nullable enable

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class EnterpriseApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"enterprise", @"Enterprise endpoint commands.");
                         command.Subcommands.Add(EnterpriseRecognizeEnterpriseCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}