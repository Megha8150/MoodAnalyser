using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyseMood("I am in Sad mood");
            Assert.AreEqual("sad",result);

        }
    }
}