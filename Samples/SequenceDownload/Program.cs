using Bio.Primitives;
using Bio.Primitives.Entrez;
using System;

namespace SequenceDownload
{
   class Program
   {
      static void Main(string[] args)
      {
            var id = new SeqId("XR_242110", 1);
            var fac = new EntrezSequenceFactory();
            var seq = fac.Get(id);
            Console.WriteLine($"{id.ToString()} at 0 = {seq[0]}");
      }
   }
}
