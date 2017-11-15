﻿using ExpandableList.Models;
using MvvmCross.Core.ViewModels;

namespace ExpandableList.Core.ViewModels
{
    public class DetailsViewModel : MvxViewModel<DetailsItem>
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

        //See more info on this here: https://stackoverflow.com/questions/10658913/what-is-the-best-way-to-pass-objects-to-navigated-to-viewmodel-in-mvvmcross
        public DetailsViewModel(DetailsItem parameter)
        {
            Item = parameter;
        }

        public override void Prepare(DetailsItem parameter)
        {
            Item = parameter;
        }
    }
}