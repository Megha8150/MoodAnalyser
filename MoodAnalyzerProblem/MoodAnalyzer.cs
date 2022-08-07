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
            if (message.ToLower().Contains("sad"))

                return "Sad";
            else

                return "Happy";


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
