using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace NekgikisCode.Tests
{
    [TestClass()]
    public class DecoderTests
    {
        [TestMethod()]
        public void CleanStringTest()
        {
            Decoder decoder = new Decoder();
            IsTrue(decoder.CleanString("Cómo será dar con Nekgikis V...") == "comoseradarconnekgikisv...");
        }

        [TestMethod()]
        public void BuildDictionaryTest()
        {
            Decoder decoder = new Decoder();
            var dict1 = decoder.BuildDictionary("1, 2", "ab");
            var dict2 = new Dictionary<int, char>();
            dict2.Add(1, 'a');
            dict2.Add(2, 'b');
            var dictionary = new Dictionary<int, char>(dict1);
            AreEqual(dictionary.Count, dict2.Count);
        }

        [TestMethod()]
        public void GenerateURLTest()
        {
            Decoder decoder = new Decoder();
            var dictionary = new Dictionary<int, char>();
            dictionary.Add(0, 'a');
            dictionary.Add(1, 'b');
            IsTrue(decoder.GenerateURL(dictionary) == "ab");
        }

        [TestMethod()]
        public void ConnectionTestURLTest()
        {
            Decoder decoder = new Decoder();
            IsTrue(decoder.ConnectionTestURL("v.generacionk.kairosds.com") == true);
        }
    }
}