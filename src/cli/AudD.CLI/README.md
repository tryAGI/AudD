# AudD.CLI

Command-line interface for the AudD SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global AudD.CLI --prerelease
```

## Usage

```bash
aud-d --help
aud-d enterprise --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
aud-d completion bash > /usr/local/etc/bash_completion.d/aud-d
aud-d completion zsh  > _aud-d   # then put it on your zsh fpath
aud-d completion fish > ~/.config/fish/completions/aud-d.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.