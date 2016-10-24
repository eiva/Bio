using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Primitives
{
   public enum MoleculeType
   {
      /// <summary>
      /// "g." coordinates in HGVS
      /// </summary>
      Genomic,
      /// <summary>
      /// "c." coordinates in HGVS
      /// </summary>
      Cdna,
      /// <summary>
      /// "n." coordinates in HGVS
      /// </summary>
      Rna,
      /// <summary>
      /// "p." coordinates in HGVS
      /// </summary>
      Protein,
      /// <summary>
      /// "mt." coordinates in HGVS
      /// </summary>
      Mitochondrion
   }
}
