using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NekgikisCode
{
    public class Decoder
    {
        public string cleanString(string sentence)
        {
            Console.WriteLine("Original sentence --> " + sentence);
            var noAccents = Regex.Replace(sentence.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9. ]+", "");
            var result = noAccents.Replace(" ", "").ToLower();
            Console.WriteLine("Sentence cleaned --> " + result);

            return result;
        }
    }
}
