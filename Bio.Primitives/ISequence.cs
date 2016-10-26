using System;

namespace Bio.Primitives
{
   /// <summary>
   /// Genetical sequence of any kind.
   /// </summary>
   public interface ISequence
   {
      /// <summary>
      /// Sequence id.
      /// </summary>
      SeqId SeqId { get; }

      /// <summary>
      /// Sequence length.
      /// </summary>
      uint Length { get; }

      MoleculeType MoleculeType { get; }

      /// <summary>
      /// Get nucleotide on positive strand on required position.
      /// </summary>
      /// <param name="position">Requested position.</param>
      /// <returns>Nucleotide.</returns>
      char this[uint position] { get; }
   }
}
