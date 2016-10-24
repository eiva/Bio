using NCBI.Primitives;
using System.Collections.Generic;

namespace NCBI.Alignments
{
   public interface IRelocator
   {
      IEnumerable<Interval> Relocate(Interval interval);
   }
}