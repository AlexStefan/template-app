using ExpandableList.Core.Models;

namespace ExpandableList.Core.ViewModels
{
    public class SecondItemViewModel
    {
        private SecondItem item;
        public SecondItem Item
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

        public SecondItemViewModel(string firstText, string secondText)
        {
            Item = new SecondItem(firstText, secondText);
        }
    }
}