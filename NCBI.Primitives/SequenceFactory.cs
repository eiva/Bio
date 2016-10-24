using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCBI.Primitives
{
   public interface SequenceFactory
   {
      ISequence Get(SeqId id);
   }
}
