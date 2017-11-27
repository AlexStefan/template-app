using Android.Support.V4.App;
using Java.Lang;

namespace FragmentManger.Droid
{
    public class TestAdapter : FragmentPagerAdapter
    {
        ICharSequence[] titles;
        Fragment[] fragments;

        public TestAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles)
           : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

        public override int Count => fragments.Length;

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return titles[position];
        }
    }
}