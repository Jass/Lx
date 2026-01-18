using ConsoleApp1.Business.Interfaces;

namespace TestProjectN
{
    public class Tests
    {
        private IArrayLibrary _arrayLibrary  = new ConsoleApp1.Business.Services.ArrayLibrary();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[]{0,2,1},3)]
        [TestCase(new int[]{11,9,7,3,1,0,2,8,4,10,6}, 5)]
        
        public void Test_Find(int[] array, int expectedMissing)
        {
            var result = _arrayLibrary.FindMissingNumber(array);
            Assert.AreEqual(expectedMissing, result);
        }

        [TestCase(new int[] { 11, 9, 7, 3, 1, 0, 2, 8, 4, 10})]
        public void Test_Fail(int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayLibrary.FindMissingNumber(array));
        }
    }
}