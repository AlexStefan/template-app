using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace ExpandableList.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private List<MainItemViewModel> items;

        public List<MainItemViewModel> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        public MainViewModel()
        {
            Items = new List<MainItemViewModel>();
            for (int i = 0; i < 5; i++)
            {
                var mainItem = new MainItemViewModel($"text {i}", $"description {i}");
                Items.Add(mainItem);
            }
            RaisePropertyChanged(() => Items);
        }
    }
}