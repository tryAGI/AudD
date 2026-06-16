#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://docs.audd.io/.
install_autosdk_cli

rm -rf Generated

# AudD has public HTTP docs but no published OpenAPI document.
# Auth: api_token is accepted as a query parameter by every API method.
autosdk generate openapi.yaml \
  --namespace AudD \
  --clientClassName AudDClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Query:api_token

rm -rf ../../cli/AudD.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/AudD.CLI \
  --sdk-project ../../libs/AudD/AudD.csproj \
  --targetFramework net10.0 \
  --namespace AudD \
  --clientClassName AudDClient \
  --package-id AudD.CLI \
  --tool-command-name aud-d \
  --user-secrets-id AudD.CLI \
  --api-key-env-var AUDD_API_KEY \
  --base-url-env-var AUDD_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Query:api_token
