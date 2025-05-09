namespace Fritz
{
    public class Job
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string EducationLevel { get; set; }

        public Job(string title, string description, string skills, string educationLevel)
        {
            Title = title;
            Description = description;
            Skills = skills;
            EducationLevel = educationLevel;
        }
    }
}