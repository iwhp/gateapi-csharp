# Updating NuGet Packages \(`README-AM-UPDATE-NUGET.md`\)

This document describes how to update the NuGet package dependencies used by the Gate.io C# SDK and the test project.

> **Fork-only file**: This file exists only in the `iwhp/gateapi-csharp` fork and must not be included in Pull Requests to `gateio/gateapi-csharp`.

---

## Current Dependencies

### SDK Project \(`src/Io.Gate.GateApi/Io.Gate.GateApi.csproj`\)

| Package | Current Version | Usage | Risk Level |
|---------|:-:|---|:-:|
| `Newtonsoft.Json` | 13.0.4 | JSON serialization in all 254 models + Client infrastructure | **High** |
| `RestSharp` | 113.0.0 | HTTP client in `ApiClient.cs` \(`RestClient`, `RestRequest`, `RestResponse`\) | **High** |
| `JsonSubTypes` | 2.0.1 | Polymorphic JSON deserialization \(referenced in `.csproj`\) | Low |
| `System.ComponentModel.Annotations` | 5.0.0 | `[Required]`, `[Range]` validation attributes in models | Low |

These versions are **set by the OpenAPI Generator** during SDK generation. They are pinned to exact versions \(no floating ranges\).

### Test Project \(`src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj`\)

| Package | Current Version | Usage |
|---------|:-:|---|
| `MSTest` | 3.\* | Test framework \(floating major 3\) |
| `Moq` | 4.\* | Mocking `ISynchronousClient` / `IAsynchronousClient` |
| `coverlet.collector` | 6.\* | Code coverage collection |

These versions are **hand-written** and use floating version ranges, so they auto-resolve to the latest compatible version on restore.

---

## Path A: Wait for Upstream \(Recommended\)

This is the standard approach. Gate.io updates the NuGet package versions when they regenerate the SDK from a new OpenAPI spec.

### How it works

1. Gate.io regenerates the SDK with OpenAPI Generator
2. The generator template determines which package versions to use
3. The regenerated `Io.Gate.GateApi.csproj` contains the new versions
4. This fork syncs from upstream via `git rebase upstream/master`

### What to do

Follow the standard upstream sync process \(see `README-AM-GIT.md`\):

```bash
git checkout master
git fetch upstream
git rebase upstream/master
git push origin master
```

Then verify the build and tests \(see `README-AM-UPDATE-API.md`\).

### Advantages

- No risk of introducing incompatibilities — upstream tests their generated code
- Package versions stay in sync with the official NuGet package `Io.Gate.GateApi`
- No merge conflicts on `Io.Gate.GateApi.csproj` when syncing

---

## Path B: Update Locally \(Fork-Only\)

Use this when you need a newer package version before upstream updates \(e.g., a security fix, a bug fix you need, or .NET compatibility\).

> **Warning**: Local package updates are fork-only changes. They will cause merge conflicts when syncing from upstream, because the `.csproj` is auto-generated.

### Step 1: Check for available updates

```bash
# List outdated packages for the SDK project
dotnet list src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package --outdated

# List outdated packages for the test project
dotnet list src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj package --outdated
```

### Step 2: Update packages

Update one package at a time to isolate any breaking changes:

```bash
# Update a specific package
dotnet add src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package Newtonsoft.Json --version 13.0.4
dotnet add src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package RestSharp --version 113.0.0
dotnet add src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package JsonSubTypes --version 2.0.1
dotnet add src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package System.ComponentModel.Annotations --version 5.0.0
```

Or to update to the latest version:

```bash
dotnet add src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package RestSharp
```

### Step 3: Build and test

```bash
# Build the solution
dotnet build Io.Gate.GateApi.sln

# Run unit tests (no network required)
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj --filter "TestCategory=Unit"

# Run integration tests (verifies real API calls still work)
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj --filter "TestCategory=Integration"
```

### Step 4: Handle merge conflicts on next upstream sync

When you next sync from upstream, the auto-generated `Io.Gate.GateApi.csproj` will likely conflict with your local version changes. Resolve by:

1. Accept upstream's version \(revert to their package versions\) — **recommended**, keeps fork aligned
2. Keep your version \(if you specifically need the newer package\) — must re-resolve on every sync

