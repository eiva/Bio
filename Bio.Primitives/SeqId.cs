using System;

namespace Bio.Primitives
{
   public sealed class SeqId : IComparable<SeqId>, IEquatable<SeqId>, ISortable
   {
      private readonly string _accession;
      private readonly ushort _version;

      public SeqId(string accession, ushort version)
      {
         if (accession == null)
         {
            throw new ArgumentNullException("accession");
         }
         _accession = accession;
         _version = version;
      }

      public static SeqId FromString(string serialized)
      {
         throw new NotImplementedException();
      }

      public int CompareTo(SeqId other)
      {
         throw new NotImplementedException();
      }

      public bool Equals(SeqId other)
      {
         throw new NotImplementedException();
      }

      public override string ToString()
      {
         return $"{_accession}.{_version}";
      }

      public override int GetHashCode()
      {
         throw new NotImplementedException();
      }

      public override bool Equals(object obj)
      {
         throw new NotImplementedException();
      }

      public string ToSortableString()
      {
         throw new NotImplementedException();
      }
   }
}
