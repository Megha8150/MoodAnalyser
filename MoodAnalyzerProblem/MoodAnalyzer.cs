using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))

                    return "sad";
                else

                    return "happy";
            }

            catch(MoodAnalyzerCustomException e)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood can not be Empty");

            }


        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public MoodAnalyzer()
        {

        }
    }
   
}
