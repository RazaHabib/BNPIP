using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOperations;
using System.Collections.Generic;

namespace StringOperations.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void filterListDataTest()
        {
            List<string> inputList = new List<string>() { "al", "albums", "aver", "bar", "barely", "be", "befoul", "bums", "by", "cat", "con", "convex", "ely", "foul",
"here", "hereby", "jig", "jigsaw", "or", "saw", "tail", "tailor", "vex", "we", "weaver"};
            List<string> expectedList = new List<string>() { "albums","barely","befoul", "convex", "hereby", "jigsaw", "tailor", "weaver"};
            List<string> actualList = Program.filterListData(inputList);
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}