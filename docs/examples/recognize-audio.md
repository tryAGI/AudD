# Recognize Audio

Basic example showing how to identify a song from an audio URL.

This example assumes `using AudD;` is in scope and `apiKey` contains your AudD API key.

```csharp
var apiToken =
    Environment.GetEnvironmentVariable("AUDD_API_TOKEN") is { Length: > 0 } tokenValue ? tokenValue :
    Environment.GetEnvironmentVariable("AUDD_API_KEY") is { Length: > 0 } keyValue ? keyValue :
    throw new AssertInconclusiveException("AUDD_API_TOKEN environment variable is not found.");

using var client = new AudDClient(apiToken);

// Recognize a short audio sample by URL. Additional providers such as
// Apple Music or Spotify can be requested with the return parameter.
var response = await client.Recognition.RecognizeByUrlAsync(
    url: "https://audd.tech/example.mp3",
    @return: "apple_music,spotify");
```