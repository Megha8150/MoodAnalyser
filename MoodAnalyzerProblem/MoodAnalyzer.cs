using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string message;

        //public MoodAnalyser(string message)
        //{
        //    this.message = message;
        //}

        public string analyseMood()
        {
            try
            {   //"null"==""
                if (message == null)

                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");

                else if (this.message.Equals(string.Empty))  // ""==null

                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");

                else if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (MoodAnalyzerCustomException obj)
            {
                string exception = obj.Message;
                return exception;
            }

        }
    }