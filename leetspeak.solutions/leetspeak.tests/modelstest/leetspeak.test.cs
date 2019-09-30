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
        
        [TestMethod]

        public void

        Main_IsEqualToO_0()
        {
            LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
            Assert.AreEqual("0", testLeetSpeak.Main("o"));
        }
        [TestMethod]

        public void

        Main_IsEqualToI_1()
        {
            LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
            Assert.AreEqual("1", testLeetSpeak.Main("I"));
        }
        [TestMethod]

        public void

        Main_IsEqualToT_7()
        {
            LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
            Assert.AreEqual("7", testLeetSpeak.Main("t"));
        }
        [TestMethod]

        public void

        Main_IsEqualToS_Z()
        {
            LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
            Assert.AreEqual("z", testLeetSpeak.Main("s"));
        }

    }
}