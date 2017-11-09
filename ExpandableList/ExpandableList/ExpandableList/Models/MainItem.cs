namespace ExpandableList.Models
{
    public class MainItem
    {
        public string FirstText { get; set; }
        public string SecondText { get; set; }

        public MainItem(string firstText, string secondText)
        {
            FirstText = firstText;
            SecondText = secondText;
        }
    }
}