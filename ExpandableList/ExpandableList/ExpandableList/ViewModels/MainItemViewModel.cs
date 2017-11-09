using ExpandableList.Models;
using MvvmCross.Core.ViewModels;

namespace ExpandableList.Core.ViewModels
{
    public class MainItemViewModel : MvxViewModel
    {
        private MainItem item;
        public MainItem Item
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

        public MainItemViewModel(string firstText, string secondText)
        {
            Item = new MainItem(firstText, secondText);
        }
    }
}