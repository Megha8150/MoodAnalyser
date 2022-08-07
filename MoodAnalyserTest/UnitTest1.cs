using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnsadMood()
        {
           MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in sad Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("sad",result);

        }

        [TestMethod]
        public void ShouldReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in any mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("happy", result);

        }

        [TestMethod]
        public void ShouldReturnHappyMoodWhenMessageIsNull()
        {

            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("happy", result);
        }
    }
}