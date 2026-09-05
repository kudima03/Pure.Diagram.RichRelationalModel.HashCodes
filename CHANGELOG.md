# Changelog

All notable changes to Pure.Diagram.RichRelationalModel.HashCodes are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-20

### Changed

- **Breaking:** `SeriesRichRelationalModelHash` renamed to
  `DiagramSeriesRichRelationalModelHash`, matching the `Series` → `DiagramSeries`
  rename in `Pure.Diagram.RichRelationalModel.Abstractions`. Its constructors now
  take `IDiagramSeriesRichRelationalModel` instead of `ISeriesRichRelationalModel`.
- **Breaking:** `DiagramRichRelationalModelHash` constructors now accept
  `IEnumerable<IDiagramSeries>` instead of `IEnumerable<ISeries>` for the series
  parameter.
- Updated `Pure.Diagram.Model.HashCodes`, `Pure.Diagram.RichRelationalModel`, and
  `Pure.Diagram.RichRelationalModel.Abstractions` dependencies to
  `0.1.0-preview.1.0.0`.

## [0.1.0-preview.0.1.0] — 2026-04-01

### Added

- **`DiagramRichRelationalModelHash`** — deterministic `IDeterminedHash` over an
  `IDiagramRichRelationalModel`, combining hashes of its id, title, description,
  type id, diagram type, and series collection.
- **`DiagramTypeRichRelationalModelHash`** — deterministic `IDeterminedHash` over
  an `IDiagramTypeRichRelationalModel`, combining hashes of its id and name.
- **`SeriesRichRelationalModelHash`** — deterministic `IDeterminedHash` over an
  `ISeriesRichRelationalModel`, combining hashes of its id, diagram id, label, and
  source.
