using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.HashCodes;

public sealed record DiagramSeriesRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _diagramIdHash;

    private readonly IDeterminedHash _labelHash;

    private readonly IDeterminedHash _sourceHash;

    public DiagramSeriesRichRelationalModelHash(IDiagramSeriesRichRelationalModel model)
        : this(
            model.Id,
            model.DiagramId,
            (model as IDiagramSeriesRelationalModel).Label,
            (model as IDiagramSeriesRelationalModel).Source
        )
    { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IString label,
        IString source
    )
        : this(new DeterminedHash(id), diagramId, label, source) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid diagramId,
        IString label,
        IString source
    )
        : this(idHash, new DeterminedHash(diagramId), label, source) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash diagramIdHash,
        IString label,
        IString source
    )
        : this(id, diagramIdHash, new DeterminedHash(label), source) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IDeterminedHash labelHash,
        IString source
    )
        : this(id, diagramId, labelHash, new DeterminedHash(source)) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IString label,
        IDeterminedHash sourceHash
    )
        : this(new DeterminedHash(id), diagramId, label, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IString label,
        IString source
    )
        : this(idHash, diagramIdHash, new DeterminedHash(label), source) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid diagramId,
        IDeterminedHash labelHash,
        IString source
    )
        : this(idHash, diagramId, labelHash, new DeterminedHash(source)) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid diagramId,
        IString label,
        IDeterminedHash sourceHash
    )
        : this(idHash, new DeterminedHash(diagramId), label, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IString source
    )
        : this(new DeterminedHash(id), diagramIdHash, labelHash, source) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash diagramIdHash,
        IString label,
        IDeterminedHash sourceHash
    )
        : this(new DeterminedHash(id), diagramIdHash, label, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
        : this(id, new DeterminedHash(diagramId), labelHash, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IString source
    )
        : this(idHash, diagramIdHash, labelHash, new DeterminedHash(source)) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IString label,
        IDeterminedHash sourceHash
    )
        : this(idHash, diagramIdHash, new DeterminedHash(label), sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid diagramId,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
        : this(idHash, new DeterminedHash(diagramId), labelHash, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
        : this(new DeterminedHash(id), diagramIdHash, labelHash, sourceHash) { }

    public DiagramSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
    {
        _idHash = idHash;
        _diagramIdHash = diagramIdHash;
        _labelHash = labelHash;
        _sourceHash = sourceHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_diagramIdHash)
                .Concat(_labelHash)
                .Concat(_sourceHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
