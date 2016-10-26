using System;

namespace Bio.Primitives
{
   public static class SequenceUtils
   {
      public static string GetString(this ISequence sequence, Interval interval)
      {
         throw new NotImplementedException();
      }

      #region Sequence from string

      private sealed class SequenceFromStringImpl : ISequence
      {
         private readonly string _seq;

         public SequenceFromStringImpl(SeqId seqId, string seq)
         {
            if (seqId == null)
               throw new ArgumentNullException("seqId");
            if (seq == null)
               throw new ArgumentNullException("seq");
            SeqId = seqId;
            _seq = seq;
         }

         public char this[uint position] => _seq[(int)position];

         public uint Length => (uint)_seq.Length;

         public MoleculeType MoleculeType
         {
            get
            {
               throw new NotImplementedException();
            }
         }

         public SeqId SeqId { get; }
      }

      public static ISequence SequenceFromString(SeqId seqId, string sequence)
      {
         return new SequenceFromStringImpl(seqId, sequence);
      }
      #endregion

      public static ISequence SequenceWithVariation(this ISequence sequence, IVariation variation)
      {
         throw new NotImplementedException();
      }
   }
}
