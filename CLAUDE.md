# CLAUDE.md -- Polar SDK

## Overview

Auto-generated C# SDK for [Polar](https://www.polar.com/) AccessLink API -- a fitness/health wearable platform providing access to exercise, sleep, heart rate, activity, recovery, and biosensing data. 393 generated files from the official OpenAPI 3.0.0 spec.

## Build & Test

```bash
dotnet build Polar.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (OAuth2 access token):

```csharp
var client = new PolarClient(apiKey); // POLAR_API_KEY env var
```

## Key Files

- `src/libs/Polar/openapi.yaml` -- Downloaded from `https://www.polar.com/accesslink-api/swagger.yaml`
- `src/libs/Polar/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Polar/Generated/` -- **Never edit** -- auto-generated code (393 files)
- `src/libs/Polar/Extensions/PolarClientExtensions.AIFunctions.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints (55 paths)

| Category | Sub-client | Examples |
|----------|-----------|----------|
| Exercises | `client.Exercises` | List exercises, get FIT/GPX/TCX exports |
| Sleep | `client.Sleep` | List nights, get sleep by date, available sleep data |
| Daily Activity | `client.DailyActivity` | List activities, get by date/range, step samples |
| Nightly Recharge | `client.NightlyRecharge` | List recharge data, get by date (HRV, ANS charge) |
| Continuous HR | `client.ContinuousHeartRate` | Get continuous heart rate, get by date |
| Cardio Load | `client.CardioLoad` | Get cardio load, by date, by period (days/months) |
| SleepWise | `client.SleepWiseTrade` | Alertness periods, circadian bedtime |
| Biosensing | `client.ElixirTradeBiosensing` | Body/skin temperature, skin contacts, ECG, SpO2 |
| Physical Info | `client.PhysicalInfo` | Physical information transactions |
| Users | `client.Users` | Register, get info, delete user |
| Webhooks | `client.Webhooks` | Create, update, delete, activate/deactivate |
| Notifications | `client.PullNotifications` | List available data notifications |

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsListExercisesTool()` | Lists exercises/workouts with optional HR samples, zones, GPS route |
| `AsListSleepTool()` | Lists sleep data (duration, stages, interruptions, score) |
| `AsListDailyActivityTool()` | Lists daily activity summaries (steps, calories, active time) |
| `AsListNightlyRechargeTool()` | Lists Nightly Recharge recovery data (HRV, overnight HR, ANS charge) |
