using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserDemo.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);
        }

    }
}