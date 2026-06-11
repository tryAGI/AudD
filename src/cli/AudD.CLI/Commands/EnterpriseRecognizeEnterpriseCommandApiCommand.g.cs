#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AudD.CLI.Commands;

internal static partial class EnterpriseRecognizeEnterpriseCommandApiCommand
{
    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"URL of the file or page to scan.",
    };

    private static Option<byte[]?> File { get; } = new(
        name: @"--file")
    {
        Description = @"Audio or video file to scan.",
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Audio or video file to scan.",
    };

    private static Option<string?> AccurateOffsets { get; } = new(
        name: @"--accurate-offsets")
    {
        Description = @"Set to true to request accurate start and end offsets.",
    };

    private static Option<int?> Skip { get; } = new(
        name: @"--skip")
    {
        Description = @"Number of 12-second chunks skipped after recognized chunks.",
    };

    private static Option<int?> Every { get; } = new(
        name: @"--every")
    {
        Description = @"Number of chunks to recognize in a row.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Upper bound for the number of chunks to recognize.",
    };

    private static Option<int?> SkipFirstSeconds { get; } = new(
        name: @"--skip-first-seconds")
    {
        Description = @"Seconds to skip before starting recognition.",
    };

    private static Option<string?> UseTimecode { get; } = new(
        name: @"--use-timecode")
    {
        Description = @"Set to true to use time information from the submitted URL as skip_first_seconds.",
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

                    private static string FormatResponse(ParseResult parseResult, global::AudD.EnterpriseRecognitionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AudD.EnterpriseRecognitionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"recognize-enterprise", @"Recognize long audio or video
Recognizes music from long audio and video files using AudD's enterprise endpoint.");
                        command.Options.Add(Url);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(AccurateOffsets);
                        command.Options.Add(Skip);
                        command.Options.Add(Every);
                        command.Options.Add(Limit);
                        command.Options.Add(SkipFirstSeconds);
                        command.Options.Add(UseTimecode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AudD.EnterpriseRecognizeRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AudD.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : __requestBase is not null ? __requestBase.Url : default;
                        var file = CliRuntime.WasSpecified(parseResult, File) ? parseResult.GetValue(File) : __requestBase is not null ? __requestBase.File : default;
                        var filename = CliRuntime.WasSpecified(parseResult, Filename) ? parseResult.GetValue(Filename) : __requestBase is not null ? __requestBase.Filename : default;
                        var accurateOffsets = CliRuntime.WasSpecified(parseResult, AccurateOffsets) ? parseResult.GetValue(AccurateOffsets) : __requestBase is not null ? __requestBase.AccurateOffsets : default;
                        var skip = CliRuntime.WasSpecified(parseResult, Skip) ? parseResult.GetValue(Skip) : __requestBase is not null ? __requestBase.Skip : default;
                        var every = CliRuntime.WasSpecified(parseResult, Every) ? parseResult.GetValue(Every) : __requestBase is not null ? __requestBase.Every : default;
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : __requestBase is not null ? __requestBase.Limit : default;
                        var skipFirstSeconds = CliRuntime.WasSpecified(parseResult, SkipFirstSeconds) ? parseResult.GetValue(SkipFirstSeconds) : __requestBase is not null ? __requestBase.SkipFirstSeconds : default;
                        var useTimecode = CliRuntime.WasSpecified(parseResult, UseTimecode) ? parseResult.GetValue(UseTimecode) : __requestBase is not null ? __requestBase.UseTimecode : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Enterprise.RecognizeEnterpriseAsync(
                                    url: url,
                                    file: file,
                                    filename: filename,
                                    accurateOffsets: accurateOffsets,
                                    skip: skip,
                                    every: every,
                                    limit: limit,
                                    skipFirstSeconds: skipFirstSeconds,
                                    useTimecode: useTimecode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AudD.SourceGenerationContext.Default,
                                        @"Result",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AudD.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}