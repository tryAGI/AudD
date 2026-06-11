#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class RecognitionRecognizeByUrlCommandApiCommand
{
    private static Option<string> Url { get; } = new(
        name: @"--url")
    {
        Description = @"URL of the file to recognize.",
        Required = true,
    };

    private static Option<string?> Return { get; } = new(
        name: @"--return")
    {
        Description = @"Comma-separated additional metadata identifiers, such as apple_music, spotify, deezer, napster, or musicbrainz.",
    };

    private static Option<string?> Market { get; } = new(
        name: @"--market")
    {
        Description = @"Country code for Apple Music, iTunes, and Spotify results.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::AudD.RecognitionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AudD.RecognitionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"recognize-by-url", @"Recognize audio by URL
Recognizes music from a public audio or video URL.");
                        command.Options.Add(Url);
                        command.Options.Add(Return);
                        command.Options.Add(Market);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var url = parseResult.GetRequiredValue(Url);
                        var @return = parseResult.GetValue(Return);
                        var market = parseResult.GetValue(Market);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recognition.RecognizeByUrlAsync(
                                    url: url,
                                    @return: @return,
                                    market: market,
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