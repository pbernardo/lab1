using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using System.ComponentModel;
using lab1;
using lab1.Droid;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(lab1.Droid.DigitalFontEffect), "FontEffect")]
namespace lab1.Droid
{
    public class DigitalFontEffect : PlatformEffect
    {
        TextView control;
        protected override void OnAttached()
        {
            try
            {
                control = Control as TextView;
                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/" + lab1.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == lab1.DigitalFontEffect.FontFileNameProperty.PropertyName)
            {
                Typeface font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "Fonts/" + lab1.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
        }
    }
}