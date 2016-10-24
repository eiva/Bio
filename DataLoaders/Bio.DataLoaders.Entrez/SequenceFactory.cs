using Bio.Primitives;
using System;
using System.Net;

namespace Bio.Primitives.Entrez
{
   // 
   public sealed class EntrezSequenceFactory : ISequenceFactory
   {
      public ISequence Get(SeqId id)
      {
         ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
         WebClient web = new WebClient();
         string accession = "NC_000007.13";
         string address = $"https://eutils.Bio.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=nuccore&id={accession}&rettype=fasta&retmode=text";
         var fasta = web.DownloadString(address);
         Console.WriteLine(fasta);

         throw new NotImplementedException();
      }

      private sealed class Sequence : ISequence
      {
         public char this[uint position]
         {
            get
            {
               throw new NotImplementedException();
            }
         }

         public char this[uint position, Strand strand]
         {
            get
            {
               throw new NotImplementedException();
            }
         }

         public uint Length
         {
            get
            {
               throw new NotImplementedException();
            }
         }

         public MoleculeType MoleculeType
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
      }
   }
}
