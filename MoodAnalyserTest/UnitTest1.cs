using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnsadMood()
        {
           MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyseMood("I am in Sad mood");
            Assert.AreEqual("sad",result);

        }

        [TestMethod]
        public void ShouldReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyseMood("I am in any mood");
            Assert.AreEqual("happy", result);

        }
    }
}