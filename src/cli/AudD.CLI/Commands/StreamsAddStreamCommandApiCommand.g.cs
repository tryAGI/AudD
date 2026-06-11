#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class StreamsAddStreamCommandApiCommand
{
    private static Argument<string> Url { get; } = new(
        name: @"url")
    {
        Description = @"Audio stream URL, twitch channel token, or YouTube live stream token.",
    };

    private static Option<long> RadioId { get; } = new(
        name: @"--radio-id")
    {
        Description = @"Caller-supplied integer stream identifier.",
        Required = true,
    };

    private static Option<string?> Callbacks { get; } = new(
        name: @"--callbacks")
    {
        Description = @"Set to before to receive callbacks when a song starts.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AudD.NullResultResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AudD.NullResultResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"add-stream", @"Add stream");
                        command.Arguments.Add(Url);
                        command.Options.Add(RadioId);
                        command.Options.Add(Callbacks);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AudD.AddStreamRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AudD.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = parseResult.GetRequiredValue(Url);
                        var radioId = parseResult.GetRequiredValue(RadioId);
                        var callbacks = CliRuntime.WasSpecified(parseResult, Callbacks) ? parseResult.GetValue(Callbacks) : __requestBase is not null ? __requestBase.Callbacks : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Streams.AddStreamAsync(
                                    url: url,
                                    radioId: radioId,
                                    callbacks: callbacks,
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