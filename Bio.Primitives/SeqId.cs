using System;

namespace Bio.Primitives
{
    /// <summary>
    /// Represents sequence id in form of accession.version
    /// </summary>
   public sealed class SeqId : IComparable<SeqId>, IEquatable<SeqId>
   {
        /// <summary>
        /// Sequence accession.
        /// </summary>
      public string Accession { get; }

        /// <summary>
        /// Sequence version.
        /// </summary>
      public ushort Version { get; }

      public SeqId(string accession, ushort version)
      {
         if (accession == null)
         {
            throw new ArgumentNullException("accession");
         }
         Accession = accession.ToUpperInvariant();
         Version = version;
      }

      public static SeqId FromString(string serialized)
      {
            if (string.IsNullOrWhiteSpace(serialized))
                throw new ArgumentNullException(serialized);
            var parts = serialized.Split('.');
            if (parts.Length != 2)
                throw new ArgumentException("serialized", "Invalid format");
            return new SeqId(parts[0], ushort.Parse(parts[1]));
      }

      public int CompareTo(SeqId other)
      {
            var accCompare = string.Compare(Accession, other.Accession);
            if (accCompare != 0)
            {
                return accCompare;
            }
            else if (Version > other.Version)
            {
                return 1;
            }
            else if (Version < other.Version)
            {
                return -1;
            }
            else
            {
                return 0;
            }
      }

      public bool Equals(SeqId other)
      {
            if (other == null)
                return false;
            return other.Accession == Accession && other.Version == Version;
        }

      public override string ToString() => $"{Accession}.{Version}";
      
      public override int GetHashCode() => ToString().GetHashCode();

      public override bool Equals(object obj)
      {
            var s = obj as SeqId;
            if (s == null)
                return false;
            return s.Equals(s);
      }
   }
}
