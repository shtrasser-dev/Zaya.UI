# Versioning (Zaya.UI)

`Zaya.UI` depends on `Zaya.Primitives`, so it follows the ecosystem generation rule from
[Zaya.Primitives/docs/versioning.md](https://github.com/shtrasser-dev/Zaya.Primitives): its **Major** is
pinned to `Zaya.Primitives`' Major, not versioned independently. Same rule as `Zaya.OCR`, `Zaya.Screenshot`,
and `Zaya.Translator`.

| Axis | Source | Example |
|------|--------|---------|
| **ZayaPrimitivesVersion** | `Directory.Build.props`, pinned to the published Zaya.Primitives package | `2.0.0` |
| **implVersion** | Impl csproj `ZayaVersionImpMajor` + `ZayaVersionImpMinor` | `2.0.0.0` |

There is no abstract package yet. Version is `PrimitivesMajor.0.ImpMajor.ImpMinor`. The second digit is reserved for a future interface version.

Do not set `<Version>` manually. Bump Imp digits for control fixes; bump `ZayaPrimitivesVersion` (and republish) when Zaya.Primitives' major advances.
