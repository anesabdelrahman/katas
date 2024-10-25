using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Tests.LeetCode
{
    //https://leetcode.com/problems/range-sum-query-immutable/description/
    [TestFixture(Category = "Leetcode", Reason = "Sliding Window")]
    internal class MaximizeTheConfusionOfExamTest
    {
        [Test]
        //[TestCase("TTFF", 2,4)]
        [TestCase("TFFT", 1,3)]
        public void GetTheIndecies(string input, int element, int expected)
        {
            var sut = new MaximizeTheConfusionOfExam();
            var result = sut.MaxConsecutiveAnswers(input, element);

            Assert.AreEqual(expected, result);
        }
    }

    internal class MaximizeTheConfusionOfExam
    {
            public int MaxConsecutiveAnswers(string answerKey, int k)
            {
                int MaxConsecutiveChars(char target)
                {
                    var maxCount = 0;
                    var start = 0;
                    var changes = 0;

                    for (var end = 0; end < answerKey.Length; end++)
                    {
                        if (answerKey[end] != target)
                        {
                            changes++;
                        }

                        while (changes > k)
                        {
                            if (answerKey[start] != target)
                            {
                                changes--;
                            }
                            start++;
                        }

                        maxCount = Math.Max(maxCount, end - start+1);
                    }


                    return maxCount;
                }
                return Math.Max(MaxConsecutiveChars('T'), MaxConsecutiveChars('F'));
            }
    }
}
