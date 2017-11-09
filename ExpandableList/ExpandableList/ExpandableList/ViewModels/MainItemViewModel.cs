using ExpandableList.Core.Models;
using System.Collections.Generic;

namespace ExpandableList.Core.ViewModels
{
    public class MainItemViewModel : List<SecondItemViewModel>
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
            base.AddRange(new List<SecondItemViewModel> { new SecondItemViewModel("bla", "bla1"),
                                             new SecondItemViewModel("bla", "bla2"),
                                             new SecondItemViewModel("bla", "bla3"),
                                             new SecondItemViewModel("bla", "bla4"),
                                             new SecondItemViewModel("bla", "bla5"),
                                             new SecondItemViewModel("bla", "bla6") });
        }
    }
}