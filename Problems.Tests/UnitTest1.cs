using NUnit.Framework;


namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
			//arrange
			string expected = "5,1:hello";
			
			//Act
			Prefix("hello");
			
			//assert
            Assert.AreEqual(expected,"hello");
        }
		
		public void Test2()
        {
			//arrange
			string expected = "0,0:";
			
			//act
			Prefix("");
			
			//assert
            Assert.AreEqual(expected,"");
        }
		
		public void Test3()
        {
			//arrange
			string expected = "27,5:what ... did you say?? ";
			
			//act
			Prefix("27,5:what ... did you say?? ");
			
			//assert
            Assert.AreEqual(expected, "27,5:what ... did you say?? ");
        }
    }
}