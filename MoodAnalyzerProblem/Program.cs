﻿// See https://aka.ms/new-console-template for more information
using MoodAnalyzerProblem;

MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
string result = moodAnalyzer.AnalyseMood("I am in a sad mood");
Console.WriteLine(result);
