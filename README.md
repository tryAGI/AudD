<div class="docs-hero">
  <h1>AudD</h1>
  <p class="docs-hero-lead">Modern .NET SDK for AudD generated from a locally maintained OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/tryAGI.AudD/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/tryAGI.AudD"></a>
    <a href="https://github.com/tryAGI/AudD/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/AudD/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/AudD/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/AudD"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a local OpenAPI definition derived from <a href="https://docs.audd.io/.md">AudD's public HTTP docs</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using AudD;

using var client = new AudDClient(apiToken);

var response = await client.Recognition.RecognizeByUrlAsync(
    url: "https://audd.tech/example.mp3",
    @return: "apple_music,spotify");
```

### CLI

```bash
dotnet tool install --global AudD.CLI --prerelease
aud-d api --help
```

<!-- EXAMPLES:START -->
### Recognize Audio
Basic example showing how to identify a song from an audio URL.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/AudD/issues">tryAGI/AudD</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/AudD/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
