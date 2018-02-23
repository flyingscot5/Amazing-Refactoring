using System;
using NUnit.Framework;

namespace Kode.net.Amazing
{
    [TestFixture]
    public class AmazingTests
    {

        [Test]
        public void testSeed0size15x20()
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


            Amazing.Random = new Random(0);
            Amazing.Doit(15, 20);
            Console.Write(Amazing.Result.ToString());
            Assert.AreEqual(expected, Amazing.Result.ToString());
        }

        [Test]
        public void testSeed100size4x5()
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

            Amazing.Random = new Random(100);
            Amazing.Doit(4, 5);
            Console.Write(Amazing.Result.ToString());
            Assert.AreEqual(expected, Amazing.Result.ToString());
        }
    }
}