namespace ExpandableList.Core.Models
{
    public class DetailsItem
    {
        public string FirstText { get; set; }
        public string SecondText { get; set; }

        public DetailsItem(string firstText, string secondText)
        {
            FirstText = firstText;
            SecondText = secondText;
        }
    }
}