using System.Collections.Generic;
using System.Linq;

namespace Fritz
{
    public static class JobMatcher
    {
        private static readonly List<Job> Jobs = new List<Job>
        {
            new Job("Software Developer",
                "Develops and maintains software applications.",
                "Problem Solving, Programming",
                "College")
        };

        public static List<string> GetJobMatches(string answer1, string answer2, string answer3)
        {
            return Jobs
                .Where(job =>
                    (answer1.Contains("Problem Solving") && job.Skills.Contains("Problem Solving")) ||
                    (answer2.Contains("College") && job.EducationLevel == "College") ||
                    (answer3.Contains("Introverted") && job.Title == "Software Developer")) // Example logic
                .Select(job => job.Title)
                .ToList();
        }
        public static Job GetJobDetails(string jobTitle)
        {
            return Jobs.FirstOrDefault(job => job.Title == jobTitle);
        }
    }
}