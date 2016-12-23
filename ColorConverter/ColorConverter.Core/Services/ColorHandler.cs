using MvvmCross.Platform.UI;

namespace ColorConverter.Core.Services
{
    public static class ColorHandler
    {
        public static MvxColor Convert(ColorEnum value)
        {
            var color = new MvxColor(0, 0, 0);
            switch (value)
            {
                case ColorEnum.Blue:
                    color = new MvxColor(19, 93, 230);
                    break;
                case ColorEnum.Green:
                    color = new MvxColor(13, 129, 21);
                    break;
                case ColorEnum.White:
                    color = new MvxColor(255, 255, 255);
                    break;
                default:
                    break;
            }
            return color;
        }
    }
}