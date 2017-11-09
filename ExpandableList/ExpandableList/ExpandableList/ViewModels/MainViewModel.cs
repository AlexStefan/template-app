using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace ExpandableList.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private ObservableCollection<MainItemViewModel> items;

        public ObservableCollection<MainItemViewModel> Items
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
            Items = new ObservableCollection<MainItemViewModel>();
            for (int i = 0; i < 5; i++)
            {
                var mainItem = new MainItemViewModel($"text {i}", $"description {i}");
                Items.Add(mainItem);
            }
            RaisePropertyChanged(() => Items);
        }
    }
}