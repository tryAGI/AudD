#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class StreamsLongPollCommandApiCommand
{
    private static Option<string> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Longpoll category from getStreams or derived from the API token and radio id.",
        Required = true,
    };

    private static Option<int?> Timeout { get; } = new(
        name: @"--timeout")
    {
        Description = @"Long poll timeout in seconds.",
    };

    private static Option<long?> SinceTime { get; } = new(
        name: @"--since-time")
    {
        Description = @"Timestamp from the previous longpoll response.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AudD.LongPollResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AudD.LongPollResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"long-poll", @"Long poll stream results
Reads stream recognition callbacks via long polling. This endpoint uses a longpoll category, not the API token.");
                        command.Options.Add(Category);
                        command.Options.Add(Timeout);
                        command.Options.Add(SinceTime);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var category = parseResult.GetRequiredValue(Category);
                        var timeout = parseResult.GetValue(Timeout);
                        var sinceTime = parseResult.GetValue(SinceTime);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Streams.LongPollAsync(
                                    category: category,
                                    timeout: timeout,
                                    sinceTime: sinceTime,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AudD.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}