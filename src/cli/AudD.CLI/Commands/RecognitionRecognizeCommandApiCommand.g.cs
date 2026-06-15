#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class RecognitionRecognizeCommandApiCommand
{
    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"URL of the file to recognize.",
    };

    private static Option<byte[]?> File { get; } = new(
        name: @"--file")
    {
        Description = @"Audio or video file to recognize.",
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Audio or video file to recognize.",
    };

    private static Option<string?> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Base64-encoded audio. AudD discourages this transport and supports it only in limited cases.",
    };

    private static Option<string?> Return { get; } = new(
        name: @"--return")
    {
        Description = @"Comma-separated additional metadata identifiers.",
    };

    private static Option<string?> Market { get; } = new(
        name: @"--market")
    {
        Description = @"Country code for Apple Music, iTunes, and Spotify results.",
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
        var command = new Command(@"recognize", @"Recognize audio
Recognizes music from a public URL, an uploaded file, or a base64-encoded audio string.");
                        command.Options.Add(Url);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Audio);
                        command.Options.Add(Return);
                        command.Options.Add(Market);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AudD.RecognizeRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AudD.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var file = CliRuntime.WasSpecified(parseResult, File) ? parseResult.GetValue(File) : (__requestBase is { } __FileBaseValue ? __FileBaseValue.File : default);
                        var filename = CliRuntime.WasSpecified(parseResult, Filename) ? parseResult.GetValue(Filename) : (__requestBase is { } __FilenameBaseValue ? __FilenameBaseValue.Filename : default);
                        var audio = CliRuntime.WasSpecified(parseResult, Audio) ? parseResult.GetValue(Audio) : (__requestBase is { } __AudioBaseValue ? __AudioBaseValue.Audio : default);
                        var @return = CliRuntime.WasSpecified(parseResult, Return) ? parseResult.GetValue(Return) : (__requestBase is { } __@returnBaseValue ? __@returnBaseValue.Return : default);
                        var market = CliRuntime.WasSpecified(parseResult, Market) ? parseResult.GetValue(Market) : (__requestBase is { } __MarketBaseValue ? __MarketBaseValue.Market : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recognition.RecognizeAsync(
                                    url: url,
                                    file: file,
                                    filename: filename,
                                    audio: audio,
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