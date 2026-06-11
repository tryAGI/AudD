#nullable enable

using System.CommandLine;
using AudD.CLI;
using AudD.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the AudD SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(EnterpriseApiGroupCommand.Create());
rootCommand.Subcommands.Add(RecognitionApiGroupCommand.Create());
rootCommand.Subcommands.Add(StreamsApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);