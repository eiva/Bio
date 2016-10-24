using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCBI.Primitives;

namespace NCBI.Variations
{
    public interface IVariation : IComparable<IVariation>, IEquatable<IVariation>, ISortable
    {
      SeqId SeqId { get; }
      uint From { get; }
      string Deleted { get; }
      string Inserted { get; }
    }
}
