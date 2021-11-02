using System;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class TwelveDaysToChristmasTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            var expectedResult =
                "On the first day of Christmas," +
"\nMy true love gave to me:" +
"\nA partridge in a pear tree." +

"On the second day of Christmas," +
"\nMy true love gave to me:" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the third day of Christmas," +
"\nMy true love gave to me:" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the forth day of Christmas," +
"\nMy true love gave to me:" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the fifth day of Christmas," +
"\nMy true love gave to me:" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the sixth day of Christmas," +
"\nMy true love gave to me:" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the seventh day of Christmas," +
"\nMy true love gave to me:" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the eight day of Christmas," +
"\nMy true love gave to me:" +
"\nEight maids a - milking" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the ninth day of Christmas," +
"\nMy true love gave to me:" +
"\nNine ladies dancing" +
"\nEight maids a-milking" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the tenth day of Christmas," +
"\nMy true love gave to me:" +
"\nTen lords a - leaping" +
"\nNine ladies dancing" +
"\nEight maids a-milking" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n" +
"\nOn the eleventh day of Christmas," +
"\nMy true love gave to me:" +
"\nEleven pipers piping" +
"\nTen lords a-leaping" +
"\nNine ladies dancing" +
"\nEight maids a-milking" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves and" +
"\nA partridge in a pear tree." +
"\n"+
"\nOn the Twelfth day of Christmas," +
"\nMy true love gave to me:" +
"\nTwelve drummers drumming" +
"\nEleven pipers piping" +
"\nTen lords a - leaping" +
"\nNine ladies dancing" +
"\nEight maids a-milking" +
"\nSeven swans a - swimming" +
"\nSix geese a - laying" +
"\nFive golden rings" +
"\nFour calling birds" +
"\nThree french hens" +
"\nTwo turtle doves" +
"\nAnd a partridge in a pear tree.";

            var sut = new TwelveDaysToChristmas();
            var result = sut.GetCarolLyrics();
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }
    }
}
