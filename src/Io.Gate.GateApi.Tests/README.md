# Gate.io C# API Client - Unit & Integration Tests

This document describes the test project for the Gate.io C# API client library (`Io.Gate.GateApi`).

---

## Overview

The test project `Io.Gate.GateApi.Tests` provides comprehensive unit and integration tests for the Gate.io C# SDK. It covers:

- **Client infrastructure**: Configuration, authentication (HMAC-SHA512), exceptions, utilities
- **Model serialization**: JSON round-trip tests for representative model classes
- **API routing**: Verifies correct HTTP paths, parameters, and auth flags
- **Integration**: Real API calls to Gate.io public and authenticated endpoints

---

## Prerequisites

- **.NET 10 SDK** (or later)
- **Internet connection** (for integration tests only)
- **Gate.io API keys** (for authenticated integration tests only)

---

## Project Structure

```
Io.Gate.GateApi.Tests/
├── README.md                        # This file
├── Io.Gate.GateApi.Tests.csproj
├── Client/                          # Client infrastructure unit tests
│   ├── ConfigurationTests.cs
│   ├── GlobalConfigurationTests.cs
│   ├── AuthenticationTests.cs       # HMAC-SHA512 signing verification
│   ├── ApiClientTests.cs
│   ├── GateApiExceptionTests.cs
│   ├── ApiExceptionTests.cs
│   ├── ClientUtilsTests.cs
│   ├── MultimapTests.cs
│   └── RequestOptionsTests.cs
├── Model/                           # Model serialization unit tests
│   ├── OrderTests.cs
│   ├── TradeTests.cs
│   ├── TickerTests.cs
│   ├── CurrencyPairTests.cs
│   ├── SpotAccountTests.cs
│   ├── OrderBookTests.cs
│   └── ContractTests.cs
├── Api/                             # API routing unit tests (mocked HTTP)
│   ├── SpotApiTests.cs
│   ├── FuturesApiTests.cs
│   └── AccountApiTests.cs
├── Integration/                     # Real API call tests
│   ├── SpotApiIntegrationTests.cs
│   ├── FuturesApiIntegrationTests.cs
│   ├── AccountApiIntegrationTests.cs
│   └── WalletApiIntegrationTests.cs
└── Helpers/
    ├── TestDataFactory.cs           # Sample objects and JSON strings
    └── IntegrationTestBase.cs       # Base class for integration tests
```

---

## Test Categories

| Category | Network | API Keys | CI-Safe | Description |
|----------|:-------:|:--------:|:-------:|-------------|
| `Unit` | No | No | Yes | All unit tests (client, model, API routing) |
| `Integration` | Yes | No | No | Public API endpoints (tickers, currencies, order books) |
| `IntegrationAuth` | Yes | Yes | No | Authenticated read-only endpoints (account, balances) |

---

## Running Tests

### All tests

From the repository root:

```bash
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj
```

### By category

```bash
# Unit tests only (no network required, CI-safe)
dotnet test --filter "TestCategory=Unit"

# Public API integration tests (needs internet, no API keys)
dotnet test --filter "TestCategory=Integration"

# Authenticated integration tests (needs internet + API keys)
dotnet test --filter "TestCategory=IntegrationAuth"

# Everything except authenticated tests
dotnet test --filter "TestCategory!=IntegrationAuth"
```

### With code coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
```

---

## API Keys

### Unit Tests

**No API keys are required.** All unit tests use synthetic test credentials (`"test-api-key"` / `"test-api-secret"`) that are never sent to any real endpoint.

### Integration Tests (Public)

**No API keys are required.** These tests call public Gate.io API endpoints (market data, tickers, order books) that do not require authentication.

### Integration Tests (Authenticated)

These tests require valid Gate.io API keys to verify that authentication works end-to-end. Set them as environment variables:

```bash
# Windows (PowerShell)
$env:GATE_API_KEY = "your-api-key"
$env:GATE_API_SECRET = "your-api-secret"

# Windows (CMD)
set GATE_API_KEY=your-api-key
set GATE_API_SECRET=your-api-secret

