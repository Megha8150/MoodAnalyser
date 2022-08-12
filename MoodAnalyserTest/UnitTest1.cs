using MoodAnalyzerProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
<<<<<<< Updated upstream
            //Arrange
            //string message ="";
            string expected = "Constructor is not found";
            //Act
            string actual = (string)MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserPbr.MoodAnalyser", "MoodAnalyse");
            //Assert
            //expected.Equals(obj);
            Assert.AreEqual(expected, actual);
=======
            object expected = new MoodAnalyse("HAPPY"); //2000
                                                        //MoodAnalyser obj = (MoodAnalyser)expected;
            object expected1 = expected;
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDemo.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
            //Assert.AreEqual(expected, expected1);
>>>>>>> Stashed changes
        }
    }
}