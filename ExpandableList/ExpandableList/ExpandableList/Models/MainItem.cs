using System.Collections.Generic;

namespace ExpandableList.Core.Models
{
    public class MainItem : List<SecondItem>
    {
        private List<SecondItem> SecondItems;

        public string Title { get; set; }
        public string SecondText { get; set; }

        public MainItem(string firstText, string secondText)
        {
            Title = firstText;
            SecondText = secondText;

            base.AddRange(new List<SecondItem> { new SecondItem("bla", "bla1"),
                                             new SecondItem("bla", "bla2"),
                                             new SecondItem("bla", "bla3"),
                                             new SecondItem("bla", "bla4"),
                                             new SecondItem("bla", "bla5"),
                                             new SecondItem("bla", "bla6") });
        }
    }
}