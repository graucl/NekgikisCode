using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace NekgikisCode
{
    public class Decoder
    {
        public string CleanString(string sentence)
        {
            Console.WriteLine("Original sentence --> " + sentence);
            var noAccents = Regex.Replace(sentence.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9. ]+", "");
            var result = noAccents.Replace(" ", "").ToLower();
            Console.WriteLine("Sentence cleaned --> " + result);

            return result;
        }

        public Dictionary<int, char> BuildDictionary(string numbers, string sentence)
        {
            var dictionary = new Dictionary<int, char>();
            numbers = numbers.Replace(" ", "");
            var numList = numbers.Split(',').Select(Int32.Parse).ToList();
            List<char> sentenceChars = sentence.ToList();
            dictionary = Enumerable.Range(0, numList.Count).ToDictionary(x => numList[x], x => sentenceChars[x]);

            return dictionary;
        }
        
        public string GenerateURL(Dictionary<int, char> dictionary)
        {
            var url = "";

            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary.ContainsKey(i))
                {
                    url += dictionary[i];
                }
            }

            Console.WriteLine("URL decoded --> " + url);
            return url;
        }

        public bool ConnectionTestURL(string url)
        {
            WebRequest request;
            HttpWebResponse response;
            try
            {
                if (url != null)
                {
                    request = WebRequest.Create("https://" + url);
                    response = (HttpWebResponse)request.GetResponse();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
