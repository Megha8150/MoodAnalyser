using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MoodAnalyzerProblem
{
        public class MoodAnalyserFactory
        {
            public static object CreateMoodAnalyser(string className)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalysType = assembly.GetType(className);
                return Activator.CreateInstance(moodAnalysType);
            }
        }
    
}
