using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bio.Primitives;

namespace Bio.Variations
{
   public sealed class Contextual : IVariation
   {
      public string Deleted
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public uint From
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public string Inserted
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public SeqId SeqId
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public int CompareTo(IVariation other)
      {
         throw new NotImplementedException();
      }

      public bool Equals(IVariation other)
      {
         throw new NotImplementedException();
      }
   }
}
