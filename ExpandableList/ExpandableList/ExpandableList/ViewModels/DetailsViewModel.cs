using ExpandableList.Core.Models;
using MvvmCross.Core.ViewModels;

namespace ExpandableList.Core.ViewModels
{
    public class DetailsViewModel : MvxViewModel
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

        public DetailsViewModel()
        {
            
        }
    }
}