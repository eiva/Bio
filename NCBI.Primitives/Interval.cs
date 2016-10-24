using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCBI.Primitives
{
   /// <summary>
   /// Represents interval on a sequence.
   /// </summary>
   public sealed class Interval : IComparable<Interval>, IEquatable<Interval>, ISortable
   {
      SeqId SeqId { get;  }
      uint From { get; }
      /// <summary>
      /// Is on positive strand.
      /// </summary>
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

      public string ToSortableString()
      {
         throw new NotImplementedException();
      }
   }
}
