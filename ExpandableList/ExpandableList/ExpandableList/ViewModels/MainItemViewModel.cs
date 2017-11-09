using ExpandableList.Core.Models;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace ExpandableList.Core.ViewModels
{
    public class MainItemViewModel : List<DetailsItemViewModel>
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


        private ICommand sampleCommand;
        public ICommand SampleCommand
        {
            get
            {
                if (sampleCommand == null)
                    sampleCommand = new MvxCommand<object>(FireSample);
                return sampleCommand;
            }
        }

        private void FireSample(object obj)
        {
            var onlyForDebug = "working";
        }

        public MainItemViewModel(string title)
        {
            Item = new MainItem(title);
            base.AddRange(new List<DetailsItemViewModel> { new DetailsItemViewModel("bla", "bla1"),
                                             new DetailsItemViewModel("bla", "bla2"),
                                             new DetailsItemViewModel("bla", "bla3"),
                                             new DetailsItemViewModel("bla", "bla4"),
                                             new DetailsItemViewModel("bla", "bla5"),
                                             new DetailsItemViewModel("bla", "bla6") });
        }
    }
}