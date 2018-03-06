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
                "I                             I        I     I\r\n" +
                ":  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:\r\n" +
                "I           I     I     I  I     I     I     I\r\n" +
                ":--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :\r\n" +
                "I        I  I  I     I  I     I     I     I  I\r\n" +
                ":--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :\r\n" +
                "I     I  I     I     I     I  I           I  I\r\n" +
                ":  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :\r\n" +
                "I  I  I     I        I     I  I     I     I  I\r\n" +
                ":  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :\r\n" +
                "I  I  I     I  I     I        I     I  I  I  I\r\n" +
                ":  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :\r\n" +
                "I  I     I     I  I  I        I  I     I  I  I\r\n" +
                ":  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :\r\n" +
                "I  I  I     I     I  I     I  I  I        I  I\r\n" +
                ":  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :\r\n" +
                "I           I  I     I  I  I     I     I  I  I\r\n" +
                ":--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :\r\n" +
                "I     I  I        I     I  I  I        I     I\r\n" +
                ":  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:\r\n" +
                "I  I  I     I  I     I     I  I        I     I\r\n" +
                ":--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :\r\n" +
                "I     I  I     I        I     I  I     I  I  I\r\n" +
                ":  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :\r\n" +
                "I        I  I     I     I     I  I        I  I\r\n" +
                ":  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :\r\n" +
                "I        I     I     I     I  I  I     I     I\r\n" +
                ":--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :\r\n" +
                "I     I     I  I  I  I     I     I  I        I\r\n" +
                ":  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:\r\n" +
                "I  I        I     I  I           I  I  I     I\r\n" +
                ":  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :\r\n" +
                "I  I        I  I  I     I     I  I           I\r\n" +
                ":  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:\r\n" +
                "I     I  I  I     I  I  I           I        I\r\n" +
                ":--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:\r\n" +
                "I     I  I     I     I              I        I\r\n" +
                ":  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :\r\n" +
                "I                 I  I     I     I           I\r\n" +
                ":--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:\r\n";
            
            Amazing.Random = new Random(0);
            Amazing.Doit(15, 20);
            Console.Write(Amazing.Result.ToString());
            Assert.AreEqual(expected, Amazing.Result.ToString());
        }

        [Test]
        public void TestSeed100Size4X5()
        {
            string expected =
                "Amazing - Copyright by Creative Computing, Morristown, NJ\r\n" +
                ":--:--:--:  :\r\n" +
                "I           I\r\n" +
                ":  :--:  :--:\r\n" +
                "I     I  I  I\r\n" +
                ":--:  :  :  :\r\n" +
                "I  I  I     I\r\n" +
                ":  :  :--:  :\r\n" +
                "I  I     I  I\r\n" +
                ":  :--:  :  :\r\n" +
                "I        I  I\r\n" +
                ":--:--:--:  :\r\n";

            Amazing.Random = new Random(100);
            Amazing.Doit(4, 5);
            Console.Write(Amazing.Result.ToString());
            Assert.AreEqual(expected, Amazing.Result.ToString());
        }

        [Test]
        public void TestRandomSeed()
        {
            Amazing.Doit(7, 9);
            Console.Write(Amazing.Result.ToString());
        }
    }
}