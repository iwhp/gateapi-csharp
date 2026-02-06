# Updating the Gate.io C# SDK to a New API Version \(`README-AM-UPDATE-API.md`\)

This document describes how to update this fork \(`iwhp/gateapi-csharp`\) when Gate.io releases a new API version.

> **Fork-only file**: This file exists only in the `iwhp/gateapi-csharp` fork and must not be included in Pull Requests to `gateio/gateapi-csharp`.

---

## How the SDK Is Generated

The entire `src/Io.Gate.GateApi/` directory is **auto-generated** by [OpenAPI Generator](https://openapi-generator.tech) from Gate.io's OpenAPI specification:

- **Generator**: `org.openapitools.codegen.languages.CSharpNetCoreClientCodegen`
- **Spec**: Maintained by Gate.io \(not committed to the repository\)
- **Generated files**: All files under `src/Io.Gate.GateApi/` \(Api/, Model/, Client/\), `docs/`, and `README.md`
- **Hand-written files**: `src/Io.Gate.GateApi.Tests/`, `example/`, `README-AM-*.md`, `.openapi-generator-ignore`

Gate.io regenerates the SDK and pushes updates to `gateio/gateapi-csharp`. This fork then syncs from upstream.

---

## Version Numbers

When the SDK is regenerated, version numbers change in these locations \(all auto-generated except the last one\):

| File | What changes | Auto-generated? |
|------|-------------|:---:|
| `src/Io.Gate.GateApi/Io.Gate.GateApi.csproj` | `<Version>7.105.8</Version>` | Yes |
| `src/Io.Gate.GateApi/Client/Configuration.cs` | `Version` constant, `UserAgent` string, `ToDebugReport()` | Yes |
| `README.md` | API version and SDK version in header | Yes |
| `src/Io.Gate.GateApi.Tests/Helpers/TestDataFactory.cs` | `TestedSdkVersion` constant | **No** \(manual\) |

After updating, you must manually update `TestedSdkVersion` in `TestDataFactory.cs` to match the new SDK version.

---

## Path A: Sync from Upstream \(Most Common\)

This is the standard update path. Gate.io has already regenerated the SDK and pushed to their repository.

### Step 1: Fetch and rebase

```bash
git checkout master
git fetch upstream
git rebase upstream/master
```

For full sync details, see `README-AM-GIT.md`.

### Step 2: Resolve conflicts \(if any\)

The `.openapi-generator-ignore` file protects:
- `src/Io.Gate.GateApi.Tests/**` \(test project\)
- `Io.Gate.GateApi.sln` \(solution file with test project reference\)

Typical conflicts:
- **`Io.Gate.GateApi.sln`**: Upstream may overwrite the solution file without the test project reference. Re-add the test project entry after resolving.
- **`README-AM-*.md`**: These are fork-only and should not conflict with upstream.

### Step 3: Verify \(see below\)

### Step 4: Push to fork

```bash
git push origin master
```

---

## Path B: Local Regeneration \(Advanced\)

Use this if you need to regenerate the SDK locally, for example to test against a newer spec before upstream publishes.

### Prerequisites

- **Java 8+** \(required by OpenAPI Generator\)
- **OpenAPI Generator CLI** \(install via npm, Homebrew, or download JAR\)

```bash
# Option 1: npm
npm install @openapitools/openapi-generator-cli -g

# Option 2: Homebrew (macOS)
brew install openapi-generator

# Option 3: JAR download
wget https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/7.12.0/openapi-generator-cli-7.12.0.jar -O openapi-generator-cli.jar
```

### Obtain the OpenAPI spec

Gate.io publishes their API spec at:
- https://www.gate.com/docs/apiv4/en/index.html \(documentation\)
- The actual spec URL may need to be obtained from Gate.io support or extracted from their documentation site

### Run the generator

```bash
openapi-generator-cli generate \
  -i gate-api-spec.json \
  -g csharp-netcore \
  -o . \
  --package-name Io.Gate.GateApi \
  --additional-properties=targetFramework=netstandard2.0,packageVersion=NEW_VERSION
```

Or using the JAR directly:

```bash
java -jar openapi-generator-cli.jar generate \
  -i gate-api-spec.json \
  -g csharp-netcore \
  -o . \
  --package-name Io.Gate.GateApi \
  --additional-properties=targetFramework=netstandard2.0,packageVersion=NEW_VERSION
```

The `.openapi-generator-ignore` file ensures these files are **not overwritten**:
- `src/Io.Gate.GateApi.Tests/**`
- `Io.Gate.GateApi.sln`

### After regeneration

Proceed to the verification steps below.

---

## After Any Update: Verify and Fix Tests

Regardless of whether you synced from upstream or regenerated locally, run this verification sequence:

### Step 1: Build

```bash
dotnet build Io.Gate.GateApi.sln
```

If this fails, the generated code has breaking changes \(new required constructor parameters, renamed types, removed classes\).

### Step 2: Run unit tests

```bash
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj --filter "TestCategory=Unit"
```

If this fails after build succeeds, behavioral contracts changed \(JSON format, enum values, auth algorithm\).

### Step 3: Run integration tests

```bash
dotnet test src/Io.Gate.GateApi.Tests/Io.Gate.GateApi.Tests.csproj --filter "TestCategory=Integration"
```

If this fails, real API response format changed.

### Common fixes

| Symptom | Likely cause | Fix |
|---------|-------------|-----|
| Build error in `TestDataFactory` | Model constructor changed | Update factory method signature |
| Build error in API tests | API method got new required param | Add parameter to test call |
| Build error: type not found | Model/API class renamed or removed | Update or remove affected test |
| JSON round-trip test fails | Property renamed or enum value changed | Update test JSON and assertions |
| Integration test fails | API response structure changed | Update assertions |

### Step 4: Update TestedSdkVersion

After all tests pass, update the version constant in `src/Io.Gate.GateApi.Tests/Helpers/TestDataFactory.cs`:

```csharp
public const string TestedSdkVersion = "NEW_VERSION_HERE";
```

---

## NuGet Publishing

The fork has a GitHub Actions workflow \(`.github/workflows/nuget-publish.yml`\) that automatically publishes to NuGet when a git tag is pushed:

```bash
# Create and push a tag to trigger NuGet publish
git tag v7.NEW.VERSION
git push origin v7.NEW.VERSION
```

The workflow:
1. Checks out the code
2. Runs `dotnet pack`
3. Pushes the `.nupkg` to nuget.org using the `NUGET_API_KEY` secret

---

## Quick Checklist

Use this checklist when updating to a new API version:

- [ ] **Sync**: `git fetch upstream && git rebase upstream/master`
- [ ] **Conflicts**: Re-add test project to `Io.Gate.GateApi.sln` if overwritten
- [ ] **Build**: `dotnet build Io.Gate.GateApi.sln` passes
- [ ] **Unit tests**: `dotnet test --filter "TestCategory=Unit"` passes \(fix if needed\)
- [ ] **Integration tests**: `dotnet test --filter "TestCategory=Integration"` passes
- [ ] **Version**: Update `TestedSdkVersion` in `TestDataFactory.cs`
- [ ] **Push**: `git push origin master`
- [ ] **Tag** \(if publishing\): `git tag vX.Y.Z && git push origin vX.Y.Z`

---

## Related Documentation

- `README-AM-GIT.md` — Fork maintenance, remotes setup, upstream sync workflow
- `src/Io.Gate.GateApi.Tests/README.md` — Test project documentation, API keys, test categories
- `.openapi-generator-ignore` — Files protected from generator overwrite
