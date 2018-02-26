using System;
using NUnit.Framework;

namespace Kode.net.Amazing
{
    [TestFixture]
    public class AmazingTests
    {

        [Test]
        public void TestSeed0Size15X20()
        {
            string expected = "Amazing - Copyright by Creative Computing, Morristown, NJ\r\n" +
                ":--:--:--:--:--:--:--:--:--:--:  :--:--:--:--:\r\n" +
                "I                             I        I     I \r\n" +
                ":  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:\r\n" +
                "I           I     I     I  I     I     I     I \r\n" +
                ":--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :\r\n" +
                "I        I  I  I     I  I     I     I     I  I \r\n" +
                ":--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :\r\n" +
                "I     I  I     I     I     I  I           I  I \r\n" +
                ":  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :\r\n" +
                "I  I  I     I        I     I  I     I     I  I \r\n" +
                ":  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :\r\n" +
                "I  I  I     I  I     I        I     I  I  I  I \r\n" +
                ":  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :\r\n" +
                "I  I     I     I  I  I        I  I     I  I  I \r\n" +
                ":  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :\r\n" +
                "I  I  I     I     I  I     I  I  I        I  I \r\n" +
                ":  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :\r\n" +
                "I           I  I     I  I  I     I     I  I  I \r\n" +
                ":--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :\r\n" +
                "I     I  I        I     I  I  I        I     I \r\n" +
                ":  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:\r\n" +
                "I  I  I     I  I     I     I  I        I     I \r\n" +
                ":--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :\r\n" +
                "I     I  I     I        I     I  I     I  I  I \r\n" +
                ":  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :\r\n" +
                "I        I  I     I     I     I  I        I  I \r\n" +
                ":  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :\r\n" +
                "I        I     I     I     I  I  I     I     I \r\n" +
                ":--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :\r\n" +
                "I     I     I  I  I  I     I     I  I        I \r\n" +
                ":  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:\r\n" +
                "I  I        I     I  I           I  I  I     I \r\n" +
                ":  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :\r\n" +
                "I  I        I  I  I     I     I  I           I \r\n" +
                ":  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:\r\n" +
                "I     I  I  I     I  I  I           I        I \r\n" +
                ":--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:\r\n" +
                "I     I  I     I     I              I        I \r\n" +
                ":  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :\r\n" +
                "I                 I  I     I     I           I \r\n" +
                ":--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:\r\n";


            Amazing.random = new Random(0);
            Amazing.doit(15, 20);
            Console.Write(Amazing.result.ToString());
            Assert.AreEqual(expected, Amazing.result.ToString());
        }

        [Test]
        public void TestSeed100Size4X5()
        {
            string expected =
                "Amazing - Copyright by Creative Computing, Morristown, NJ\r\n" +
                ":--:--:--:  :\r\n" +
                "I           I \r\n" +
                ":  :--:  :--:\r\n" +
                "I     I  I  I \r\n" +
                ":--:  :  :  :\r\n" +
                "I  I  I     I \r\n" +
                ":  :  :--:  :\r\n" +
                "I  I     I  I \r\n" +
                ":  :--:  :  :\r\n" +
                "I        I  I \r\n" +
                ":--:--:--:  :\r\n";

            Amazing.random = new Random(100);
            Amazing.doit(4, 5);
            Console.Write(Amazing.result.ToString());
            Assert.AreEqual(expected, Amazing.result.ToString());
        }



        [Test]
        public void TestSeedRandomSize()
        {
            Amazing.random = new Random(2002);
            Amazing.doit(5, 5);
            Console.Write(Amazing.result.ToString());
        }
    }
}