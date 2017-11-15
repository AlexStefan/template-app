using ExpandableList.Models;

namespace ExpandableList.Core.ViewModels
{
    public class DetailsItemViewModel
    {
        private DetailsItem item;
        public DetailsItem Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public DetailsItemViewModel(string firstText, string secondText)
        {
            Item = new DetailsItem(firstText, secondText);
        }
    }
}