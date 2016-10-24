using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Primitives
{
   public interface ISequenceFactory
   {
      ISequence Get(SeqId id);
   }
}
