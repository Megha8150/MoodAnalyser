using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnsadMood()
        {
           MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("Sad",result);

        }

        [TestMethod]
        public void ShouldReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in any mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("Happy", result);

        }
    }
}