---

## Package-Specific Upgrade Notes

### RestSharp \(High Risk\)

RestSharp has a history of major breaking changes between versions:

- **v106 → v107**: Complete API rewrite \(`IRestResponse` removed, `RestClient` became non-disposable then disposable again\)
- **v107 → v110+**: `RestClientOptions` pattern introduced, further API changes
- **v110 → v113**: Additional refinements

The SDK uses RestSharp in `src/Io.Gate.GateApi/Client/ApiClient.cs`:
- `RestClient`, `RestClientOptions`
- `RestRequest`, `RestResponse`
- `RestSharpMethod` \(aliased from `RestSharp.Method`\)

**Before upgrading**: Check the [RestSharp changelog](https://github.com/restsharp/RestSharp/releases) for breaking changes. Even minor version bumps can change behavior.

**After upgrading**: Run both unit and integration tests. Integration tests are critical here because they exercise the real HTTP pipeline.

### Newtonsoft.Json \(High Risk\)

Newtonsoft.Json is used by **every model class** \(254 files\) for:
- `[JsonProperty]` attributes
- `[JsonConverter]` with `StringEnumConverter`
- `JsonConvert.SerializeObject` / `DeserializeObject`
- `OpenAPIDateConverter` \(custom `IsoDateTimeConverter`\)

Newtonsoft.Json is generally backwards-compatible across minor versions, but verify:
- JSON round-trip tests cover serialization contracts
- `GateApiException.Message` serialization behavior

### JsonSubTypes \(Low Risk\)

Referenced in `.csproj` but not directly used in `using` statements in the source code. It is loaded by Newtonsoft.Json at runtime for polymorphic type handling. Generally safe to update.

### System.ComponentModel.Annotations \(Low Risk\)

Used for `[Required]`, `[Range]`, `[MinLength]`, `[MaxLength]` validation attributes on model properties. The API surface is stable and backwards-compatible. Generally safe to update.

---

## Updating Test Project Packages

The test project packages use floating version ranges \(`3.*`, `4.*`, `6.*`\) and auto-update on restore. To explicitly update:

```bash
# Update MSTest to latest 3.x
dotnet add src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj package MSTest

# Update Moq to latest 4.x
dotnet add src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj package Moq

# Update coverlet.collector to latest 6.x
dotnet add src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj package coverlet.collector
```

> **Note on Moq**: Moq version 4.20+ includes the controversial SponsorLink telemetry. If this is a concern, pin to `4.18.4` or consider alternatives. The current floating range `4.*` will resolve to the latest 4.x release.

After updating test packages, run the full test suite to verify compatibility:

```bash
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj
```

---

## Target Framework Considerations

The SDK targets `netstandard2.0`, which constrains which package versions can be used:

- Packages must support `netstandard2.0` \(or `netstandard1.x` / `net461+`\)
- The test project targets `net10.0` and has no such constraint
- If a package drops `netstandard2.0` support in a new major version, it cannot be used in the SDK

Check package compatibility before upgrading:

```bash
# Verify target framework compatibility
dotnet restore src/Io.Gate.GateApi/Io.Gate.GateApi.csproj
```

If restore fails with a compatibility error, the package version is too new for `netstandard2.0`.

---

## Quick Checklist

### SDK packages \(local update\)

- [ ] `dotnet list src/Io.Gate.GateApi/Io.Gate.GateApi.csproj package --outdated`
- [ ] Update one package at a time
- [ ] `dotnet build Io.Gate.GateApi.sln`
- [ ] `dotnet test --filter "TestCategory=Unit"` — all pass
- [ ] `dotnet test --filter "TestCategory=Integration"` — all pass
- [ ] Commit with clear message noting the package and version change

### Test project packages

- [ ] `dotnet list src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj package --outdated`
- [ ] Update packages
- [ ] `dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj` — all pass

---

## Related Documentation

- `README-AM-GIT.md` — Fork maintenance and upstream sync workflow
- `README-AM-UPDATE-API.md` — Updating to a new API version \(includes package version changes\)
- `src/Io.Gate.GateApi.Tests/README.md` — Test project documentation
