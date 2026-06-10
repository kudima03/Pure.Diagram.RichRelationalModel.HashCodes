# Pure.Diagram.RichRelationalModel.HashCodes

Deterministic hash code implementations for diagram rich relational model entities in the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.HashCodes/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.HashCodes/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.HashCodes/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.HashCodes/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel.HashCodes)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel.HashCodes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel.HashCodes` provides deterministic, byte-enumerable hash codes for every type in the diagram rich relational model. Each type implements `IDeterminedHash` and prepends a unique 16-byte type-discriminator prefix before hashing.

## Hash Types

| Type | Wraps | Hashed fields |
|---|---|---|
| `DiagramRichRelationalModelHash` | `IDiagramRichRelationalModel` | Id, Title, Description, TypeId, Type, Series |
| `DiagramTypeRichRelationalModelHash` | `IDiagramTypeRichRelationalModel` | Id, Name |
| `DiagramSeriesRichRelationalModelHash` | `IDiagramSeriesRichRelationalModel` | Id, DiagramId, Label, Source |

## Dependencies

- [`Pure.Diagram.RichRelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions) — rich relational diagram interfaces
- [`Pure.HashCodes`](https://github.com/kudima03/Pure.HashCodes) — deterministic hash computation
