using MSTest;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //1.
            //WordRearrange wordRearrange = new WordRearrange();
            //string expected = "YES";

            //string actual = wordRearrange.EligibleForNextRound("part","trap");

            //Assert.AreEqual(expected, actual);


            //2.
            PurchaseList purchaseList = new PurchaseList();
            string expected = "7\n5"; 

            string actual = purchaseList.Run("5 5 4 7 4 1 11");

            string[] expectedoutput = expected.Split('\n');
            string[] actualinput = actual.Split('\n');

            
            Assert.AreEqual(expectedoutput[0], actualinput[0]);
            Assert.AreEqual(expectedoutput[1], actualinput[1]);
        }  
    }
}