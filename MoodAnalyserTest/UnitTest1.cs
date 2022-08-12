using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject(string message)
        {
            //Arrange
            // message ="";
            object expected = new MoodAnalyzer(message);
            //Act
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser");
            //Assert
            //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);
        }

    }
}