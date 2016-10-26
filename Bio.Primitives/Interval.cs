using System;

namespace Bio.Primitives
{
   /// <summary>
   /// Represents interval on a sequence.
   /// </summary>
   public sealed class Interval : IComparable<Interval>, IEquatable<Interval>
   {
      /// <summary>
      /// Sequence id this interval is belongs to.
      /// </summary>
      SeqId SeqId { get; }

      /// <summary>
      /// Zero based position of interval on sequence.
      /// </summary>
      uint From { get; }

      Strand Strand { get; }

      uint Length { get; }

      public int CompareTo(Interval other)
      {
         throw new NotImplementedException();
      }

      public bool Equals(Interval other)
      {
         throw new NotImplementedException();
      }
   }
}
