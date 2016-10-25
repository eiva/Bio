using Bio.Primitives;
using System;
using System.Net;
using System.Text;

namespace Bio.Primitives.Entrez
{
    public sealed class EntrezSequenceFactory : ISequenceFactory
    {
        public ISequence Get(SeqId id)
        {
            if (id == null)
                throw new ArgumentNullException("id");
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            WebClient web = new WebClient();
            string address = $"https://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=nuccore&id={id.ToString()}&rettype=fasta&retmode=text";
            var fasta = web.DownloadString(address);
            var result = fasta.Split('\n');
            var sb = new StringBuilder();
            for(int i = 1; i <result.Length; ++i)
            {
                sb.Append(result[i]);
            }
            return new Sequence(sb.ToString());
        }

        private sealed class Sequence : ISequence
        {
            private readonly string _seq;
            public Sequence(string seq)
            {
                if (seq == null)
                    throw new ArgumentNullException("seq");
                _seq = seq;
            }
            public char this[uint position]
            {
                get
                {
                    return _seq[(int)position];
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
                    return (uint)_seq.Length;
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
