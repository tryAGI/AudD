#nullable enable

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static class RecognitionApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"recognition", @"Recognition endpoint commands.");
                         command.Subcommands.Add(RecognitionRecognizeCommandApiCommand.Create());
                         command.Subcommands.Add(RecognitionRecognizeByUrlCommandApiCommand.Create());
        return command;
    }
}