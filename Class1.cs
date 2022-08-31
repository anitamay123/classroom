using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork
{
    class Class1
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even");
            Assert.IsTrue(leftOver.Equals(0), "is even");
        }

        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Now is not 7 p.m.");
        }

        /*Testas 1 --> “žalias” jeigu 995 dalijasi iš 3 (be liekanos)*/

        [Test]
        public static void TestIf995DividsBy3() 
        {
            double leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "nera liekanos");

        }

        /*Testas 2 --> “žalias” jeigu šiandien penktadienis(DayOfWeek.Friday)*/
       
        [Test]
        public static void TestIfTodayIsFriday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Friday, currentTime.DayOfWeek, "Today is not Friday");

        }

        /*Testas 3 --> “žalias” po to kai “palaukia” 5 sekundes*/
        [Test]
        public static void TestIfWaitsFor5Sec()
        {
            Thread.Sleep(5000);
        }

        
    }
}
