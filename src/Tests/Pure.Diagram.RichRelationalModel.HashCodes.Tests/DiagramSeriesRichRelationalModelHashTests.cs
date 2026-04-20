using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RichRelationalModel.HashCodes.Tests;

public sealed record DiagramSeriesRichRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        148,
        26,
        157,
        1,
        61,
        231,
        240,
        121,
        184,
        126,
        28,
        232,
        138,
        37,
        101,
        163,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                model.DiagramId,
                (model as IDiagramSeriesRelationalModel).Label,
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                model.DiagramId,
                (model as IDiagramSeriesRelationalModel).Label,
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                new DeterminedHash(model.DiagramId),
                (model as IDiagramSeriesRelationalModel).Label,
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                model.DiagramId,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                model.DiagramId,
                (model as IDiagramSeriesRelationalModel).Label,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                new DeterminedHash(model.DiagramId),
                (model as IDiagramSeriesRelationalModel).Label,
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                model.DiagramId,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHasSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                model.DiagramId,
                (model as IDiagramSeriesRelationalModel).Label,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashLabelHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                new DeterminedHash(model.DiagramId),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                new DeterminedHash(model.DiagramId),
                (model as IDiagramSeriesRelationalModel).Label,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                model.DiagramId,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHashLabelHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                new DeterminedHash(model.DiagramId),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                (model as IDiagramSeriesRelationalModel).Source
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                new DeterminedHash(model.DiagramId),
                (model as IDiagramSeriesRelationalModel).Label,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);

        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                model.DiagramId,
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramHashLabelHashSourceHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);

        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                model.Id,
                new DeterminedHash(model.DiagramId),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromAllHashes()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        DiagramSeriesRichRelationalModelHash expected =
            new DiagramSeriesRichRelationalModelHash(model);
        DiagramSeriesRichRelationalModelHash actual =
            new DiagramSeriesRichRelationalModelHash(
                new DeterminedHash(model.Id),
                new DeterminedHash(model.DiagramId),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Label),
                new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        IEnumerable hashEnumerable = new DiagramSeriesRichRelationalModelHash(model);
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(
                    new DeterminedHash((model as IDiagramSeriesRelationalModel).Label)
                )
                .Concat(
                    new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
                )
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IDiagramSeriesRichRelationalModel model = new DiagramSeriesRichRelationalModel(
            new Guid(),
            new Guid(),
            new RandomString(),
            new RandomString()
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(
                    new DeterminedHash((model as IDiagramSeriesRelationalModel).Label)
                )
                .Concat(
                    new DeterminedHash((model as IDiagramSeriesRelationalModel).Source)
                )
        );

        Assert.Equal(expectedHash, new DiagramSeriesRichRelationalModelHash(model));
    }
}
