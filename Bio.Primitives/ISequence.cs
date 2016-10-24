using System;

namespace Bio.Primitives
{
   public interface ISequence
   {
      SeqId SeqId { get; }

      uint Length { get; }

      MoleculeType MoleculeType { get; }

      /// <summary>
      /// Get nucleotide on positive strand on required position.
      /// </summary>
      /// <param name="position"></param>
      /// <returns></returns>
      char this[uint position] { get; }

      char this[uint position, Strand strand] { get; }
   }

   public static class SequenceUtils
   {
      public static string GetString(this ISequence sequence, Interval interval)
      {
         throw new NotImplementedException();
      }
   }
}
