namespace Fritz
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public string Answer { get; set; }

        public Question(string text, string[] options)
        {
            Text = text;
            Options = options;
        }
    }
}