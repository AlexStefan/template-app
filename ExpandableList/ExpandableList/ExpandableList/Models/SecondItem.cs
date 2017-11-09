namespace ExpandableList.Core.Models
{
    public class SecondItem
    {
        public string FirstText { get; set; }
        public string SecondText { get; set; }

        public SecondItem(string firstText, string secondText)
        {
            FirstText = firstText;
            SecondText = secondText;
        }
    }
}