using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

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

        private ICommand showMoreDetailsCommand;
        public ICommand ShowMoreDetailsCommand
        {
            get
            {
                if (showMoreDetailsCommand == null)
                    showMoreDetailsCommand = new MvxCommand<object>(ShowMoreDetails);

                return showMoreDetailsCommand;
            }
        }

        private void ShowMoreDetails(object obj)
        {
            var selectedItem = obj as DetailsItemViewModel;
            ShowViewModel<DetailsViewModel, DetailsItemViewModel>(selectedItem);
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<MainItemViewModel>();
            for (int i = 0; i < 5; i++)
            {
                var mainItem = new MainItemViewModel($"text {i}");
                Items.Add(mainItem);
            }
            RaisePropertyChanged(() => Items);
        }
    }
}