# Linux / macOS
export GATE_API_KEY="your-api-key"
export GATE_API_SECRET="your-api-secret"
```

If the environment variables are not set, authenticated tests will be reported as **Inconclusive** (skipped), not failed.

### Security Warning

- **Use read-only API keys.** Never enable trading or withdrawal permissions on keys used for testing.
- API keys are **never** logged, committed, or hardcoded in test code.
- The integration tests only call **read-only GET endpoints**. They never create orders, transfers, or withdrawals.
- Do not commit `.env` files or any file containing API keys.

### How to get API keys

1. Log in to your Gate.io account
2. Navigate to **API Management** (under account settings)
3. Create a new API key with **read-only permissions only**
4. Copy the API Key and Secret

---

## Test Design Philosophy

### Unit Tests

- **No real API calls** - HTTP layer is mocked using Moq with `ISynchronousClient` / `IAsynchronousClient` interfaces
- **Authentication tests** use reflection to call the private `ApplyApiV4Auth` method and verify HMAC-SHA512 signatures
- **Model tests** verify JSON serialization round-trips using Newtonsoft.Json with the same settings as the library
- **Representative coverage** - 7 of 254 models are tested, covering all structural patterns (enums, required fields, nested collections, etc.)

### Integration Tests

- **Read-only only** - tests only call GET endpoints, never POST/PUT/DELETE
- **Graceful degradation** - authenticated tests skip with `Assert.Inconclusive` when API keys are missing
- **Real deserialization** - verifies that actual API responses deserialize correctly into SDK model objects

---

## Rate Limiting

Gate.io enforces API rate limits. If you run integration tests frequently, you may encounter HTTP 429 (Too Many Requests) errors. Strategies:

- Run integration tests selectively, not in a loop
- Add delays between test runs if needed
- Unit tests have no rate limit concerns (no network calls)

---

## Dependencies

| Package | Version | Purpose |
|---------|---------|---------|
| `MSTest` | 3.x | Test framework (single package) |
| `Moq` | 4.x | Mocking framework for interfaces |
| `coverlet.collector` | 6.x | Code coverage collection |

---

## Contributing New Tests

### Adding tests for a new model

1. Create a new file in `Model/` following the existing pattern (e.g., `OrderTests.cs`)
2. Test: construction, JSON round-trip, enum serialization, `Equals`, `GetHashCode`, `ToString`
3. Add `[TestCategory("Unit")]` to every test method
4. Add sample JSON to `TestDataFactory` if needed

### Adding tests for a new API endpoint

1. Add a unit test in the appropriate file under `Api/` using Moq
2. Verify the correct HTTP path, query parameters, and `RequireApiV4Auth` flag
3. For public endpoints, add an integration test under `Integration/`
4. For authenticated endpoints, use `[TestCategory("IntegrationAuth")]` and call `RequireApiKeys()`

### General guidelines

- Every test must have a `[TestCategory]` attribute
- Tests must be independent - no shared mutable state between tests
- Use `TestDataFactory` for creating sample objects
- Integration tests must NEVER create orders, transfers, or any mutating operation

---

## After Upstream Sync

The SDK (`src/Io.Gate.GateApi/`) is auto-generated from an OpenAPI spec using [OpenAPI Generator](https://openapi-generator.tech). When syncing from upstream (`git rebase upstream/master`), the generated code may have changed. Run this verification sequence:

1. `dotnet build Io.Gate.GateApi.sln` — if this fails, constructor signatures or API method signatures changed
2. `dotnet test --filter "TestCategory=Unit"` — if this fails after build succeeds, behavioral contracts changed (JSON format, enum values, auth algorithm)
3. `dotnet test --filter "TestCategory=Integration"` — if this fails, real API response format changed

### Common fixes after upstream sync

| Symptom | Likely cause | Fix |
|---------|-------------|-----|
| Build error in `TestDataFactory` | Model constructor changed | Update factory method signature |
| Build error in API tests | API method got new required param | Add parameter to test call |
| Build error: type not found | Model/API class renamed or removed | Update or remove test |
| JSON round-trip test fails | Property renamed or enum value changed | Update test JSON and assertions |
| Integration test fails | API response structure changed | Update assertions |

### Why tests survive regeneration

- **Separate project**: Tests live in `Io.Gate.GateApi.Tests`, never touched by the generator
- **`.openapi-generator-ignore`**: Explicitly protects the test project and solution file
- **Factory pattern**: All model construction goes through `TestDataFactory` — constructor changes only need fixing in one place
- **Behavioral focus**: Tests verify contracts (serialization, auth, routing), not implementation details
- **`TestedSdkVersion`** in `TestDataFactory`: Records which SDK version tests were validated against

---

## Known Limitations

- **Private method testing**: `ApplyApiV4Auth`, `BuildQueryString`, and `ResolvePath` are private methods tested via `System.Reflection`. This is fragile if method signatures change.
- **Non-deterministic timestamp**: Authentication tests extract the timestamp from the request header after invocation and recompute the expected signature, rather than controlling the clock.
- **Internal classes**: `CustomJsonCodec` is `internal` and not directly testable without `InternalsVisibleTo`. Model serialization round-trip tests cover this behavior indirectly.
- **Generated code**: The library is auto-generated from an OpenAPI spec. Tests focus on behavioral contracts rather than implementation details, so they should survive regeneration.
