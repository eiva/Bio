using System;

namespace Bio.Primitives
{
    public interface IVariation : IComparable<IVariation>, IEquatable<IVariation>
    {
      SeqId SeqId { get; }
      uint From { get; }
      string Deleted { get; }
      string Inserted { get; }
    }
}
