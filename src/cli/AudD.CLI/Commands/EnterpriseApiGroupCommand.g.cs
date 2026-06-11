#nullable enable

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static class EnterpriseApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"enterprise", @"Enterprise endpoint commands.");
                         command.Subcommands.Add(EnterpriseRecognizeEnterpriseCommandApiCommand.Create());
        return command;
    }
}