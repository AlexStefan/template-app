namespace ExpandableList.Core.Models
{
    public class MainItem
    {
        public string Title { get; set; }
        public string SecondText { get; set; }

        public MainItem(string firstText, string secondText)
        {
            Title = firstText;
            SecondText = secondText;
        }
    }
}