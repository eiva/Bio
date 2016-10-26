namespace Bio.Primitives
{
   public enum VariationType
   {
      /// <summary>
      /// A=
      /// </summary>
      Identity,
      /// <summary>
      /// A>
      /// </summary>
      Del,
      /// <summary>
      /// >A
      /// </summary>
      Ins,
      /// <summary>
      /// A>G
      /// </summary>
      Snp,
      /// <summary>
      /// AA>GG
      /// </summary>
      Mnp,
      /// <summary>
      /// AA>C;A>GG;
      /// </summary>
      DelIns
   }
}
