# Versioning (Zaya.UI)

| Axis | Source | Example |
|------|--------|---------|
| **ZayaUiMajor** | `Directory.Build.props` | `1` |
| **implVersion** | Impl csproj `ZayaVersionImpMajor` + `ZayaVersionImpMinor` | `1.0.0.0` |

There is no abstract package yet. Version is `Major.0.ImpMajor.ImpMinor`. The second digit is reserved for a future interface version.

Do not set `<Version>` manually. Bump Imp digits for control fixes; bump `ZayaUiMajor` for breaking UI API changes.
