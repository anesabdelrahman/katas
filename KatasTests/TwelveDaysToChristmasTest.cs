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
"My true love gave to me:" +
"A partridge in a pear tree." +
"\n" +
"On the second day of Christmas," +
"My true love gave to me:" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the third day of Christmas," +
"My true love gave to me:" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the forth day of Christmas," +
"My true love gave to me:" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the fifth day of Christmas," +
"My true love gave to me:" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the sixth day of Christmas," +
"My true love gave to me:" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the seventh day of Christmas," +
"My true love gave to me:" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the eight day of Christmas," +
"My true love gave to me:" +
"Eight maids a - milking" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the ninth day of Christmas," +
"My true love gave to me:" +
"Nine ladies dancing" +
"Eight maids a - milking" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the tenth day of Christmas," +
"My true love gave to me:" +
"Ten lords a - leaping" +
"Nine ladies dancing" +
"Eight maids a - milking" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"\n" +
"On the eleventh day of Christmas," +
"My true love gave to me:" +
"Eleven pipers piping" +
"Ten lords a - leaping" +
"Nine ladies dancing" +
"Eight maids a - milking" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves and" +
"A partridge in a pear tree." +
"" +
"On the Twelfth day of Christmas," +
"My true love gave to me:" +
"Twelve drummers drumming" +
"Eleven pipers piping" +
"Ten lords a - leaping" +
"Nine ladies dancing" +
"Eight maids a - milking" +
"Seven swans a - swimming" +
"Six geese a - laying" +
"Five golden rings" +
"Four calling birds" +
"Three french hens" +
"Two turtle doves" +
"And a partridge in a pear tree.";

            var sut = new TwelveDaysToChristmas();
            var result = sut.GetCarolLyrics();
            TestContext.WriteLine($"result: {result}");
            Assert.AreEqual(result, expectedResult);
        }
    }
}
