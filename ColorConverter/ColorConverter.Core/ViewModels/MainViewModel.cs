using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.UI;
using ColorConverter.Core.Services;

namespace ColorConverter.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MvxColor TextColor { get; set; }
        
        public MvxColor BackgroundColor { get; set; } 

        public MvxColor ViewBackgroundColor { get; set; }

        public MainViewModel()
        {
            TextColor = ColorHandler.Convert(ColorEnum.Green);
            BackgroundColor = ColorHandler.Convert(ColorEnum.Blue);
            ViewBackgroundColor = ColorHandler.Convert(ColorEnum.White);
        }
    }
}