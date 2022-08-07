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

            catch(Exception e)
            {
                return "happy";
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
