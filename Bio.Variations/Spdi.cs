using System;
using Bio.Primitives;

namespace Bio.Variations
{
   public sealed class Spdi : IVariation
   {

      public Spdi(SeqId id, uint from, string del, string ins)
      {
         if (id == null)
            throw new ArgumentNullException("id");
         if (del == null)
            throw new ArgumentNullException("del");
         if (ins == null)
            throw new ArgumentNullException("ins");
         SeqId = id;
         From = from;
         Deleted = del;
         Inserted = ins;
      }

      public string Deleted { get; }

      public uint From { get; }

      public string Inserted { get; }

      public SeqId SeqId { get; }

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
