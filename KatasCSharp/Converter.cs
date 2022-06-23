using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCSharp
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            char[] dnaArray = dna.ToCharArray();
            int size = dnaArray.Length;
            char[] rnaArray = new char[size];
            int count = 0;
            foreach(char c in dnaArray)
            {
                if (c.Equals('T')){
                    rnaArray[count] = 'U';
                } else
                {
                    rnaArray[count] = c;
                }
                count = count + 1;
                
            }
            string rna = new string(rnaArray);
            return rna;

            //BEST PRACTICE
            //return dna.Replace('T', 'U');

        }
    }
}
