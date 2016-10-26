using System;
using Bio.Primitives;

namespace Bio.Variations
{
    public interface IVariation : IComparable<IVariation>, IEquatable<IVariation>
    {
      SeqId SeqId { get; }
      uint From { get; }
      string Deleted { get; }
      string Inserted { get; }
    }
}
