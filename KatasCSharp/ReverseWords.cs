using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCSharp
{
    public class ReverseWords
    {

        public static string ReverseWord(string str)
        {

            string answer = string.Join(" ", str
                .Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));

            return answer;


        }

    }
}
