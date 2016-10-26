using Bio.Primitives;
using System;

namespace Bio.Variations
{
   public static class VariationUtils
   {
      /// <summary>
      /// Blossom precision algorithm implementation.
      /// </summary>
      /// <param name="spdi"></param>
      /// <param name="sequenceFactory"></param>
      /// <returns></returns>
      public static Contextual Disambiguate(this Spdi spdi, ISequenceFactory sequenceFactory)
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Second order expansion algorithm implementation.
      /// </summary>
      /// <param name="variation"></param>
      /// <param name="sequenceFactory"></param>
      /// <returns></returns>
      public static Spdi SecondOrderExpansion(this IVariation variation, ISequenceFactory sequenceFactory)
      {
         throw new NotImplementedException();
      }

      public static VariationType VariationType(this IVariation variation)
      {
         throw new NotImplementedException();
      }
   }
}
