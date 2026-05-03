#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://docs.audd.io/.

dotnet tool install --global autosdk.cli --prerelease

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
