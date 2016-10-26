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
            return SequenceUtils.SequenceFromString(id, sb.ToString());
        }
    }
}
