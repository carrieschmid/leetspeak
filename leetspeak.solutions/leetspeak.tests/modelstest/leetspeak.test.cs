using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.tests
{
    [TestClass]

    public class LeetSpeakTest
    {
        [TestMethod]

        public void

        Main_IsEqualToE_3()
        {
            LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
            Assert.AreEqual("3", testLeetSpeak.Main("e"));
        }
    }
}