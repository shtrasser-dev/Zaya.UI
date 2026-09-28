# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/),
and this project adheres to the versioning scheme in [docs/versioning.md](docs/versioning.md).

## [Unreleased]

## [2.0.0.0] - 2026-09-28

### Fixed

- Version Major now pins to `Zaya.Primitives`' Major (`ZayaPrimitivesVersion` in `Directory.Build.props`), enforced at build, matching the rule used by `Zaya.OCR`/`Screenshot`/`Translator`. `Zaya.UI` depends on `Zaya.Primitives`, so it should never have versioned itself independently. 1.0.0.0 was published under the wrong scheme and should be treated as superseded.

## [1.0.0.0] - 2026-08-20

Initial release: Avalonia setting editors extracted from ScreenTranslator.

### Added

- `SettingDescriptorListControl` and Setting* factories over `SettingDescriptor`.
- Chrome strings for integer validation and table add/remove.
