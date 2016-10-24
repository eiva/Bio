using Bio.Primitives;
using System.Collections.Generic;

namespace Bio.Alignments
{
   public interface IRelocator
   {
      IEnumerable<Interval> Relocate(Interval interval);
   }
}